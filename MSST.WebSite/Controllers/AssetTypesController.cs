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
    public class AssetTypesController : Controller
    {
        private readonly ASSETContext _context;
		private readonly Utility _u;

		public AssetTypesController(ASSETContext context)
        {
            _context = context;
			_u = new Utility();
		}

        // GET: AssetTypes
        public async Task<IActionResult> Index(string filterCode, string filterName, int page=1, string sortExpression = "Name")
        {
			var item = _context.AssetType.Where(i => i.IsDelete == 0).AsNoTracking();

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
            //return View(await _context.AssetType.Where(i => i.IsDelete == 0).ToListAsync());
        }

        // GET: AssetTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetType = await _context.AssetType
                .SingleOrDefaultAsync(m => m.AssetTypeId == id);
            if (assetType == null)
            {
                return NotFound();
            }

            return View(assetType);
        }

        // GET: AssetTypes/Create
        public IActionResult Create()
        {
			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View();
        }

        // POST: AssetTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssetTypeId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetType assetType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assetType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetType);
        }

        // GET: AssetTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetType = await _context.AssetType.SingleOrDefaultAsync(m => m.AssetTypeId == id);

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			if (assetType == null)
            {
                return NotFound();
            }
            return View(assetType);
        }

        // POST: AssetTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssetTypeId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetType assetType)
        {
            if (id != assetType.AssetTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetTypeExists(assetType.AssetTypeId))
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
            return View(assetType);
        }

        // GET: AssetTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetType = await _context.AssetType
                .SingleOrDefaultAsync(m => m.AssetTypeId == id);
            if (assetType == null)
            {
                return NotFound();
            }

            return View(assetType);
        }

        // POST: AssetTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetType = await _context.AssetType.SingleOrDefaultAsync(m => m.AssetTypeId == id);
			//_context.AssetType.Remove(assetType);

			assetType.setDelete();

			await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetTypeExists(int id)
        {
            return _context.AssetType.Where(i => i.IsDelete == 0).Any(e => e.AssetTypeId == id);
        }
    }
}
