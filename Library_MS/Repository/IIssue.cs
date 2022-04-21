using Library_MS.Models;
using Library_MS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Repository
{
    public interface IIssue
    {
        public Issue getIssue(int Id);
        public void updateIssue(Issue issue);
        public Issue getIssueBook(int BookId);
        public Member getMember(string code);
        public Book getBook(string isbn);
        public void createIssuce(IssueVM issue);
        public void FinePayment(int member, string date, decimal amount);
    }
}
