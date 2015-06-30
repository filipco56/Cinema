using eMovie.Domain.Entities;
using eMovie.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Infrastracture.Repositories
{
    public interface IMovieRepository : IBaseRepository<Movie>, IMovieRepository
    {

        public IMovieRepository(eMovieDbContext context) : base (context)
        {

        }

      


    }
}
