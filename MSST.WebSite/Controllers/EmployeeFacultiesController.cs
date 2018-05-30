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
    public class EmployeeFacultiesController : Controller
    {
        private readonly ASSETContext _context;

        public EmployeeFacultiesController(ASSETContext context)
        {
            _context = context;
        }

        // GET: EmployeeFaculties
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeFaculty.ToListAsync());
        }

        // GET: EmployeeFaculties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeFaculty = await _context.EmployeeFaculty
                .SingleOrDefaultAsync(m => m.EmployeeFacultyId == id);
            if (employeeFaculty == null)
            {
                return NotFound();
            }

            return View(employeeFaculty);
        }

        // GET: EmployeeFaculties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeFaculties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeFacultyId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,EmployeeUniversityId,IsActive,IsDelete")] EmployeeFaculty employeeFaculty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeFaculty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeFaculty);
        }

        // GET: EmployeeFaculties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
			List<EmployeeUniversity> UniversityList = new List<EmployeeUniversity>();
			UniversityList = (from universities in _context.EmployeeUniversity select universities).ToList();
			ViewBag.ListofUniversity = UniversityList;

			if (id == null)
            {
                return NotFound();
            }

            var employeeFaculty = await _context.EmployeeFaculty.SingleOrDefaultAsync(m => m.EmployeeFacultyId == id);
            if (employeeFaculty == null)
            {
                return NotFound();
            }
            return View(employeeFaculty);
        }

        // POST: EmployeeFaculties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeFacultyId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] EmployeeFaculty employeeFaculty)
        {
            if (id != employeeFaculty.EmployeeFacultyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeFaculty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeFacultyExists(employeeFaculty.EmployeeFacultyId))
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
            return View(employeeFaculty);
        }

        // GET: EmployeeFaculties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeFaculty = await _context.EmployeeFaculty
                .SingleOrDefaultAsync(m => m.EmployeeFacultyId == id);
            if (employeeFaculty == null)
            {
                return NotFound();
            }

            return View(employeeFaculty);
        }

        // POST: EmployeeFaculties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeFaculty = await _context.EmployeeFaculty.SingleOrDefaultAsync(m => m.EmployeeFacultyId == id);
            _context.EmployeeFaculty.Remove(employeeFaculty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeFacultyExists(int id)
        {
            return _context.EmployeeFaculty.Any(e => e.EmployeeFacultyId == id);
        }


		
	
	}
}
