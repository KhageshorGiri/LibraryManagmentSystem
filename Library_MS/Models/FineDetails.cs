using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class FineDetails
    {
        [Key]
        public int FineDetailsID { get; set; }
        public string PayedDate { get; set; }
        public decimal? PaidAmount { get; set; }

        public int MemberID { get; set; }
        public virtual Member Member { get; set; }


    }
}
