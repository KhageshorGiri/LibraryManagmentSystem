using Library_MS.Models;
using Library_MS.Model_DBContext;
using Library_MS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Library_MS.Services
{
    public class BookService : IBook
    {
        private readonly LibraryContext db;

        public BookService(LibraryContext context)
        {
            this.db = context;
        }
        public void Create(Book book, string allAuthor)
        {
            db.Books.Add(book);
            db.SaveChanges();

            BookAuthor ba = new BookAuthor();
            
            var autherNames = allAuthor.Split("#");
            foreach(var name in autherNames)
            {              
                if (name != "")
                {
                    Author auth = new Author();
                    auth.Name = name;
                    auth.BookAuthors.Add(new BookAuthor() { 
                        BookId = book.BookID,
                    });
                    db.Authors.Add(auth);
                    db.SaveChanges();
                }
               
            }
           
        }

        public void Delete(Book book)
        {
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public IEnumerable<Book> GetBooks()
        {
            return db.Books.Include(p => p.BookCategory).ToList();
        }

        public Book GetBook(int? Id)
        {
            Book book = db.Books.Include(p => p.BookCategory).Include(p => p.BookAuthors).ThenInclude(x => x.Author).SingleOrDefault(p => p.BookID == Id);
            return book;
        }

       
        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();
        }

        // additional service functions
        public SelectList getViewBagData()
        {
            return new SelectList(db.bookCategories, "CategoryID", "Category");
        }

        
    }
}
