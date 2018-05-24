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
    public class AssetWarrantiesController : Controller
    {
        private readonly ASSETContext _context;

        public AssetWarrantiesController(ASSETContext context)
        {
            _context = context;
        }

        // GET: AssetWarranties
        public async Task<IActionResult> Index()
        {
            return View(await _context.AssetWarranty.ToListAsync());
        }

        // GET: AssetWarranties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetWarranty = await _context.AssetWarranty
                .SingleOrDefaultAsync(m => m.AssetWarrantyId == id);
            if (assetWarranty == null)
            {
                return NotFound();
            }

            return View(assetWarranty);
        }

        // GET: AssetWarranties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AssetWarranties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssetWarrantyId,InvoiceNumber,VoucherNumber,SupplierId,PolicyNumber,ContractNumber,Address,Telphone,WarrantyDuration,WarrantyStart,WarrantyEnd,Premium,Remark,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetWarranty assetWarranty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assetWarranty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetWarranty);
        }

        // GET: AssetWarranties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetWarranty = await _context.AssetWarranty.SingleOrDefaultAsync(m => m.AssetWarrantyId == id);
            if (assetWarranty == null)
            {
                return NotFound();
            }
            return View(assetWarranty);
        }

        // POST: AssetWarranties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssetWarrantyId,InvoiceNumber,VoucherNumber,SupplierId,PolicyNumber,ContractNumber,Address,Telphone,WarrantyDuration,WarrantyStart,WarrantyEnd,Premium,Remark,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] AssetWarranty assetWarranty)
        {
            if (id != assetWarranty.AssetWarrantyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assetWarranty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetWarrantyExists(assetWarranty.AssetWarrantyId))
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
            return View(assetWarranty);
        }

        // GET: AssetWarranties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetWarranty = await _context.AssetWarranty
                .SingleOrDefaultAsync(m => m.AssetWarrantyId == id);
            if (assetWarranty == null)
            {
                return NotFound();
            }

            return View(assetWarranty);
        }

        // POST: AssetWarranties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetWarranty = await _context.AssetWarranty.SingleOrDefaultAsync(m => m.AssetWarrantyId == id);
            _context.AssetWarranty.Remove(assetWarranty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetWarrantyExists(int id)
        {
            return _context.AssetWarranty.Any(e => e.AssetWarrantyId == id);
        }
    }
}
