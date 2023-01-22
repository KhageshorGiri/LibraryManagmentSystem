using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class ExceptionLog
    {
        [Key]
        public int ExceptionId { get; set; }
        public string ExceptionMessage { get; set; }
        public string Path { get; set; }
        public string StackTrace { get; set; }
        public int? CreatedBy { get; set; }
    }
}
