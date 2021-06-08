using System;
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
    public class LoyalKarticaController : Controller
    {
        private readonly JAWSContext _context;

        public LoyalKarticaController(JAWSContext context)
        {
            _context = context;
        }

        // GET: LoyalKartica
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoyalKartica.ToListAsync());
        }

        // GET: LoyalKartica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loyalKartica = await _context.LoyalKartica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loyalKartica == null)
            {
                return NotFound();
            }

            return View(loyalKartica);
        }

        // GET: LoyalKartica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoyalKartica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DatumKreiranja")] LoyalKartica loyalKartica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loyalKartica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loyalKartica);
        }

        // GET: LoyalKartica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loyalKartica = await _context.LoyalKartica.FindAsync(id);
            if (loyalKartica == null)
            {
                return NotFound();
            }
            return View(loyalKartica);
        }

        // POST: LoyalKartica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DatumKreiranja")] LoyalKartica loyalKartica)
        {
            if (id != loyalKartica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loyalKartica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoyalKarticaExists(loyalKartica.Id))
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
            return View(loyalKartica);
        }

        // GET: LoyalKartica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loyalKartica = await _context.LoyalKartica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loyalKartica == null)
            {
                return NotFound();
            }

            return View(loyalKartica);
        }

        // POST: LoyalKartica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loyalKartica = await _context.LoyalKartica.FindAsync(id);
            _context.LoyalKartica.Remove(loyalKartica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoyalKarticaExists(int id)
        {
            return _context.LoyalKartica.Any(e => e.Id == id);
        }
    }
}
