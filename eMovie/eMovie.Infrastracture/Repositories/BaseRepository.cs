using eMovie.Domain.Entities;
using eMovie.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Infrastracture.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>     
        where TEntity : BaseEntity          //kade shto Tentity e tip od BASE ENTITY
        // nasleduva od IBaseRepository 
    {


        protected eMovieDbContext _contex;          //mora da bide protected za da se nasleduva

        public BaseRepository(eMovieDbContext context)
        {
            _contex = context;
        }

        // site metodi se handlaat ( ushte e generichki )
        public void Add(TEntity entity)
        {
            _contex.Set<TEntity>().Add(entity);
        }



        public void Save()
        {
            _contex.SaveChanges();          //da zachuvuva
        }
    }
}
