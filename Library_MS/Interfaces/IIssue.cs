using Library_MS.Models;
using Library_MS.DTOs;

namespace Library_MS.Interfaces
{
    public interface IIssue
    {
        public Issue getIssue(int Id);
        public void updateIssue(Issue issue);
        public Issue getIssueBook(int BookId);
        public Member getMember(string code);
        public Book getBook(string isbn);
        public void createIssuce(IssueVM issue);
        public void AddFineData(int issuedId, decimal? fineAmount, string fineDate);
        public void FinePayment(int member, string date, decimal amount);
    }
}
