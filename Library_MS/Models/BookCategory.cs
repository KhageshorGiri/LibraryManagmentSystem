using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class BookCategory
    {
        public BookCategory()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        public int CategoryID { get; set; }
        public string Category { get; set; }

        //Relation: refrence
        public virtual ICollection<Book> Books { get; set; }
        
    }
}
