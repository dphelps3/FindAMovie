using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindAMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Genre { get; set; }
        public DateTime? DateReleased { get; set; }
        public DateTime? DateAdded { get; set; }
        public int InStock { get; set; }
    }
}