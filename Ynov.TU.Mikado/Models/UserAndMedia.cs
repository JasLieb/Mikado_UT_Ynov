using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ynov.TU.Mikado.Models
{
    //Entity reflecting favourite table (references medias added as favourite by a user
    [Table("Favourite")]
    public class Favourite
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Media")]
        public int MediaId { get; set; }
    }

    //Entity reflecting "emprunt" table (references medias borrowed by a user, 7 days borrow max
    [Table("Borrow")]
    public class Borrow
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Media")]
        public int MediaId { get; set; }
        public DateTime BorrowDate { get; set; }
    }
}
