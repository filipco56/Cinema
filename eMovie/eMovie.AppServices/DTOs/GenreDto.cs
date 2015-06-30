using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.AppServices.DTOs
{
    public class GenreDto
    {
        //tuka idat rabotite shto se nosat na view
        // moze da se koristi DataAnotetion;

        public int Id { get; set; }

        public string Name { get; set; }

    }
}
