using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SyndicPfaApp.Data;
using SyndicPfaApp.Models;

namespace SyndicPfaApp.Controllers
{
    public class AscenseursController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AscenseursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ascenseurs
        public async Task<IActionResult> Index()
        {
              return _context.Ascenseurs != null ? 
                          View(await _context.Ascenseurs.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Ascenseurs'  is null.");
        }

        // GET: Ascenseurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ascenseurs == null)
            {
                return NotFound();
            }

            var ascenseur = await _context.Ascenseurs
                .FirstOrDefaultAsync(m => m.AscenseurId == id);
            if (ascenseur == null)
            {
                return NotFound();
            }

            return View(ascenseur);
        }

        // GET: Ascenseurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ascenseurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AscenseurId,AscenseurName,Etat,DernierEntretien")] Ascenseur ascenseur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ascenseur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ascenseur);
        }

        // GET: Ascenseurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ascenseurs == null)
            {
                return NotFound();
            }

            var ascenseur = await _context.Ascenseurs.FindAsync(id);
            if (ascenseur == null)
            {
                return NotFound();
            }
            return View(ascenseur);
        }

        // POST: Ascenseurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AscenseurId,AscenseurName,Etat,DernierEntretien")] Ascenseur ascenseur)
        {
            if (id != ascenseur.AscenseurId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ascenseur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AscenseurExists(ascenseur.AscenseurId))
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
            return View(ascenseur);
        }

        // GET: Ascenseurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ascenseurs == null)
            {
                return NotFound();
            }

            var ascenseur = await _context.Ascenseurs
                .FirstOrDefaultAsync(m => m.AscenseurId == id);
            if (ascenseur == null)
            {
                return NotFound();
            }

            return View(ascenseur);
        }

        // POST: Ascenseurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ascenseurs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ascenseurs'  is null.");
            }
            var ascenseur = await _context.Ascenseurs.FindAsync(id);
            if (ascenseur != null)
            {
                _context.Ascenseurs.Remove(ascenseur);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AscenseurExists(int id)
        {
          return (_context.Ascenseurs?.Any(e => e.AscenseurId == id)).GetValueOrDefault();
        }
    }
}
