using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        //Eden film pripagja na 1 zarn
        public Genre Genre { get; set; }
    }
}
