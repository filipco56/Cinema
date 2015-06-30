using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Core.Entitites
{
    public class User : BaseEntity
    { 
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        public bool  isAdmin { get; set; }

      

    }
}
