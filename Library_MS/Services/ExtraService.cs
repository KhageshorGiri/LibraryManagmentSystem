using Library_MS.Repository;
using System;
using Library_MS.Model_DBContext;
using System.Linq;
using Library_MS.Helper;
using System.Collections.Generic;
using Library_MS.Models;

namespace Library_MS.Services
{
    public class ExtraService : IExtra
    {
        private readonly LibraryContext db;
        public ExtraService(LibraryContext context)
        {
            this.db = context;
        }

        public string dueBook()
        {
            List<Issue> issue = new List<Issue>();

            DateToDay dd = new DateToDay();

            DateTime date = DateTime.Now.Date;
            var  today = date.ToString("yyyy/mm/dd");
            today = today.Replace("/", "-");
            var date_value = dd.getDay(today);

            IEnumerable<Issue> db_value= db.Issues.ToList();

            
            foreach(var item in db_value)
            {
                var due_date = dd.getDay(item.dueDate);
                if(date_value > due_date)
                {
                    issue.Add(item);
                }
            }


            return issue.Count().ToString();
        }

        public string issuedBook()
        {
            var issued_book = db.Issues.Where(q => q.ReturnStaus == false).Count();
            return issued_book.ToString();
        }

        public string totalBook()
        {
            var book_count = db.Books.Count();
            return book_count.ToString();
        }

        public string totalmember()
        {
            var member_count = db.Members.Count();
            return member_count.ToString();
        }
    }
}
