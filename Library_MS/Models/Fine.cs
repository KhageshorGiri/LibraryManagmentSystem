using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Fine
    {
        [Key]
        public int FineID { get; set; }
        public string FineDate { get; set; }
        public decimal FineAmount { get; set; }

        public int IssueID { get; set; }
        public virtual Issue Issue { get; set; }
    }
}
