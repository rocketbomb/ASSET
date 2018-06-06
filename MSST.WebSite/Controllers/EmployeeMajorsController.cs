using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASSET.Data;
using ASSET.Models.Master;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;
using ASSET.Common;

namespace ASSET.WebSite.Controllers
{
    public class EmployeeMajorsController : Controller
    {
        private readonly ASSETContext _context;
		private readonly Utility _u;

		public EmployeeMajorsController(ASSETContext context)
        {
			_context = context;
			_u = new Utility();
		}

        // GET: EmployeeMajors
        public async Task<IActionResult> Index(string filterCode, string filterName, int page = 1, string sortExpression = "Name")
		{
			var item = _context.EmployeeMajor.Where(i => i.IsDelete == 0).AsNoTracking();

			if (!string.IsNullOrWhiteSpace(filterCode))
			{
				item = item.Where(p => p.Code.Contains(filterCode));
			}

			if (!string.IsNullOrWhiteSpace(filterName))
			{
				item = item.Where(p => p.Name.Contains(filterName));
			}

			var model = await PagingList.CreateAsync(item, 10, page, sortExpression, "Name");

			model.RouteValue = new RouteValueDictionary {
															{ "filterCode", filterCode},
															{ "filterName", filterName}
														};

			return View(model);

			//return View(await _context.EmployeeMajor.ToListAsync());
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
			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

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

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

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
			//_context.EmployeeMajor.Remove(employeeMajor);

			employeeMajor.setDelete();

			await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeMajorExists(int id)
        {
            return _context.EmployeeMajor.Where(i => i.IsDelete == 0).Any(e => e.EmployeeMajorId == id);
        }
    }
}
