using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Core.Entitites;

namespace Cinema.Core.interfaces
{
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        void Save();
    }
}
