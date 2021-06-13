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
            Cjenovnik cj = Cjenovnik.DajCjenovnik();
            cj.CjenovnikLista.Clear();
            cj.CjenovnikLista.AddRange((IEnumerable<CjenovnikItem>)await _context.CjenovnikItem.ToListAsync());

            return View(cj);
        }
        //GET: Cjenovnik za pacijenta
        public async Task<IActionResult> CjenovnikPacijent()
        {
            Cjenovnik cj = Cjenovnik.DajCjenovnik();
            cj.CjenovnikLista.Clear();
            cj.CjenovnikLista.AddRange((IEnumerable<CjenovnikItem>)await _context.CjenovnikItem.ToListAsync());
            return View(cj);
        }


        // GET: Cjenovnik/Create
        public IActionResult Create()
        {
            CjenovnikItem cjItem = new CjenovnikItem();

            cjItem.CjenovnikId = Cjenovnik.DajCjenovnik().Id;
            if (  cjItem.CjenovnikId < 1 ){ cjItem.CjenovnikId = 1; }
            return View();
        }

        // POST: Cjenovnik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CjenovnikItem cjItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cjItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cjItem);
        }

        // GET: Cjenovnik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cjenovnikItem = await _context.CjenovnikItem.FindAsync(id);
            if (cjenovnikItem == null)
            {
                return NotFound();
            }
            return View(cjenovnikItem);
        }

        // POST: Cjenovnik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CjenovnikItem cjenovnikItem)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cjenovnikItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CjenovnikExists(cjenovnikItem.Id))
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
            return View(cjenovnikItem);
        }

        // GET: Cjenovnik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CjenovnikItem cj = new CjenovnikItem();
            cj = await _context.CjenovnikItem.FirstAsync(x =>  x.Id == id);
            
            if (cj == null)
            {
                return NotFound();
            }

            return View(cj);
        }

        // POST: Cjenovnik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(CjenovnikItem cj)
        {
            _context.CjenovnikItem.Remove(cj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CjenovnikExists(int id)
        {
            return _context.Cjenovnik.Any(e => e.Id == id);
        }
    }
}
