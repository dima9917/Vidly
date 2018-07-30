using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<string> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}