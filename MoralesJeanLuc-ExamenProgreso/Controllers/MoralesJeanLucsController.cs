using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoralesJeanLuc_ExamenProgreso.Data;
using MoralesJeanLuc_ExamenProgreso.Models;

namespace MoralesJeanLuc_ExamenProgreso.Controllers
{
    public class MoralesJeanLucsController : Controller
    {
        private readonly MoralesJeanLuc_ExamenProgresoContext _context;

        public MoralesJeanLucsController(MoralesJeanLuc_ExamenProgresoContext context)
        {
            _context = context;
        }

        // GET: MoralesJeanLucs
        public async Task<IActionResult> Index()
        {
            return View(await _context.MoralesJeanLuc.ToListAsync());
        }

        // GET: MoralesJeanLucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moralesJeanLuc = await _context.MoralesJeanLuc
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moralesJeanLuc == null)
            {
                return NotFound();
            }

            return View(moralesJeanLuc);
        }

        // GET: MoralesJeanLucs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MoralesJeanLucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sueldo,Correo,HorasExtra,FechaInicio")] MoralesJeanLuc moralesJeanLuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moralesJeanLuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moralesJeanLuc);
        }

        // GET: MoralesJeanLucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moralesJeanLuc = await _context.MoralesJeanLuc.FindAsync(id);
            if (moralesJeanLuc == null)
            {
                return NotFound();
            }
            return View(moralesJeanLuc);
        }

        // POST: MoralesJeanLucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sueldo,Correo,HorasExtra,FechaInicio")] MoralesJeanLuc moralesJeanLuc)
        {
            if (id != moralesJeanLuc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moralesJeanLuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoralesJeanLucExists(moralesJeanLuc.Id))
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
            return View(moralesJeanLuc);
        }

        // GET: MoralesJeanLucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moralesJeanLuc = await _context.MoralesJeanLuc
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moralesJeanLuc == null)
            {
                return NotFound();
            }

            return View(moralesJeanLuc);
        }

        // POST: MoralesJeanLucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moralesJeanLuc = await _context.MoralesJeanLuc.FindAsync(id);
            if (moralesJeanLuc != null)
            {
                _context.MoralesJeanLuc.Remove(moralesJeanLuc);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoralesJeanLucExists(int id)
        {
            return _context.MoralesJeanLuc.Any(e => e.Id == id);
        }
    }
}
