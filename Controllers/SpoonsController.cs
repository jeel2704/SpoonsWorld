using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpoonsWorld.Data;
using SpoonsWorld.Models;

namespace SpoonsWorld.Controllers
{
    public class SpoonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpoonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Spoons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Spoon.ToListAsync());
        }

        // GET: Spoons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spoon = await _context.Spoon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spoon == null)
            {
                return NotFound();
            }

            return View(spoon);
        }

        // GET: Spoons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spoons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Material,Brand,weight,NumberOfPieces,Price")] Spoon spoon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spoon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spoon);
        }

        // GET: Spoons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spoon = await _context.Spoon.FindAsync(id);
            if (spoon == null)
            {
                return NotFound();
            }
            return View(spoon);
        }

        // POST: Spoons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Material,Brand,weight,NumberOfPieces,Price")] Spoon spoon)
        {
            if (id != spoon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spoon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpoonExists(spoon.Id))
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
            return View(spoon);
        }

        // GET: Spoons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spoon = await _context.Spoon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spoon == null)
            {
                return NotFound();
            }

            return View(spoon);
        }

        // POST: Spoons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spoon = await _context.Spoon.FindAsync(id);
            _context.Spoon.Remove(spoon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpoonExists(int id)
        {
            return _context.Spoon.Any(e => e.Id == id);
        }
    }
}
