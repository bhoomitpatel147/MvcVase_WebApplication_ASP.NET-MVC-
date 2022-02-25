using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcVase.Data;
using MvcVase.Models;

namespace MvcVase.Controllers
{
    public class VasesController : Controller
    {
        private readonly MvcVaseContext _context;

        public VasesController(MvcVaseContext context)
        {
            _context = context;
        }

        // GET: Vases

        // Change the Index method for the add search function by the Vases Name:

        public async Task<IActionResult> Index(string vaseMaterial, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> materialQuery = from m in _context.Vase
                                            orderby m.Material
                                            select m.Material;

            var vases = from m in _context.Vase 
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                vases = vases.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(vaseMaterial))
            {
                vases = vases.Where(x => x.Material == vaseMaterial);
            }

            var vaseMaterialVM = new VaseMaterialViewModel {
                Materials = new SelectList(await materialQuery.Distinct().ToListAsync()),
                Vases = await vases.ToListAsync()
            };

            return View(vaseMaterialVM);
        }

        // GET: Vases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vase = await _context.Vase
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vase == null)
            {
                return NotFound();
            }

            return View(vase);
        }

        // GET: Vases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] //Edit method can be invoked by the POST method we can set that as a GET as well
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Material,Shape,Antique,Rating")] Vase vase)  // Added new Bind value for Rating
        {
            if (ModelState.IsValid)
            {
                _context.Add(vase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vase);
        }

        // GET: Vases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vase = await _context.Vase.FindAsync(id);
            if (vase == null)
            {
                return NotFound();
            }
            return View(vase);
        }

        // POST: Vases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Material,Shape,Antique,Rating")] Vase vase)
        {
            if (id != vase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaseExists(vase.Id))
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
            return View(vase);
        }

        // GET: Vases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vase = await _context.Vase
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vase == null)
            {
                return NotFound();
            }

            return View(vase);
        }

        // POST: Vases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vase = await _context.Vase.FindAsync(id);
            _context.Vase.Remove(vase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaseExists(int id)
        {
            return _context.Vase.Any(e => e.Id == id);
        }
    }
}
