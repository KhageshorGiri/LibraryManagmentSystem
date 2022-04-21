using Library_MS.DTOs;
using Library_MS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Repository
{
    public interface IAuth
    {
        public void Register(RegisterLogin register);

      
        public User getUser(string userName);
    }
}
