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
    public class AssetGroupsController : Controller
    {
        private readonly ASSETContext _context;

        public AssetGroupsController(ASSETContext context)
        {
            _context = context;
        }

        // GET: AssetGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.AssetGroup.ToListAsync());
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
        public async Task<IActionResult> Edit(int id, [Bind("AssetGroupId,Code,Name,AssetId,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetGroup assetGroup)
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

            var assetGroup = await _context.AssetGroup
                .SingleOrDefaultAsync(m => m.AssetGroupId == id);
            if (assetGroup == null)
            {
                return NotFound();
            }

            return View(assetGroup);
        }

        // POST: AssetGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetGroup = await _context.AssetGroup.SingleOrDefaultAsync(m => m.AssetGroupId == id);
            _context.AssetGroup.Remove(assetGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetGroupExists(int id)
        {
            return _context.AssetGroup.Any(e => e.AssetGroupId == id);
        }
    }
}
