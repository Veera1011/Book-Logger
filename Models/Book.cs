using System;
using System.ComponentModel.DataAnnotations;

namespace BookLogger.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }
        public string Genre { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string Status { get; set; } // Reading, Completed, To Read
        public int? Rating { get; set; }

        public string Notes { get; set; }
    }
}
