using eMovie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Domain.Interfaces              //vo interfejsite se samo kreiranjeto methodi ne implemantacijata
{
    public interface IBaseRepository<TEntity>   //generichki method 
        where TEntity : BaseEntity              // where TEntites --> Kje bide tip na base entity ( site nasleduvaat od nego )
    {
        void Add(TEntity entity);
        void Save();
        
    }
}
