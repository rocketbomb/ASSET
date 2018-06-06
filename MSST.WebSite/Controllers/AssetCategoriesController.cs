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
	public class AssetCategoriesController : Controller
	{
		private readonly ASSETContext _context;
		private readonly Utility _u;

		public AssetCategoriesController(ASSETContext context)
		{
			_context = context;
			_u = new Utility();
		}

		// GET: AssetCategories
		public async Task<IActionResult> Index(string filterCode, string filterName, int page = 1, string sortExpression = "Name")
		{


			var item = _context.AssetCategory.Where(i => i.IsDelete == 0).AsNoTracking();

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
		}

		// GET: AssetCategories/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var assetCategory = await _context.AssetCategory
				.SingleOrDefaultAsync(m => m.AssetCategoryId == id);
			if (assetCategory == null)
			{
				return NotFound();
			}

			return View(assetCategory);
		}

		// GET: AssetCategories/Create
		public IActionResult Create()
		{
			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View();
		}

		// POST: AssetCategories/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("AssetCategoryId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetCategory assetCategory)
		{
			if (ModelState.IsValid)
			{
				_context.Add(assetCategory);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(assetCategory);
		}

		// GET: AssetCategories/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var assetCategory = await _context.AssetCategory.SingleOrDefaultAsync(m => m.AssetCategoryId == id);

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			if (assetCategory == null)
			{
				return NotFound();
			}
			return View(assetCategory);
		}

		// POST: AssetCategories/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("AssetCategoryId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetCategory assetCategory)
		{
			if (id != assetCategory.AssetCategoryId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(assetCategory);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!AssetCategoryExists(assetCategory.AssetCategoryId))
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
			return View(assetCategory);
		}

		// GET: AssetCategories/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var assetCategory = await _context.AssetCategory.SingleOrDefaultAsync(m => m.AssetCategoryId == id);

			if (assetCategory == null)
			{
				return NotFound();
			}

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View(assetCategory);
		}

		// POST: AssetCategories/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var assetCategory = await _context.AssetCategory.SingleOrDefaultAsync(m => m.AssetCategoryId == id);
			//_context.AssetCategory.Remove(assetCategory);

			assetCategory.setDelete();

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool AssetCategoryExists(int id)
		{
			return _context.AssetCategory.Any(e => e.AssetCategoryId == id);
		}
	}
}
