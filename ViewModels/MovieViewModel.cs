using AlienFlix.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlienFlix.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }

        [Range(1, 10)]
        public double Rate { get; set; }

        [Required, StringLength(2500)]
        public string Storyline { get; set; }

        [Display(Name = "Select poster ...")]
        public byte[] Poster { get; set; }
        public bool IsDeleted { get; set; }

        [Display(Name = "Genres")]
        public List<CheckBoxViewModel> Genres { get; set; }
    }
}
