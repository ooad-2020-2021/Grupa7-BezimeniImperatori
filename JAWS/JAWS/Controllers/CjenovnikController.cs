﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JAWS.Data;
using JAWS.Models;

namespace JAWS.Controllers
{
    public class CjenovnikController : Controller
    {
        private readonly JAWSContext _context;

        public CjenovnikController(JAWSContext context)
        {
            _context = context;
        }

        // GET: Cjenovnik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cjenovnik.ToListAsync());
        }

        // GET: Cjenovnik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cjenovnik = await _context.Cjenovnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cjenovnik == null)
            {
                return NotFound();
            }

            return View(cjenovnik);
        }

        // GET: Cjenovnik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cjenovnik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Cjenovnik cjenovnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cjenovnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cjenovnik);
        }

        // GET: Cjenovnik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cjenovnik = await _context.Cjenovnik.FindAsync(id);
            if (cjenovnik == null)
            {
                return NotFound();
            }
            return View(cjenovnik);
        }

        // POST: Cjenovnik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Cjenovnik cjenovnik)
        {
            if (id != cjenovnik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cjenovnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CjenovnikExists(cjenovnik.Id))
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
            return View(cjenovnik);
        }

        // GET: Cjenovnik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cjenovnik = await _context.Cjenovnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cjenovnik == null)
            {
                return NotFound();
            }

            return View(cjenovnik);
        }

        // POST: Cjenovnik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cjenovnik = await _context.Cjenovnik.FindAsync(id);
            _context.Cjenovnik.Remove(cjenovnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CjenovnikExists(int id)
        {
            return _context.Cjenovnik.Any(e => e.Id == id);
        }
    }
}
