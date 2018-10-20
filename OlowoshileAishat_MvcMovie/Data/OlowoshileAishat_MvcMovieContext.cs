using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OlowoshileAishat_MvcMovie.Models
{
    public class OlowoshileAishat_MvcMovieContext : DbContext
    {
        public OlowoshileAishat_MvcMovieContext (DbContextOptions<OlowoshileAishat_MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<OlowoshileAishat_MvcMovie.Models.Movie> Movie { get; set; }
    }
}
