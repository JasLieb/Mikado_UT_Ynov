using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ynov.TU.Mikado.Models
{
    [Table("User")]
    public class User
    {
        //User's discriminent Id primary key in database
        public int Id { get; set; }
        //User's email used for login
        public string Email { get; set; }
        //User's password used for login
        public string Password { get; set; }
        //Bool property set as true if a user is librarian
        public bool IsLibrarian { get; set; }
    }
}
