using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASSET.Data;
using ASSET.Models.Master;
using ASSET.Common;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;

namespace ASSET.WebSite.Controllers
{
    public class EmployeeUniversitiesController : Controller
    {
        private readonly ASSETContext _context;
		private readonly Utility _u;

		public EmployeeUniversitiesController(ASSETContext context)
        {
			_context = context;
			_u = new Utility();
		}

        // GET: EmployeeUniversities
        public async Task<IActionResult> Index(string filterCode, string filterNameEng, string filterNameThai, int page = 1, string sortExpression = "NameEng")
        {
			var item = _context.EmployeeUniversity.Where(i => i.IsDelete == 0).AsNoTracking();

			if (!string.IsNullOrWhiteSpace(filterCode))
			{
				item = item.Where(p => p.Code.Contains(filterCode));
			}

			if (!string.IsNullOrWhiteSpace(filterNameEng))
			{
				item = item.Where(p => p.NameEng.Contains(filterNameEng));
			}

			if (!string.IsNullOrWhiteSpace(filterNameThai))
			{
				item = item.Where(p => p.NameThai.Contains(filterNameThai));
			}

			var model = await PagingList.CreateAsync(item, 10, page, sortExpression, "NameEng");

			model.RouteValue = new RouteValueDictionary {
															{ "filterCode", filterCode},
															{ "filterNameEng", filterNameEng},
															{ "filterNameThai", filterNameThai}
														};

			return View(model);

			// return View(await _context.EmployeeUniversity.ToListAsync());
		}

        // GET: EmployeeUniversities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeUniversity = await _context.EmployeeUniversity
                .SingleOrDefaultAsync(m => m.EmployeeUniversityId == id);
            if (employeeUniversity == null)
            {
                return NotFound();
            }

            return View(employeeUniversity);
        }

        // GET: EmployeeUniversities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeUniversities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeUniversityId,Code,NameThai,NameEng,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] EmployeeUniversity employeeUniversity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeUniversity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeUniversity);
        }

        // GET: EmployeeUniversities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

			if (id == null)
            {
                return NotFound();
            }

            var employeeUniversity = await _context.EmployeeUniversity.SingleOrDefaultAsync(m => m.EmployeeUniversityId == id);

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();


			if (employeeUniversity == null)
            {
                return NotFound();
            }
            return View(employeeUniversity);
        }

        // POST: EmployeeUniversities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeUniversityId,Code,NameThai,NameEng,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] EmployeeUniversity employeeUniversity)
        {
            if (id != employeeUniversity.EmployeeUniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeUniversity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeUniversityExists(employeeUniversity.EmployeeUniversityId))
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
            return View(employeeUniversity);
        }

        // GET: EmployeeUniversities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeUniversity = await _context.EmployeeUniversity
                .SingleOrDefaultAsync(m => m.EmployeeUniversityId == id);
            if (employeeUniversity == null)
            {
                return NotFound();
            }

            return View(employeeUniversity);
        }

        // POST: EmployeeUniversities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeUniversity = await _context.EmployeeUniversity.SingleOrDefaultAsync(m => m.EmployeeUniversityId == id);
			//_context.EmployeeUniversity.Remove(employeeUniversity);

			employeeUniversity.setDelete();

			await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeUniversityExists(int id)
        {
            return _context.EmployeeUniversity.Where(i=>i.IsDelete == 0).Any(e => e.EmployeeUniversityId == id);
        }
    }
}
