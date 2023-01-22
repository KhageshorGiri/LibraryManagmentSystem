using Library_MS.DTOs;
using Library_MS.Model_DBContext;
using Library_MS.Models;
using Library_MS.Interfaces;
using System.Linq;

namespace Library_MS.Services
{
    public class AuthService : IAuth
    {
        private readonly LibraryContext db;
        public AuthService(LibraryContext _context)
        {
            this.db = _context;
        }

        public User getUser(string userName)
        {
            var user = db.Users.Where(q => q.UserName.Replace(" ", "") == userName.Replace(" ", "")).FirstOrDefault();
            return user;
        }

        public void Register(RegisterLogin register)
        {
            Librarian lb = new Librarian();
            lb.FullName = register.FullName;
            lb.Email = register.Email;
            lb.Gender = register.Gender;
            lb.Phone = register.Phone;
            lb.ImagePath = register.ImagePath;

            lb.Users.Add(new User
            {
                UserName = register.UserName,
                Password = register.Password,
                Role = register.Role
            });

            db.Librarians.Add(lb);
            db.SaveChanges();
        }

       
    }
}
