using eMovie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Domain.Interfaces
{
    public interface IGenreRepository : IBaseRepository<Genre>      // nasleduva od IBaseRepository za shto prima generichki Entty --> Genre
    {
    }
}
