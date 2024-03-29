﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library_MS.Model_DBContext;
using Library_MS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using System;

namespace Library_MS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BookCategoriesController : Controller
    {
        private readonly ILogger<BookCategoriesController> _logger;
        private readonly LibraryContext _context;
        
        public BookCategoriesController(ILogger<BookCategoriesController> logger, LibraryContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: BookCategories
        
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation($"Accessing Book Category Index");
            return View(await _context.bookCategories.ToListAsync());
        }

        
        // POST: BookCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryID,Category")] BookCategory bookCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index");
        }

        // GET: BookCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookCategory = await _context.bookCategories.FindAsync(id);
            if (bookCategory == null)
            {
                return NotFound();
            }
            return View(bookCategory);
        }

        // POST: BookCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,Category")] BookCategory bookCategory)
        {
            if (id != bookCategory.CategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookCategoryExists(bookCategory.CategoryID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bookCategory);
        }

        // Get: BookCategories/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var bookCategory = await _context.bookCategories.FindAsync(id);
            _context.bookCategories.Remove(bookCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookCategoryExists(int id)
        {
            return _context.bookCategories.Any(e => e.CategoryID == id);
        }
    }
}
