using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalebMovie.Models;

namespace CalebMovie.Data
{
    public class CalebMovieContext : DbContext
    {
        public CalebMovieContext (DbContextOptions<CalebMovieContext> options)
            : base(options)
        {
        }

        public DbSet<CalebMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
