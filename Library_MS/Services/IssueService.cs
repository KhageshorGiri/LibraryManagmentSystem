using Library_MS.Models;
using Library_MS.DTOs;
using Library_MS.Model_DBContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Library_MS.Repository;

namespace Library_MS.Services
{

    public class IssueService : IIssue
    {
        private readonly LibraryContext db;

        public IssueService(LibraryContext _context)
        {
            this.db = _context;
        }

        public Issue getIssue(int Id)
        {
            return db.Issues.Find(Id);          
        }

        public Issue getIssueBook(int BookId)
        {
            return db.Issues.Where(p=> p.ReturnStaus == false && p.Book.BookID == BookId).FirstOrDefault();
        }

        public void createIssuce(IssueVM issue)
        {
            var bookID = db.Books.Where(x => x.ISBN == issue.bookISBN);
            var memberID = db.Members.Where(x => x.MemberCode == issue.memberCode).FirstOrDefault().MemberID;
            Issue isu = new Issue();
            isu.MemberID = memberID;
            isu.BookID = bookID.FirstOrDefault().BookID;
            isu.issueDate = issue.issueDate;
            isu.dueDate = issue.dueDate;
            isu.ReturnStaus = false;
            db.Issues.Add(isu);

            bookID.FirstOrDefault().Status = "Issued";
            db.Entry(bookID).State = EntityState.Modified;

            db.SaveChanges();          
        }

        public void updateIssue(Issue issue) 
        {
            Book book = db.Books.Find(issue.BookID);
            book.Status = "Active";
            db.Entry(book).State = EntityState.Modified;

            db.Entry(issue).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Book getBook(string isbn)
        {
            var book = db.Books.Where(x => x.ISBN == isbn).Include(x => x.BookCategory).
                Include(x=>x.BookAuthors).ThenInclude(x=>x.Author).SingleOrDefault();
            return book;
        }

        public Member getMember(string code)
        {
            var member = db.Members.Where(x=>x.MemberCode.Replace(" ","") == code.Replace(" ", ""))
                .Include(x=>x.Issues.Where(x=>x.ReturnStaus == false)).ThenInclude(x=>x.Book).ThenInclude(x=>x.BookCategory)
                .FirstOrDefault();
            return member;
        }

        public void FinePayment(int member, string date, decimal amount)
        {
            FineDetails fd = new FineDetails();
            fd.MemberID = member;
            fd.PayedDate = date;
            fd.PaidAmount = amount;
            db.FineDetails.Add(fd);
            db.SaveChanges();
        }
    }
}
