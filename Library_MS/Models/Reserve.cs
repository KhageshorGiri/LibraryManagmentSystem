using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Models
{
    public class Reserve
    {
        [Key]
        public int ReserveID { get; set; }
        public string ReserveDate { get; set; }
        public string Remarks { get; set; }

        //
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
