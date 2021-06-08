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
    public class StomatoloskiKartonController : Controller
    {
        private readonly JAWSContext _context;

        public StomatoloskiKartonController(JAWSContext context)
        {
            _context = context;
        }

        // GET: StomatoloskiKarton
        public async Task<IActionResult> Index()
        {
            return View(await _context.StomatoloskiKarton.ToListAsync());
        }

        // GET: StomatoloskiKarton/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stomatoloskiKarton = await _context.StomatoloskiKarton
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stomatoloskiKarton == null)
            {
                return NotFound();
            }

            return View(stomatoloskiKarton);
        }

        // GET: StomatoloskiKarton/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StomatoloskiKarton/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PacijentId,DatumOtvaranjaKartona,PosjedovanjeLoyalKartice")] StomatoloskiKarton stomatoloskiKarton)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stomatoloskiKarton);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stomatoloskiKarton);
        }

        // GET: StomatoloskiKarton/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stomatoloskiKarton = await _context.StomatoloskiKarton.FindAsync(id);
            if (stomatoloskiKarton == null)
            {
                return NotFound();
            }
            return View(stomatoloskiKarton);
        }

        // POST: StomatoloskiKarton/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PacijentId,DatumOtvaranjaKartona,PosjedovanjeLoyalKartice")] StomatoloskiKarton stomatoloskiKarton)
        {
            if (id != stomatoloskiKarton.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stomatoloskiKarton);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StomatoloskiKartonExists(stomatoloskiKarton.Id))
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
            return View(stomatoloskiKarton);
        }

        // GET: StomatoloskiKarton/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stomatoloskiKarton = await _context.StomatoloskiKarton
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stomatoloskiKarton == null)
            {
                return NotFound();
            }

            return View(stomatoloskiKarton);
        }

        // POST: StomatoloskiKarton/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stomatoloskiKarton = await _context.StomatoloskiKarton.FindAsync(id);
            _context.StomatoloskiKarton.Remove(stomatoloskiKarton);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StomatoloskiKartonExists(int id)
        {
            return _context.StomatoloskiKarton.Any(e => e.Id == id);
        }
    }
}
