using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Book
    {
        public Book()
        {
            BookAuthors = new HashSet<BookAuthor>();
            Issues = new HashSet<Issue>();
        }

        [Key]
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string ImagePath { get; set; }
        public string numberOfPage { get; set; }
        public string Format { get; set; }
        public string price { get; set; }
        public string Language { get; set; }
        public string PurchaseDate { get; set; }
        public string PublishDate { get; set; }
        public string Status { get; set; }

        // Relationship: Refrence
      
        public int? CategoryId { get; set; }
        public virtual BookCategory BookCategory { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }

    }
}
