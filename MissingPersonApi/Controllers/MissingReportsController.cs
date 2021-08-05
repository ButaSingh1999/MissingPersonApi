using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MissingPersonApi.Data;
using MissingPersonApi.Models;

namespace MissingPersonApi.Controllers
{
    public class MissingReportsController : Controller
    {
        private readonly MissingPersonApiContext _context;

        public MissingReportsController(MissingPersonApiContext context)
        {
            _context = context;
        }

        // GET: MissingReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.MissingReport.ToListAsync());
        }

        public async Task<IActionResult> showReport()
        {
            return View(await _context.MissingReport.ToListAsync());
        }


        // GET: MissingReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var missingReport = await _context.MissingReport
                .FirstOrDefaultAsync(m => m.id == id);
            if (missingReport == null)
            {
                return NotFound();
            }

            return View(missingReport);
        }

        // GET: MissingReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MissingReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Ctitle,CAddress,Mdate,Cdetail")] MissingReport missingReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(missingReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(missingReport);
        }

        // GET: MissingReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var missingReport = await _context.MissingReport.FindAsync(id);
            if (missingReport == null)
            {
                return NotFound();
            }
            return View(missingReport);
        }

        // POST: MissingReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Ctitle,CAddress,Mdate,Cdetail")] MissingReport missingReport)
        {
            if (id != missingReport.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(missingReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MissingReportExists(missingReport.id))
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
            return View(missingReport);
        }

        // GET: MissingReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var missingReport = await _context.MissingReport
                .FirstOrDefaultAsync(m => m.id == id);
            if (missingReport == null)
            {
                return NotFound();
            }

            return View(missingReport);
        }

        // POST: MissingReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var missingReport = await _context.MissingReport.FindAsync(id);
            _context.MissingReport.Remove(missingReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MissingReportExists(int id)
        {
            return _context.MissingReport.Any(e => e.id == id);
        }
    }
}
