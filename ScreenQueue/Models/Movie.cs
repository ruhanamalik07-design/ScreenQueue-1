using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScreenQueue.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Genre { get; set; }

        public int? ReleaseYear { get; set; }

        public ICollection<MovieRating> Ratings { get; set; } = new List<MovieRating>();
    }

 
}
