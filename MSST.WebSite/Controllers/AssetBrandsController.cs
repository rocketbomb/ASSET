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
    public class AssetBrandsController : Controller
    {
        private readonly ASSETContext _context;
		private readonly Utility _u;

		public AssetBrandsController(ASSETContext context)
        {
            _context = context;
			_u = new Utility();
		}

        // GET: AssetBrands
        public async Task<IActionResult> Index(string filterCode, string filterName, int page = 1, string sortExpression = "Name")
		{

			var item = _context.AssetBrand.Where(i => i.IsDelete == 0).AsNoTracking();

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

        // GET: AssetBrands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetBrand = await _context.AssetBrand
                .SingleOrDefaultAsync(m => m.AssetBrandId == id);
            if (assetBrand == null)
            {
                return NotFound();
            }

            return View(assetBrand);
        }

        // GET: AssetBrands/Create
        public IActionResult Create()
        {
			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View();
        }

        // POST: AssetBrands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssetBrandId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetBrand assetBrand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assetBrand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetBrand);
        }

        // GET: AssetBrands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetBrand = await _context.AssetBrand.SingleOrDefaultAsync(m => m.AssetBrandId == id);

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			if (assetBrand == null)
            {
                return NotFound();
            }
            return View(assetBrand);
        }

        // POST: AssetBrands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssetBrandId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetBrand assetBrand)
        {
            if (id != assetBrand.AssetBrandId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetBrand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetBrandExists(assetBrand.AssetBrandId))
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
            return View(assetBrand);
        }

        // GET: AssetBrands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetBrand = await _context.AssetBrand.SingleOrDefaultAsync(m => m.AssetBrandId == id);

            if (assetBrand == null)
            {
                return NotFound();
            }

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View(assetBrand);
        }

        // POST: AssetBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetBrand = await _context.AssetBrand.SingleOrDefaultAsync(m => m.AssetBrandId == id);
            //_context.AssetBrand.Remove(assetBrand);

			assetBrand.setDelete();

			await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetBrandExists(int id)
        {
            return _context.AssetBrand.Any(e => e.AssetBrandId == id);
        }
    }
}
