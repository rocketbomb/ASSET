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

namespace ASSET.WebSite.Controllers
{
    public class AssetUnitsController : Controller
    {
        private readonly ASSETContext _context;

        public AssetUnitsController(ASSETContext context)
        {
            _context = context;
        }

        // GET: AssetUnits
        public async Task<IActionResult> Index()
        {
            return View(await _context.AssetUnit.Where(i=>i.IsDelete == 0).ToListAsync());
        }

        // GET: AssetUnits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetUnit = await _context.AssetUnit
                .SingleOrDefaultAsync(m => m.AssetUnitId == id);
            if (assetUnit == null)
            {
                return NotFound();
            }

            return View(assetUnit);
        }

        // GET: AssetUnits/Create
        public IActionResult Create()
        {
			Utility u = new Utility();
			ViewBag.CurrentDate = u.CurrentDate();

			return View();
        }

        // POST: AssetUnits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssetUnitId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetUnit assetUnit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assetUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetUnit);
        }

        // GET: AssetUnits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetUnit = await _context.AssetUnit.SingleOrDefaultAsync(m => m.AssetUnitId == id);

            if (assetUnit == null)
            {
                return NotFound();
            }
            return View(assetUnit);
        }

        // POST: AssetUnits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssetUnitId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetUnit assetUnit)
        {
            if (id != assetUnit.AssetUnitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetUnitExists(assetUnit.AssetUnitId))
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
            return View(assetUnit);
        }

        // GET: AssetUnits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetUnit = await _context.AssetUnit
                .SingleOrDefaultAsync(m => m.AssetUnitId == id);
            if (assetUnit == null)
            {
                return NotFound();
            }

            return View(assetUnit);
        }

        // POST: AssetUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetUnit = await _context.AssetUnit.SingleOrDefaultAsync(m => m.AssetUnitId == id);
            //_context.AssetUnit.Remove(assetUnit);

			assetUnit.IsDelete = 1;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetUnitExists(int id)
        {
            return _context.AssetUnit.Any(e => e.AssetUnitId == id);
        }
    }
}
