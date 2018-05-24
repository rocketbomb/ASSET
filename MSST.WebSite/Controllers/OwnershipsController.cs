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
    public class OwnershipsController : Controller
    {
        private readonly ASSETContext _context;

        public OwnershipsController(ASSETContext context)
        {
            _context = context;
        }

        // GET: Ownerships
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ownership.ToListAsync());
        }

        // GET: Ownerships/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownership = await _context.Ownership
                .SingleOrDefaultAsync(m => m.OwnershipId == id);
            if (ownership == null)
            {
                return NotFound();
            }

            return View(ownership);
        }

        // GET: Ownerships/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ownerships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OwnershipId,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] Ownership ownership)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ownership);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ownership);
        }

        // GET: Ownerships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownership = await _context.Ownership.SingleOrDefaultAsync(m => m.OwnershipId == id);
            if (ownership == null)
            {
                return NotFound();
            }
            return View(ownership);
        }

        // POST: Ownerships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OwnershipId,CreateBy,CreateDate,UpdateBy,UpdateDate,IsActive,IsDelete")] Ownership ownership)
        {
            if (id != ownership.OwnershipId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ownership);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OwnershipExists(ownership.OwnershipId))
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
            return View(ownership);
        }

        // GET: Ownerships/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownership = await _context.Ownership
                .SingleOrDefaultAsync(m => m.OwnershipId == id);
            if (ownership == null)
            {
                return NotFound();
            }

            return View(ownership);
        }

        // POST: Ownerships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ownership = await _context.Ownership.SingleOrDefaultAsync(m => m.OwnershipId == id);
            _context.Ownership.Remove(ownership);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OwnershipExists(int id)
        {
            return _context.Ownership.Any(e => e.OwnershipId == id);
        }
    }
}
