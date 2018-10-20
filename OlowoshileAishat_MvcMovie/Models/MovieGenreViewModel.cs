using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OlowoshileAishat_MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}