using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library_MS.Model_DBContext;
using Library_MS.Repository;
using Library_MS.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Library_MS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BooksController : Controller
    {
        private readonly IBook bookService;
        private readonly IWebHostEnvironment wenhostEnv;
        private readonly LibraryContext db;
        //private readonly IWebEnvironment

        public BooksController(IBook service, IWebHostEnvironment env, LibraryContext context)
        {
            this.bookService = service;
            this.wenhostEnv = env;
            this.db = context;
        }

        // GET: Books
        public ActionResult Index()
        {
            var allBooks = bookService.GetBooks();
            return View(allBooks);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            var singleBook = bookService.GetBook(id);
            //var book = bookService.GetBooks(id);
            //book = book;
            if(singleBook == null)
            {
                return NotFound();
            }
            return View(singleBook);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = bookService.getViewBagData();
            //ViewBag.CategoryID = new SelectList(db.bookCategories, "CategoryID", "Category");
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("BookID", "CategoryId", "ISBN", "BookTitle", "ImageFile", "numberOfPage", "Format", "price", "Language", "PurchaseDate", "PublishDate", "Status")] Book book, string allAuthor)
        {
            if (ModelState.IsValid)
            {
                if (book.ImageFile != null)
                {
                    string rootFolder = Path.Combine(wenhostEnv.WebRootPath, "images");
                    string fileName = book.ImageFile.FileName;
                    string uniqueName = Guid.NewGuid().ToString() + "_" + fileName;
                    string ImageFilePath = Path.Combine(rootFolder, uniqueName);
                    book.ImageFile.CopyTo(new FileStream(ImageFilePath, FileMode.Create));
                    book.ImagePath = Path.Combine("images", uniqueName);
                }
                else
                {
                    book.ImagePath = "Image Not Found.";

                }

                bookService.Create(book, allAuthor);

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
