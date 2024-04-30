using FindAMovie.Models;
using System.Collections.Generic;

namespace FindAMovie.Models.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers {  get; set; }
    }
}