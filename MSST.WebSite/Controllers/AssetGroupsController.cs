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
    public class AssetGroupsController : Controller
    {
        private readonly ASSETContext _context;
		private readonly Utility _u;

		public AssetGroupsController(ASSETContext context)
        {
            _context = context;
			_u = new Utility();
		}

        // GET: AssetGroups
        public async Task<IActionResult> Index(string filterCode, string filterName, int page = 1, string sortExpression = "Name")
        {
			var item = _context.AssetGroup.Where(i => i.IsDelete == 0).AsNoTracking();

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

        // GET: AssetGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetGroup = await _context.AssetGroup
                .SingleOrDefaultAsync(m => m.AssetGroupId == id);
            if (assetGroup == null)
            {
                return NotFound();
            }

            return View(assetGroup);
        }

        // GET: AssetGroups/Create
        public IActionResult Create()
        {
			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View();
        }

        // POST: AssetGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssetGroupId,Code,Name,AssetId,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetGroup assetGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assetGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetGroup);
        }

        // GET: AssetGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetGroup = await _context.AssetGroup.SingleOrDefaultAsync(m => m.AssetGroupId == id);

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			if (assetGroup == null)
            {
                return NotFound();
            }


			return View(assetGroup);
        }

        // POST: AssetGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssetGroupId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetGroup assetGroup)
        {
            if (id != assetGroup.AssetGroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetGroupExists(assetGroup.AssetGroupId))
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


			return View(assetGroup);
        }

        // GET: AssetGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetGroup = await _context.AssetGroup.SingleOrDefaultAsync(m => m.AssetGroupId == id);

			if (assetGroup == null)
            {
                return NotFound();
            }

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View(assetGroup);
        }

        // POST: AssetGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetGroup = await _context.AssetGroup.SingleOrDefaultAsync(m => m.AssetGroupId == id);
			//_context.AssetGroup.Remove(assetGroup);

			assetGroup.setDelete();

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetGroupExists(int id)
        {
            return _context.AssetGroup.Where(i => i.IsDelete == 0).Any(e => e.AssetGroupId == id);
		}
    }
}
