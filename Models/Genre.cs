using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlienFlix.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
        public ICollection<GenreMovie> GenresMovies { get; set; }
    }
}
