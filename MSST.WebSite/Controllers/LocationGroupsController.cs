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
    public class LocationGroupsController : Controller
    {
        private readonly ASSETContext _context;
		private readonly Utility _u;

		public LocationGroupsController(ASSETContext context)
        {
            _context = context;
			_u = new Utility();
		}

        // GET: LocationGroups
        public async Task<IActionResult> Index(string filterCode, string filterNameEng, string filterName, int page = 1, string sortExpression = "Name")
        {
			var item = _context.LocationGroup.Where(i => i.IsDelete == 0).AsNoTracking();

			if (!string.IsNullOrWhiteSpace(filterCode))
			{
				item = item.Where(p => p.Code.Contains(filterCode));
			}

			if (!string.IsNullOrWhiteSpace(filterNameEng))
			{
				item = item.Where(p => p.Name.Contains(filterNameEng));
			}

			if (!string.IsNullOrWhiteSpace(filterName))
			{
				item = item.Where(p => p.Name.Contains(filterName));
			}

			var model = await PagingList.CreateAsync(item, 10, page, sortExpression, "Name");

			model.RouteValue = new RouteValueDictionary {
															{ "filterCode", filterCode},
															{ "filterName", filterName},
															
														};

			return View(model);

			// return View(await _context.LocationGroup.ToListAsync());
		}

        // GET: LocationGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationGroup = await _context.LocationGroup
                .SingleOrDefaultAsync(m => m.LocationGroupId == id);
            if (locationGroup == null)
            {
                return NotFound();
            }

            return View(locationGroup);
        }

        // GET: LocationGroups/Create
        public IActionResult Create()
        {
			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View();
        }

        // POST: LocationGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationGroupId,Code,Barcode,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] LocationGroup locationGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locationGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locationGroup);
        }

        // GET: LocationGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationGroup = await _context.LocationGroup.SingleOrDefaultAsync(m => m.LocationGroupId == id);

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			if (locationGroup == null)
            {
                return NotFound();
            }
            return View(locationGroup);
        }

        // POST: LocationGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationGroupId,Code,Barcode,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] LocationGroup locationGroup)
        {
            if (id != locationGroup.LocationGroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locationGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationGroupExists(locationGroup.LocationGroupId))
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
            return View(locationGroup);
        }

        // GET: LocationGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationGroup = await _context.LocationGroup
                .SingleOrDefaultAsync(m => m.LocationGroupId == id);
            if (locationGroup == null)
            {
                return NotFound();
            }

            return View(locationGroup);
        }

        // POST: LocationGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationGroup = await _context.LocationGroup.SingleOrDefaultAsync(m => m.LocationGroupId == id);
			//_context.LocationGroup.Remove(locationGroup);

			locationGroup.setDelete();

			await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationGroupExists(int id)
        {
            return _context.LocationGroup.Where(i=>i.IsDelete == 0).Any(e => e.LocationGroupId == id);
        }
    }
}
