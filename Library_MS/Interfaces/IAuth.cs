using Library_MS.DTOs;
using Library_MS.Models;

namespace Library_MS.Interfaces
{
    public interface IAuth
    {
        public void Register(RegisterLogin register);

      
        public User getUser(string userName);
    }
}
