﻿using Library_MS.Models;
using Library_MS.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using Library_MS.Helper;
using Microsoft.AspNetCore.Authorization;

namespace Library_MS.Controllers
{
    [Authorize(Roles = "Admin")]
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
        [HttpGet]
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
            var issueId = isu.IssueID;
            isu.returnDate = returnDate;
            isu.ReturnStaus = true;

            string dueDate = isu.dueDate;
            decimal fineAmount = FineCalculate(returnDate, dueDate);
           
            issueService.updateIssue(isu);
            issueService.AddFineData(issueId, fineAmount, returnDate);

            return RedirectToAction("Details", "Returns", new { memberCode = memberCode } );
        }

       
        public decimal FineCalculate(string returnDate, string dueDate)
        {
            DateToDay dd = new DateToDay();

            double returndate = dd.getDay(returnDate);
            double duedate = dd.getDay(dueDate);
            if (returndate > duedate)
            {
                double fineDate = returndate - duedate;
                decimal fineAmount = Convert.ToDecimal(fineDate * 0.5);
                return fineAmount;
            }
            else
            {
                return 0;
            }
        }

        [HttpPost]
        public IActionResult FinePayment(int MemberID, string date, decimal amount)
        {

            issueService.FinePayment(MemberID, date, amount);
            return Ok();
        }
    }
}
