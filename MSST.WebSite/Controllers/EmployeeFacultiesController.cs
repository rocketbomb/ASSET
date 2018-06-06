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
	public class EmployeeFacultiesController : Controller
	{
		private readonly ASSETContext _context;
		private readonly Utility _u;

		public EmployeeFacultiesController(ASSETContext context)
		{
			_context = context;
			_u = new Utility();
		}

		// GET: EmployeeFaculties
		public async Task<IActionResult> Index(string filterCode, string filterName, int page = 1, string sortExpression = "Name")
		{
			var item = _context.EmployeeFaculty.Where(i => i.IsDelete == 0).Include(u=>u.University).AsNoTracking();

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


			//return View(await _context.EmployeeFaculty.Include(u => u.University).ToListAsync());
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

			ViewBag.getUniversityList = getUniversityList();
			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			//List<EmployeeUniversity> UniversityList = new List<EmployeeUniversity>();
			//UniversityList = (from universities in _context.EmployeeUniversity select universities).ToList();
			//ViewBag.ListofUniversity = UniversityList;

			return View();
		}

		// POST: EmployeeFaculties/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("EmployeeFacultyId,Code,Name,UniversityId,University,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] EmployeeFaculty employeeFaculty)
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
			//List<EmployeeUniversity> UniversityList = new List<EmployeeUniversity>();
			//UniversityList = (from universities in _context.EmployeeUniversity select universities).ToList();
			//ViewBag.ListofUniversity = UniversityList;

			if (id == null)
			{
				return NotFound();
			}

			ViewBag.ListofUniversity = await _context.EmployeeUniversity.ToListAsync();

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
		public async Task<IActionResult> Edit(int id, [Bind("EmployeeFacultyId,Code,Name,UniversityId,University,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] EmployeeFaculty employeeFaculty)
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


		public List<EmployeeUniversity> getUniversityList()
		{
			List<EmployeeUniversity> u = new List<EmployeeUniversity>();
			u = _context.EmployeeUniversity.Where(i => i.IsActive == 1 && i.IsDelete == 0).ToList();

			return u;
		}




	}
}
