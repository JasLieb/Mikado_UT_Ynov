using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ynov.TU.Mikado.Models
{
    [Table("Media")]
    public class Media
    {
        //Media discriminent Id primary key in database media table
        public int Id { get; set; }
        //Media name
        public string Name { get; set; }
        //Media category foreign key referencing Category table in database
        public MediaCategory Category{ get; set; }
    }

    //Enum reflecting Category table (defining a media category)
    public enum MediaCategory
    {
        Book,
        Movie,
        Music
    }
}
