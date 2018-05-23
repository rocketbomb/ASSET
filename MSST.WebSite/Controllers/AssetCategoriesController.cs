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
    public class AssetCategoriesController : Controller
    {
        private readonly ASSETContext _context;

        public AssetCategoriesController(ASSETContext context)
        {
            _context = context;
        }

        // GET: AssetCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.AssetCategory.ToListAsync());
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

            var assetCategory = await _context.AssetCategory
                .SingleOrDefaultAsync(m => m.AssetCategoryId == id);
            if (assetCategory == null)
            {
                return NotFound();
            }

            return View(assetCategory);
        }

        // POST: AssetCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetCategory = await _context.AssetCategory.SingleOrDefaultAsync(m => m.AssetCategoryId == id);
            _context.AssetCategory.Remove(assetCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetCategoryExists(int id)
        {
            return _context.AssetCategory.Any(e => e.AssetCategoryId == id);
        }
    }
}
