using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Repository
{
    public interface IExtra
    {
        public string totalBook();
        public string totalmember();
        public string issuedBook();
        public string dueBook();

    }
}
