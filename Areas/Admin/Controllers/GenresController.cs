using AlienFlix.Data;
using AlienFlix.Models;
using AlienFlix.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlienFlix.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenresController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IToastNotification _toastNotification;

        public GenresController(ApplicationDbContext db, IToastNotification toastNotification)
        {
            _context = db;
            _toastNotification = toastNotification;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Genres.Select(e => new GenreViewModel { Id = e.Id, Name = e.Name } ).OrderBy(e => e.Name).ToListAsync());
        }

        // POST
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(GenreViewModel model)
        {
            if (!ModelState.IsValid)
                return View(nameof(Index), await _context.Genres.Select(e => new GenreViewModel { Id = e.Id, Name = e.Name }).OrderBy(e => e.Name).ToListAsync());

            var genreExist = await _context.Genres.FirstOrDefaultAsync(e => e.Name == model.Name);

            if (genreExist != null)
            {
                ModelState.AddModelError("Name", "This genre is already existing.");
                return View(nameof(Index), await _context.Genres.Select(e => new GenreViewModel { Id = e.Id, Name = e.Name }).OrderBy(e => e.Name).ToListAsync());
            }

            await _context.Genres.AddAsync(new Genre
            {
                Name = model.Name
            });
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Genre Created Successfully");

            return RedirectToAction(nameof(Index));
        }

        // Get
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return BadRequest();

            var genreExist = await _context.Genres.FindAsync(id);

            if (genreExist == null)
                return NotFound();

            return View(new GenreViewModel {
                Id = genreExist.Id,
                Name = genreExist.Name,
                Movies = await _context.GenresMovies.Where(e => e.GenreId == genreExist.Id).Include(e => e.Movie).Select(e => e.Movie).ToListAsync()
            });
        }

        // POST
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();

            var genreExist = await _context.Genres.FindAsync(id);

            if (genreExist == null)
                return NotFound();

            _context.Genres.Remove(genreExist);
            await _context.SaveChangesAsync();

            _toastNotification.AddSuccessToastMessage("Genre Deleted Successfully");

            return Ok();
        }
    }
}
