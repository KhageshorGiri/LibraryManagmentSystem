using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AdditionalInfo { get; set; }

        //retaion refrence
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }
    }
}
