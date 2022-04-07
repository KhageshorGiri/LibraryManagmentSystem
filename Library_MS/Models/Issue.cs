using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Issue
    {
        [Key]
        public int IssueID { get; set; }
        public string issueDate { get; set; }
        public string returnDate { get; set; }
        public string dueDate { get; set; }
        public bool ReturnStaus {get; set; }

        //Relation: Fk refrence
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }
    }
}
