using Library_MS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Library_MS.Interfaces
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
