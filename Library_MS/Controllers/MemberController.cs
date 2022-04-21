using Library_MS.Models;
using Library_MS.Model_DBContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Library_MS.Repository;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Library_MS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MemberController : Controller
    {
        private readonly IWebHostEnvironment webHostEnv;
        private readonly IMember memberService;
        private LibraryContext db ;
        public MemberController(IWebHostEnvironment env, IMember service, LibraryContext context)
        {
            this.webHostEnv = env;
            this.memberService = service;
            this.db = context;
        }

        // GET: MemberController
        public ActionResult Index()
        {
            var members = memberService.GetAllMembers();
            return View(members);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            var member = memberService.GetMembers(id);
            return View(member);
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("MemberID", "FullName", "Gender", "Phone", "Email", "ImageFile", "MembershipDate")] Member member, [Bind("AddressID", "Country", "City", "AdditionalInfo")] Address address)
        {

                string clzCode = "17";
                string facultyCode = "35";

                if (member.ImageFile != null)
                {
                    string rootFolder = Path.Combine(webHostEnv.WebRootPath, "images");
                    string fileName = member.ImageFile.FileName;
                    string uniqueName = Guid.NewGuid().ToString() + '_' + fileName;
                    string imageFile = Path.Combine(rootFolder, uniqueName);
                    member.ImageFile.CopyTo(new FileStream(imageFile, FileMode.Create));
                    member.ImagePath = Path.Combine("/images/", uniqueName);
                }
                else
                {
                    member.ImagePath = "No Image";
                }
               

                member.MemberCode = clzCode + facultyCode + Convert.ToString(member.MemberID);
                member.Status = "Active";

                memberService.CreateMember(member, address);

                return RedirectToAction(nameof(Index));
          
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var memberDetail = memberService.GetMembers((int)id);
            if(memberDetail == null)
            {
                return NotFound();
            }
            return View(memberDetail);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            var memberValue = memberService.GetMembers(id);
            if(memberValue == null)
            {
                return NotFound();
            }

            memberValue.FullName = member.FullName;
            memberValue.Gender = member.Gender;
            memberValue.Phone = member.Phone;
            //memberValue.ImagePath = member.ImagePath;
           // memberValue.MemberCode = member.MemberCode;
            memberValue.MembershipDate = member.MembershipDate;
            memberValue.Status = member.Status;
            
            memberService.UpdateMember(memberValue);

            return RedirectToAction(nameof(Index));
        }

        
        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            var memberValue = memberService.GetMembers(id);
            if(memberValue == null)
            {
                return NotFound();
            }

            memberService.DeleteMember(memberValue);

            return RedirectToAction(nameof(Index));
        }

       
    }
}
