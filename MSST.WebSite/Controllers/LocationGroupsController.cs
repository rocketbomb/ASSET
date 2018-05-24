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
    public class LocationGroupsController : Controller
    {
        private readonly ASSETContext _context;

        public LocationGroupsController(ASSETContext context)
        {
            _context = context;
        }

        // GET: LocationGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.LocationGroup.ToListAsync());
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
            _context.LocationGroup.Remove(locationGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationGroupExists(int id)
        {
            return _context.LocationGroup.Any(e => e.LocationGroupId == id);
        }
    }
}
