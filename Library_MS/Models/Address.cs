using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Address
    {
        public Address()
        {
            Members = new HashSet<Member>();
            Librarians = new HashSet<Librarian>();
        }

        [Key]
        public int AddressID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AdditionalInfo { get; set; }

        //retaion refrence
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Librarian> Librarians { get; set; }
    }
}
