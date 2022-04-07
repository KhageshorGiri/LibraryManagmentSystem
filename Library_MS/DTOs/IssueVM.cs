using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.DTOs
{
    public class IssueVM
    {
        [StringLength(200)]
        public string BookImge { get; set; }
        [StringLength(100)]
        public string BookTitle { get; set; }
        [StringLength(20)]
        public string Category { get; set; }
        [StringLength(10)]
        public string Language { get; set; }
        [StringLength(10)]
        public string Format { get; set; }
        [StringLength(100)]
        public string Authors { get; set; }
        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(200)]
        public string MemberName { get; set; }
        [StringLength(100)]
        public string MemberImage { get; set; }
        [StringLength(20)]
        public string MembershipDate { get; set; }
        
        public int bookCount { get; set; }

        [StringLength(25)]
        public string bookISBN { get; set; }
        [StringLength(10)]
        public string memberCode { get; set; }
        [StringLength(20)]
        public string issueDate { get; set; }
        [StringLength(20)]
        public string dueDate { get; set; }
    }
}
