using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EstebanNarvaez_MVC2.Models;

namespace EstebanNarvaez_MVC2.Controllers
{
    public class EstudianteUDLAsController : Controller
    {
        private readonly EstudiantesContext _context;

        public EstudianteUDLAsController(EstudiantesContext context)
        {
            _context = context;
        }

        // GET: EstudianteUDLAs
        public async Task<IActionResult> Index()
        {
            var estudiantesContext = _context.EstudianteUDLA.Include(e => e.Carrera);
            return View(await estudiantesContext.ToListAsync());
        }

        // GET: EstudianteUDLAs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudianteUDLA = await _context.EstudianteUDLA
                .Include(e => e.Carrera)
                .FirstOrDefaultAsync(m => m.IdBanner == id);
            if (estudianteUDLA == null)
            {
                return NotFound();
            }

            return View(estudianteUDLA);
        }

        // GET: EstudianteUDLAs/Create
        public IActionResult Create()
        {
            ViewData["IdCarrera"] = new SelectList(_context.Set<Carrera>(), "Id", "Nombre");
            return View();
        }

        // POST: EstudianteUDLAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBanner,Nombre,FechaNacimiento,Correo,TieneBeca,IdCarrera")] EstudianteUDLA estudianteUDLA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudianteUDLA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCarrera"] = new SelectList(_context.Set<Carrera>(), "Id", "Nombre", estudianteUDLA.IdCarrera);
            return View(estudianteUDLA);
        }

        // GET: EstudianteUDLAs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudianteUDLA = await _context.EstudianteUDLA.FindAsync(id);
            if (estudianteUDLA == null)
            {
                return NotFound();
            }
            ViewData["IdCarrera"] = new SelectList(_context.Set<Carrera>(), "Id", "Nombre", estudianteUDLA.IdCarrera);
            return View(estudianteUDLA);
        }

        // POST: EstudianteUDLAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdBanner,Nombre,FechaNacimiento,Correo,TieneBeca,IdCarrera")] EstudianteUDLA estudianteUDLA)
        {
            if (id != estudianteUDLA.IdBanner)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudianteUDLA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudianteUDLAExists(estudianteUDLA.IdBanner))
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
            ViewData["IdCarrera"] = new SelectList(_context.Set<Carrera>(), "Id", "Nombre", estudianteUDLA.IdCarrera);
            return View(estudianteUDLA);
        }

        // GET: EstudianteUDLAs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudianteUDLA = await _context.EstudianteUDLA
                .Include(e => e.Carrera)
                .FirstOrDefaultAsync(m => m.IdBanner == id);
            if (estudianteUDLA == null)
            {
                return NotFound();
            }

            return View(estudianteUDLA);
        }

        // POST: EstudianteUDLAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var estudianteUDLA = await _context.EstudianteUDLA.FindAsync(id);
            if (estudianteUDLA != null)
            {
                _context.EstudianteUDLA.Remove(estudianteUDLA);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudianteUDLAExists(string id)
        {
            return _context.EstudianteUDLA.Any(e => e.IdBanner == id);
        }
    }
}
