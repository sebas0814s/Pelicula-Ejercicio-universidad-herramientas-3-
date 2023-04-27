using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pelicula.Models;

namespace pelicula.Data
{
    public class peliculaContext : DbContext
    {
        public peliculaContext (DbContextOptions<peliculaContext> options)
            : base(options)
        {
        }

        public DbSet<pelicula.Models.Movie> Movie { get; set; } = default!;
    }
}
