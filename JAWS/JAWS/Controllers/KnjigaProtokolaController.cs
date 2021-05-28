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
    public class KnjigaProtokolaController : Controller
    {
        private readonly JAWSContext _context;

        public KnjigaProtokolaController(JAWSContext context)
        {
            _context = context;
        }

        // GET: KnjigaProtokola
        public async Task<IActionResult> Index()
        {
            return View(await _context.KnjigaProtokola.ToListAsync());
        }

        // GET: KnjigaProtokola/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knjigaProtokola = await _context.KnjigaProtokola
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knjigaProtokola == null)
            {
                return NotFound();
            }

            return View(knjigaProtokola);
        }

        // GET: KnjigaProtokola/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KnjigaProtokola/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] KnjigaProtokola knjigaProtokola)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knjigaProtokola);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(knjigaProtokola);
        }

        // GET: KnjigaProtokola/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knjigaProtokola = await _context.KnjigaProtokola.FindAsync(id);
            if (knjigaProtokola == null)
            {
                return NotFound();
            }
            return View(knjigaProtokola);
        }

        // POST: KnjigaProtokola/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] KnjigaProtokola knjigaProtokola)
        {
            if (id != knjigaProtokola.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knjigaProtokola);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnjigaProtokolaExists(knjigaProtokola.Id))
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
            return View(knjigaProtokola);
        }

        // GET: KnjigaProtokola/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knjigaProtokola = await _context.KnjigaProtokola
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knjigaProtokola == null)
            {
                return NotFound();
            }

            return View(knjigaProtokola);
        }

        // POST: KnjigaProtokola/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var knjigaProtokola = await _context.KnjigaProtokola.FindAsync(id);
            _context.KnjigaProtokola.Remove(knjigaProtokola);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnjigaProtokolaExists(int id)
        {
            return _context.KnjigaProtokola.Any(e => e.Id == id);
        }
    }
}
