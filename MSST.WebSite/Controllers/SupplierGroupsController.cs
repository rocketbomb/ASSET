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
    public class SupplierGroupsController : Controller
    {
        private readonly ASSETContext _context;
		private readonly Utility _u;

		public SupplierGroupsController(ASSETContext context)
        {
            _context = context;
			_u = new Utility();

		}

        // GET: SupplierGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.SupplierGroup.ToListAsync());
        }

        // GET: SupplierGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierGroup = await _context.SupplierGroup
                .SingleOrDefaultAsync(m => m.SupplierGroupId == id);
            if (supplierGroup == null)
            {
                return NotFound();
            }

            return View(supplierGroup);
        }

        // GET: SupplierGroups/Create
        public IActionResult Create()
        {

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			return View();
        }

        // POST: SupplierGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierGroupId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] SupplierGroup supplierGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplierGroup);
        }

        // GET: SupplierGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierGroup = await _context.SupplierGroup.SingleOrDefaultAsync(m => m.SupplierGroupId == id);

			ViewBag.getCurrentDate = _u.getCurrentDate();
			ViewBag.getUser = _u.getUser();

			if (supplierGroup == null)
            {
                return NotFound();
            }
            return View(supplierGroup);
        }

        // POST: SupplierGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierGroupId,Code,Name,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] SupplierGroup supplierGroup)
        {
            if (id != supplierGroup.SupplierGroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierGroupExists(supplierGroup.SupplierGroupId))
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
            return View(supplierGroup);
        }

        // GET: SupplierGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierGroup = await _context.SupplierGroup
                .SingleOrDefaultAsync(m => m.SupplierGroupId == id);
            if (supplierGroup == null)
            {
                return NotFound();
            }

            return View(supplierGroup);
        }

        // POST: SupplierGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplierGroup = await _context.SupplierGroup.SingleOrDefaultAsync(m => m.SupplierGroupId == id);
            _context.SupplierGroup.Remove(supplierGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierGroupExists(int id)
        {
            return _context.SupplierGroup.Any(e => e.SupplierGroupId == id);
        }
    }
}
