using Library_MS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Repository
{
    public interface IBook
    {
        public IEnumerable<Book> GetBooks();

        public Book GetBook(int? Id);
        //public IEnumerable<BookAuthor> GetBooks(int? Id);

        public void Create(Book book, string allAuthor);
        public void Update(Book book);
        public void Delete(Book book);

        // additional methods
        public SelectList getViewBagData();
    }
}
