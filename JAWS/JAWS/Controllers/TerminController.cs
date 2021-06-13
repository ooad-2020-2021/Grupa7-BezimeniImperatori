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
    public class TerminController : Controller
    {
        private readonly JAWSContext _context;

        public TerminController(JAWSContext context)
        {
            _context = context;
        }

        // GET: Termin
        public async Task<IActionResult> Index()
        {
            return View(await _context.Termin.ToListAsync());
        }

        // GET: Termin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termin = await _context.Termin
                .FirstOrDefaultAsync(m => m.TerminId == id);
            if (termin == null)
            {
                return NotFound();
            }

            return View(termin);
        }

        // GET: Termin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Termin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TerminId,PacijentId,VrijemeTermina,ZauzetostTermina,ObrazlozenjeTermina")] Termin termin)
        {

            if (ModelState.IsValid)
            {
                _context.Add(termin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(termin);
        }
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> TerminPacijent([Bind("TerminId,PacijentId,VrijemeTermina,ZauzetostTermina,ObrazlozenjeTermina")] Termin termin)
        {
            if (ModelState.IsValid)
            {
                var data = await _context.Termin.ToListAsync();
                foreach (var item in data)
                {
                    //if (!item.ZauzetostTermina) break; da li je potrebno
                    TimeSpan ts = termin.VrijemeTermina - item.VrijemeTermina;
                    if (ts.TotalMinutes < 0) ts = -ts;
                    if (ts.TotalMinutes < 60) return RedirectToAction(nameof(TerminPacijentGreska)); //Zauzet je, redirect na greska view
                }
                termin.ZauzetostTermina = true;
                _context.Add(termin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(termin);
        }
        //Get view Error - Pacijent
        public IActionResult TerminPacijentGreska()
        {
            return View();
        }

        // GET: Termin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termin = await _context.Termin.FindAsync(id);
            if (termin == null)
            {
                return NotFound();
            }
            return View(termin);
        }

        // POST: Termin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TerminId,PacijentId,VrijemeTermina,ZauzetostTermina,ObrazlozenjeTermina")] Termin termin)
        {
            if (id != termin.TerminId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(termin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TerminExists(termin.TerminId))
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
            return View(termin);
        }

        // GET: Termin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termin = await _context.Termin
                .FirstOrDefaultAsync(m => m.TerminId == id);
            if (termin == null)
            {
                return NotFound();
            }

            return View(termin);
        }

        // POST: Termin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var termin = await _context.Termin.FindAsync(id);
            _context.Termin.Remove(termin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TerminExists(int id)
        {
            return _context.Termin.Any(e => e.TerminId == id);
        }
    }
}
