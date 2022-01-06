using AlienFlix.Constants;
using AlienFlix.Data;
using AlienFlix.Models;
using AlienFlix.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AlienFlix.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IToastNotification _toastNotification;

        public MoviesController(ApplicationDbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(
                await _context.Movies
                    .Where(e => e.IsDeleted == false)
                    .Select(e => new MovieViewModel {
                        Id = e.Id,
                        Poster = e.Poster,
                        Rate = e.Rate,
                        Storyline = e.Storyline,
                        Title = e.Title,
                        Year = e.Year,
                        Genres = _context.GenresMovies
                            .Where(m => m.MovieId == e.Id)
                            .Include(e => e.Genre)
                            .Select(g => new CheckBoxViewModel
                            { Name = g.Genre.Name }).ToList()
                    })
                    .OrderBy(e => e.Rate)
                    .ToListAsync()
            );
        }

        // GET
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager + "," + Roles.DataEntry)]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View("MovieForm", new MovieViewModel()
            {
                Genres = await _context.Genres.OrderBy(e => e.Name).Select(e => new CheckBoxViewModel { Id = e.Id, Name = e.Name }).ToListAsync()
            });
        }

        // POST
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager + "," + Roles.DataEntry)]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(MovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("MovieForm", model);
            }

            if (model.Genres.Where(e => e.IsSelected == true).ToList().Count < 1)
            {
                ModelState.AddModelError("Genres", "Please select at lest one movie genres");
                return View("MovieForm", model);
            }

            var files = Request.Form.Files;

            if (!files.Any())
            {
                ModelState.AddModelError("Poster", "Please select movie poster");
                return View("MovieForm", model);
            }

            var poster = files.FirstOrDefault();

            if (poster.Length > 1048576)
            {
                ModelState.AddModelError("Poster", "Poster cannot be more than 1 MB");
                return View("MovieForm", model);
            }

            using var dataStream = new MemoryStream();
            await poster.CopyToAsync(dataStream);

            await _context.Movies.AddAsync(new Movie
            {
                Title = model.Title,
                Year = model.Year,
                Rate = model.Rate,
                IsDeleted = false,
                Storyline = model.Storyline,
                Poster = dataStream.ToArray()
            });
            _context.SaveChanges();

            var currentMovie = await _context.Movies.FirstAsync(e => e.Title == model.Title);
            var genresMoviesList = new List<GenreMovie>();

            foreach (var genre in model.Genres)
            {
                if (genre.IsSelected)
                {
                    genresMoviesList.Add(new GenreMovie { MovieId = currentMovie.Id, GenreId = genre.Id });
                }
            }

            await _context.GenresMovies.AddRangeAsync(genresMoviesList);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Movie Created Successfly.");

            return RedirectToAction(nameof(Index));
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return BadRequest();

            var movieExist = await _context.Movies.FindAsync(id);

            if (movieExist == null || movieExist.IsDeleted)
                return NotFound();

            return View(new MovieViewModel
            {
                Id = movieExist.Id,
                Title = movieExist.Title,
                Year = movieExist.Year,
                Rate = movieExist.Rate,
                Poster = movieExist.Poster,
                Storyline = movieExist.Storyline,
                Genres = await _context.GenresMovies.Where(e => e.MovieId == movieExist.Id).Include(e => e.Genre).Select(e => new CheckBoxViewModel { Name = e.Genre.Name }).ToListAsync()
            });
        }

        // GET
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager + "," + Roles.DataEntry)]
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return BadRequest();

            var movieExist = await _context.Movies.FindAsync(id);

            if (movieExist == null || movieExist.IsDeleted)
                return NotFound();

            var genresList = await _context.Genres.ToListAsync();
            var genresIds = await _context.GenresMovies.Where(e => e.MovieId == movieExist.Id).Select(e => e.GenreId).ToListAsync();

            return View("MovieForm", new MovieViewModel
            {
                Id = movieExist.Id,
                Title = movieExist.Title,
                Year = movieExist.Year,
                Rate = movieExist.Rate,
                Poster = movieExist.Poster,
                Storyline = movieExist.Storyline,
                Genres = genresList.Select(e => new CheckBoxViewModel { Id = e.Id, Name = e.Name, IsSelected = genresIds.Contains(e.Id) }).ToList()
            });
        }

        // POST
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager + "," + Roles.DataEntry)]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(MovieViewModel model)
        {
            if (!ModelState.IsValid)
                return View("MovieForm", model);

            var movieExist = await _context.Movies.FirstOrDefaultAsync(e => e.Title == model.Title && e.Id != model.Id);

            if (movieExist != null)
            {
                if (movieExist.IsDeleted)
                {
                    ModelState.AddModelError("Title", "This movie is already exist but in trash!");
                    return View("CategoryForm", model);
                }

                ModelState.AddModelError("Title", "This movie is already exist!");
                return View("CategoryForm", model);
            }

            movieExist = await _context.Movies.FindAsync(model.Id);
            movieExist.Title = model.Title;
            movieExist.Storyline = model.Storyline;
            movieExist.Rate = model.Rate;
            movieExist.Year = model.Year;

            var files = Request.Form.Files;
            byte[] newPoster = movieExist.Poster;

            if (files.Any())
            {
                var poster = files.FirstOrDefault();

                if (poster.Length > 1048576)
                {
                    ModelState.AddModelError("Poster", "Poster cannot be more than 1 MB");
                    return View("MovieForm", model);
                }

                using var dataStream = new MemoryStream();
                await poster.CopyToAsync(dataStream);

                newPoster = dataStream.ToArray();
            }

            movieExist.Poster = newPoster;

            var genresIds = await _context.GenresMovies.Where(e => e.MovieId == movieExist.Id).Select(e => e.GenreId).ToListAsync();

            var genresMoviesToDelete = new List<GenreMovie>();
            var genresMoviesToAdd = new List<GenreMovie>();

            foreach (var genre in model.Genres)
            {
                if (genresIds.Contains(genre.Id) && !genre.IsSelected)
                {
                    genresMoviesToDelete.Add(new GenreMovie { MovieId = movieExist.Id, GenreId = genre.Id });
                }

                if (!genresIds.Contains(genre.Id) && genre.IsSelected)
                {
                    genresMoviesToAdd.Add(new GenreMovie { MovieId = movieExist.Id, GenreId = genre.Id });
                }
            }

            _context.GenresMovies.RemoveRange(genresMoviesToDelete);
            _context.GenresMovies.AddRange(genresMoviesToAdd);
            _context.Movies.Update(movieExist);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Movie Updated Successfly.");

            return RedirectToAction(nameof(Index));
        }

        // POST
        [Authorize(Roles = Roles.Admin + "," + Roles.Manager)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();

            var movieExist = await _context.Movies.FindAsync(id);

            if (movieExist == null || movieExist.IsDeleted)
                return NotFound();

            movieExist.IsDeleted = true;

            _context.Movies.Update(movieExist);
            await _context.SaveChangesAsync();

            _toastNotification.AddSuccessToastMessage("Movie Deleted Successfly.");

            return Ok();
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Trash()
        {
            return View(
                await _context.Movies
                    .Where(e => e.IsDeleted == true)
                    .Select(e => new MovieViewModel
                    {
                        Id = e.Id,
                        Poster = e.Poster,
                        Rate = e.Rate,
                        Storyline = e.Storyline,
                        Title = e.Title,
                        Year = e.Year,
                        Genres = _context.GenresMovies
                            .Where(m => m.MovieId == e.Id)
                            .Include(e => e.Genre)
                            .Select(g => new CheckBoxViewModel
                            { Name = g.Genre.Name }).ToList()
                    })
                    .ToListAsync()
            );
        }

        // POST
        public async Task<IActionResult> Undo(int? id)
        {
            if (id == null)
                return BadRequest();

            var movieExist = await _context.Movies.FindAsync(id);

            if (movieExist == null || movieExist.IsDeleted == false)
                return NotFound();

            movieExist.IsDeleted = false;

            _context.Movies.Update(movieExist);
            await _context.SaveChangesAsync();

            _toastNotification.AddSuccessToastMessage("Movie Back To List Successfly.");

            return RedirectToAction(nameof(Index));
        }

        // POST
        public async Task<IActionResult> FinalDelete(int? id)
        {
            if (id == null)
                return BadRequest();

            var movieExist = await _context.Movies.FindAsync(id);

            if (movieExist == null || movieExist.IsDeleted == false)
                return NotFound();

            _context.Movies.Remove(movieExist);
            await _context.SaveChangesAsync();

            _toastNotification.AddSuccessToastMessage("Movie Deleted Successfly.");

            return Ok();
        }
    }
}
