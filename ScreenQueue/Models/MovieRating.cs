using System;
using System.ComponentModel.DataAnnotations;

namespace ScreenQueue.Models
{
    public class MovieRating
    {
        public int Id { get; set; }


        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        [Range(1, 5)]
        public int Score { get; set; }

        [StringLength(500)]
        public string? Comment { get; set; }

        [DataType(DataType.Date)]
        public DateTime RatedOn { get; set; } = DateTime.Today;
    }
}