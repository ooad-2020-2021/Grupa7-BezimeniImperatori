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
    //provjeravac RTG snimka implementirati
    public class StomatoloskaUslugaController : Controller
    {
        private readonly JAWSContext _context;

        public StomatoloskaUslugaController(JAWSContext context)
        {
            _context = context;
        }

        // GET: StomatoloskaUsluga
        public async Task<IActionResult> Index()
        {
            return View(await _context.StomatoloskaUsluga.ToListAsync());
        }

        // GET: StomatoloskaUsluga/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stomatoloskaUsluga = await _context.StomatoloskaUsluga
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stomatoloskaUsluga == null)
            {
                return NotFound();
            }

            return View(stomatoloskaUsluga);
        }

        // GET: StomatoloskaUsluga/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StomatoloskaUsluga/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,datumPruzanjaUsluga,oboljenje,rtgSnimak,napomene,opisUsluge,izvjestajTerapije")] StomatoloskaUsluga stomatoloskaUsluga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stomatoloskaUsluga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stomatoloskaUsluga);
        }

        // GET: StomatoloskaUsluga/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stomatoloskaUsluga = await _context.StomatoloskaUsluga.FindAsync(id);
            if (stomatoloskaUsluga == null)
            {
                return NotFound();
            }
            return View(stomatoloskaUsluga);
        }

        // POST: StomatoloskaUsluga/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,datumPruzanjaUsluga,oboljenje,rtgSnimak,napomene,opisUsluge,izvjestajTerapije")] StomatoloskaUsluga stomatoloskaUsluga)
        {
            if (id != stomatoloskaUsluga.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stomatoloskaUsluga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StomatoloskaUslugaExists(stomatoloskaUsluga.Id))
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
            return View(stomatoloskaUsluga);
        }

        // GET: StomatoloskaUsluga/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stomatoloskaUsluga = await _context.StomatoloskaUsluga
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stomatoloskaUsluga == null)
            {
                return NotFound();
            }

            return View(stomatoloskaUsluga);
        }

        // POST: StomatoloskaUsluga/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stomatoloskaUsluga = await _context.StomatoloskaUsluga.FindAsync(id);
            _context.StomatoloskaUsluga.Remove(stomatoloskaUsluga);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StomatoloskaUslugaExists(int id)
        {
            return _context.StomatoloskaUsluga.Any(e => e.Id == id);
        }
    }
}
