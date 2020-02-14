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
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BorrowDate { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
    }

    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Table("Favourite")]
    public class Favourite
    {
        public int UserId { get; set; }
        public int MediaId { get; set; }
    }
}
