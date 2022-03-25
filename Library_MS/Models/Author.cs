using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        [Key]
        public int AuthorID { get; set; }
        public string Name { get; set; }
        

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
