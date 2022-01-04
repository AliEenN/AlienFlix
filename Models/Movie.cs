using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlienFlix.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }

        [Required, MaxLength(2500)]
        public string Storyline { get; set; }

        [Required]
        public byte[] Poster { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Genre> Genres { get; set; }
        public ICollection<GenreMovie> GenresMovies { get; set; }
    }
}
