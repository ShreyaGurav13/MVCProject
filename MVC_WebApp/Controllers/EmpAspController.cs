using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_WebApp;
using MVC_WebApp.Models;

namespace MVC_WebApp.Controllers
{
    public class EmpAspController : Controller
    {
        private readonly strtsqlContext _context;

        public EmpAspController(strtsqlContext context)
        {
            _context = context;
        }

        // GET: EmpAsp
        public async Task<IActionResult> Index()
        {
              return _context.employeeasp != null ? 
                          View(await _context.employeeasp.ToListAsync()) :
                          Problem("Entity set 'strtsqlContext.employeeasp'  is null.");
        }

        // GET: EmpAsp/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.employeeasp == null)
            {
                return NotFound();
            }

            var employeeasp = await _context.employeeasp
                .FirstOrDefaultAsync(m => m.Eid == id);
            if (employeeasp == null)
            {
                return NotFound();
            }

            return View(employeeasp);
        }

        // GET: EmpAsp/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmpAsp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eid,Name,Designation,Gross,Deduction,Netsal,Isactive")] Employeeasp employeeasp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeasp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeasp);
        }

        // GET: EmpAsp/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.employeeasp == null)
            {
                return NotFound();
            }

            var employeeasp = await _context.employeeasp.FindAsync(id);
            if (employeeasp == null)
            {
                return NotFound();
            }
            return View(employeeasp);
        }

        // POST: EmpAsp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Eid,Name,Designation,Gross,Deduction,Netsal,Isactive")] Employeeasp employeeasp)
        {
            if (id != employeeasp.Eid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeasp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeaspExists(employeeasp.Eid))
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
            return View(employeeasp);
        }

        // GET: EmpAsp/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.employeeasp == null)
            {
                return NotFound();
            }

            var employeeasp = await _context.employeeasp
                .FirstOrDefaultAsync(m => m.Eid == id);
            if (employeeasp == null)
            {
                return NotFound();
            }

            return View(employeeasp);
        }

        // POST: EmpAsp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.employeeasp == null)
            {
                return Problem("Entity set 'strtsqlContext.employeeasp'  is null.");
            }
            var employeeasp = await _context.employeeasp.FindAsync(id);
            if (employeeasp != null)
            {
                _context.employeeasp.Remove(employeeasp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeaspExists(int id)
        {
          return (_context.employeeasp?.Any(e => e.Eid == id)).GetValueOrDefault();
        }

        public IActionResult Department()
        {
            return View();
        }
    }
}
