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
    public class PacijentController : Controller
    {
        private readonly JAWSContext _context;

        public PacijentController(JAWSContext context)
        {
            _context = context;
        }

        // GET: Pacijent
        public async Task<IActionResult> Index()
        {
            //gdje napraviti listu pacijenata
            /*Pacijent Pac = Cjenovnik.DajCjenovnik();
            cj.CjenovnikLista.Clear();
            cj.CjenovnikLista.AddRange((IEnumerable<CjenovnikItem>)await _context.CjenovnikItem.ToListAsync());
            return View(cj);*/

            return View(await _context.Pacijent.ToListAsync());
        }

        // GET: Pacijent/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacijent = await _context.Pacijent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pacijent == null)
            {
                return NotFound();
            }

            return View(pacijent);
        }

        // GET: Pacijent/Create
        public IActionResult Create()
        {
            return View();
        }
        /*private readonly JAWSContext _context;


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
      

        // GET: Cjenovnik/Create
        public IActionResult Create()
        {
            CjenovnikItem cjItem = new CjenovnikItem();

            cjItem.CjenovnikId = Cjenovnik.DajCjenovnik().Id;
            if (  cjItem.CjenovnikId < 1 ){ cjItem.CjenovnikId = 1; }
            return View();
        }
*/

        // POST: Pacijent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DatumRodjenja,BrojTelefona,Spol,Prebivaliste,JedinstveniMatičniBroj,ZdravstveneNapomene,LoyalKarticaId,Id,ImePrezime,Email,Sifra")] Pacijent pacijent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pacijent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pacijent);
        }

        // GET: Pacijent/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacijent = await _context.Pacijent.FindAsync(id);
            if (pacijent == null)
            {
                return NotFound();
            }
            return View(pacijent);
        }

        // POST: Pacijent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DatumRodjenja,BrojTelefona,Spol,Prebivaliste,JedinstveniMatičniBroj,ZdravstveneNapomene,LoyalKarticaId,Id,ImePrezime,Email,Sifra")] Pacijent pacijent)
        {
            if (id != pacijent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pacijent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacijentExists(pacijent.Id))
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
            return View(pacijent);
        }

        // GET: Pacijent/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacijent = await _context.Pacijent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pacijent == null)
            {
                return NotFound();
            }

            return View(pacijent);
        }

        // POST: Pacijent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pacijent = await _context.Pacijent.FindAsync(id);
            _context.Pacijent.Remove(pacijent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacijentExists(int id)
        {
            return _context.Pacijent.Any(e => e.Id == id);
        }
    }
}
