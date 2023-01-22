using Library_MS.DTOs;
using Library_MS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using Library_MS.Interfaces;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;

namespace Library_MS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment webEev;
        private readonly IAuth authServie;
        private readonly IExtra extraService;
        private readonly IActivityLogger loggerService;
        public HomeController(ILogger<HomeController> logger, IActivityLogger activityLogger, IWebHostEnvironment env, IAuth service, IExtra extra)
        {
            this._logger = logger;
            this.loggerService = activityLogger;
            this.webEev = env;
            this.authServie = service;
            this.extraService = extra;
        }

        public IActionResult Index()
        {            
            ViewBag.TotalBook = extraService.totalBook();
            ViewBag.TotalMember = extraService.totalmember();
            ViewBag.IssuedBook = extraService.issuedBook();
            ViewBag.DueBook = extraService.dueBook();
            return View();
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("denide")]
        public IActionResult Denied()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterLogin register)
        {
            if (ModelState.IsValid)
            {
                var rootPath = Path.Combine(webEev.WebRootPath, "images");
                var fileName = register.Image.FileName;
                var uniqueName = Guid.NewGuid().ToString() + "_" + fileName;
                var filePath = Path.Combine(rootPath, uniqueName);
                register.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                register.ImagePath = Path.Combine("/images/", uniqueName);

                authServie.Register(register);

                return RedirectToAction("Login");
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet("login")]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Validate(RegisterLogin user)
        {
            string mgs = "Please try again.";
            if (ModelState.IsValid)
            {
                var member = authServie.getUser(user.UserName);
                if (member == null)
                {
                    mgs = "Invalid Username or Password.";
                    return RedirectToAction(nameof(Login));
                }

                if (user.Password.Replace(" ","") == member.Password.Replace(" ", ""))
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, Convert.ToString(member.UserID)));
                    claims.Add(new Claim(ClaimTypes.Name, member.UserName));
                    claims.Add(new Claim(ClaimTypes.Role, member.Role));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimPrinciple = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimPrinciple);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    mgs = "Invalid Password. Try again.";
                }
                TempData["ErrorMgs"] = mgs;
                return RedirectToAction("Login", "Home");
            }
            TempData["ErrorMgs"] = mgs;
            return RedirectToAction("Login", "Home");
        }

        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var user = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            loggerService.ExceptionLogger(exceptionDetails.Path, exceptionDetails.Error.Message, 
                exceptionDetails.Error.StackTrace, user);
            return View("Error");
        }
    }
}
