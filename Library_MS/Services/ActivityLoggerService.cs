using Library_MS.Interfaces;
using Library_MS.Model_DBContext;
using Library_MS.Models;
using System;


namespace Library_MS.Services
{
    public class ActivityLoggerService : IActivityLogger
    {
        private readonly LibraryContext db;
        public ActivityLoggerService(LibraryContext _context)
        {
            this.db = _context;
        }

        public void UserActivityLogger()
        {
            throw new NotImplementedException();
        }

        public void ExceptionLogger(string path, string message, string stackTrace, string user)
        {
            ExceptionLog exception = new ExceptionLog();
            exception.Path = path;
            exception.ExceptionMessage = message;
            exception.StackTrace = stackTrace;
            exception.CreatedBy = Convert.ToInt32(user);
            db.ExceptionLogs.Add(exception);
            db.SaveChanges();
        }
    }
}
