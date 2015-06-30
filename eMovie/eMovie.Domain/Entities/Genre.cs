using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }


        // Vo eden zharn moze da pripagaat povekje filmovi
        public ICollection<Movie> Movies { get; set; }
    }
}
