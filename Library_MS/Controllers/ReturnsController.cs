using Library_MS.Models;
using Library_MS.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Controllers
{
    public class ReturnsController : Controller
    {
        private readonly IIssue issueService;
        public ReturnsController(IIssue service)
        {
            this.issueService = service;
        }
        // GET: Returns
        public ActionResult Index()
        {
            return View();
        }

        // GET: Returns/Details/5
        [HttpPost]
        public ActionResult Details(string memberCode)
        {
            if (memberCode == null)
            {
                return NotFound();
            }
            var member = issueService.getMember(memberCode);
            return View(member);
        }

        // GET: Returns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Returns/Create
        [HttpPost]
        public ActionResult Create(string memberCode, int bookId,string returnDate)
        {
            Issue isu = issueService.getIssueBook(bookId);
            isu.returnDate = returnDate;
            isu.ReturnStaus = true;
            issueService.updateIssue(isu);
            return RedirectToAction("Details", "Returns", new { id = memberCode });
        }

       
    }
}
