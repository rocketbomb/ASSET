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
    public class AssetWarrantyCompaniesController : Controller
    {
        private readonly ASSETContext _context;

        public AssetWarrantyCompaniesController(ASSETContext context)
        {
            _context = context;
        }

        // GET: AssetWarrantyCompanies
        public async Task<IActionResult> Index()
        {
            return View(await _context.AssetWarrantyCompany.ToListAsync());
        }

        // GET: AssetWarrantyCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetWarrantyCompany = await _context.AssetWarrantyCompany
                .SingleOrDefaultAsync(m => m.AssetWarrantyCompanyId == id);
            if (assetWarrantyCompany == null)
            {
                return NotFound();
            }

            return View(assetWarrantyCompany);
        }

        // GET: AssetWarrantyCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AssetWarrantyCompanies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssetWarrantyCompanyId,Code,Name,Address,ContactNumber,ContactPerson,Email,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetWarrantyCompany assetWarrantyCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assetWarrantyCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetWarrantyCompany);
        }

        // GET: AssetWarrantyCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetWarrantyCompany = await _context.AssetWarrantyCompany.SingleOrDefaultAsync(m => m.AssetWarrantyCompanyId == id);
            if (assetWarrantyCompany == null)
            {
                return NotFound();
            }
            return View(assetWarrantyCompany);
        }

        // POST: AssetWarrantyCompanies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssetWarrantyCompanyId,Code,Name,Address,ContactNumber,ContactPerson,Email,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetWarrantyCompany assetWarrantyCompany)
        {
            if (id != assetWarrantyCompany.AssetWarrantyCompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetWarrantyCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetWarrantyCompanyExists(assetWarrantyCompany.AssetWarrantyCompanyId))
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
            return View(assetWarrantyCompany);
        }

        // GET: AssetWarrantyCompanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetWarrantyCompany = await _context.AssetWarrantyCompany
                .SingleOrDefaultAsync(m => m.AssetWarrantyCompanyId == id);
            if (assetWarrantyCompany == null)
            {
                return NotFound();
            }

            return View(assetWarrantyCompany);
        }

        // POST: AssetWarrantyCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetWarrantyCompany = await _context.AssetWarrantyCompany.SingleOrDefaultAsync(m => m.AssetWarrantyCompanyId == id);
            _context.AssetWarrantyCompany.Remove(assetWarrantyCompany);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetWarrantyCompanyExists(int id)
        {
            return _context.AssetWarrantyCompany.Any(e => e.AssetWarrantyCompanyId == id);
        }
    }
}
