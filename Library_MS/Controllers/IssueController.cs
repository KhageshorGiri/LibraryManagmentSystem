using Library_MS.DTOs;
using Library_MS.Models;
using Library_MS.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Library_MS.Controllers
{
    public class IssueController : Controller
    {
        // GET: Issue
        private readonly IIssue issueService;
        public IssueController(IIssue service)
        {
            this.issueService = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Issue/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Issue/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Issue/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind("bookISBN", "memberCode", "issueDate", "dueDate")] IssueVM issue)
        {
            if (ModelState.IsValid)
            {
                issueService.createIssuce(issue);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Issue/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Issue/Edit/5
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

        // GET: Issue/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Issue/Delete/5
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

        //httpGet: /getMember
        public ActionResult getMember(string uniqueCode)
        {
            Member member = issueService.getMember(uniqueCode);
            if(member == null)
            {
                return Ok("We cannot find this member.");
            }

            int count = 0;
            foreach(var book in member.Issues)
            {
                if(book.MemberID == member.MemberID)
                {
                    count += 1;
                }
            }
      
            var memberType = new IssueVM()
            {
                MemberName= member.FullName,
                MemberImage = member.ImagePath,
                MembershipDate = member.MembershipDate,
                bookCount = count
            };

            List<IssueVM> jsonMemeber = new List<IssueVM>();
            jsonMemeber.Add(memberType);

            var json = JsonSerializer.Serialize(jsonMemeber, new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return Ok(json);
        }

        public ActionResult getBook(string ISBN)
        {
            Book book = issueService.getBook(ISBN);

            string author_value = "";
            foreach (var author in book.BookAuthors)
            {
                author_value += author.Author.Name + " ";
            }

            var issueBook = new IssueVM()
             {
                 BookTitle = book.BookTitle,
                 BookImge = book.ImagePath,
                 Category = book.BookCategory.Category,
                 Language = book.Language,
                 Format = book.Format,
                 Status = book.Status,
                 Authors = author_value,
               
             };
            List<IssueVM> issueBookList = new List<IssueVM>();
            issueBookList.Add(issueBook);

            var json = JsonSerializer.Serialize(issueBookList, new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return Ok(json);
        }

    }
}
