using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class BookAuthor
    {
        [Key]
        public int BookAuthorID { get; set; }
        public int? BookId { get; set; }
        public int? AuthorID { get; set; }
        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}
