using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated {get; set;}


        //po default da ima deneshna data
        public BaseEntity()
        {
            DateCreated = DateTime.Now;
        }
    }
}
