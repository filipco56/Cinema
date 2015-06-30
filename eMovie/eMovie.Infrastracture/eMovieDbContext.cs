using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eMovie.Domain.Entities;

namespace eMovie.Infrastracture
{
    public class eMovieDbContext : DbContext
    {
		public eMovieDbContext (string cnnString) : base(cnnString)
        {

		}

		// gi setirame site table
		public DbSet<Genre> Genres {get; set;}
		public DbSet<Movie> Movies {get; set;}


    }
}
