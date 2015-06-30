using eMovie.Domain.Entities;
using eMovie.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Infrastracture.Repositories
{
    public interface IGenreRepository : IBaseRepository<Genre>, IGenreRepository
    {
        // konstruktor za Ovoj interface shto nasleduva od base (context)
        public IGenreRepository(eMovieDbContext context) : base (context)
        {

        }

        void Add(Genre entity);
        void Save();
    }
}
