using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASSET.Data;
using ASSET.Models.Master;

namespace ASSET.WebSite.Controllers
{
    public class EmployeeMajorsController : Controller
    {
        private readonly ASSETContext _context;

        public EmployeeMajorsController(ASSETContext context)
        {
            _context = context;
        }

        // GET: EmployeeMajors
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeMajor.ToListAsync());
        }

        // GET: EmployeeMajors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeMajor = await _context.EmployeeMajor
                .SingleOrDefaultAsync(m => m.EmployeeMajorId == id);
            if (employeeMajor == null)
            {
                return NotFound();
            }

            return View(employeeMajor);
        }

        // GET: EmployeeMajors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeMajors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeMajorId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] EmployeeMajor employeeMajor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeMajor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeMajor);
        }

        // GET: EmployeeMajors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeMajor = await _context.EmployeeMajor.SingleOrDefaultAsync(m => m.EmployeeMajorId == id);
            if (employeeMajor == null)
            {
                return NotFound();
            }
            return View(employeeMajor);
        }

        // POST: EmployeeMajors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeMajorId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] EmployeeMajor employeeMajor)
        {
            if (id != employeeMajor.EmployeeMajorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeMajor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeMajorExists(employeeMajor.EmployeeMajorId))
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
            return View(employeeMajor);
        }

        // GET: EmployeeMajors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeMajor = await _context.EmployeeMajor
                .SingleOrDefaultAsync(m => m.EmployeeMajorId == id);
            if (employeeMajor == null)
            {
                return NotFound();
            }

            return View(employeeMajor);
        }

        // POST: EmployeeMajors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeMajor = await _context.EmployeeMajor.SingleOrDefaultAsync(m => m.EmployeeMajorId == id);
            _context.EmployeeMajor.Remove(employeeMajor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeMajorExists(int id)
        {
            return _context.EmployeeMajor.Any(e => e.EmployeeMajorId == id);
        }
    }
}
