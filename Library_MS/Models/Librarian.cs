using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Librarian
    {
        public Librarian()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int LibrarianId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Required]
        public string ImagePath { get; set; }



        // reltaion: Foreign key refrance
        public int? AddressID { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
