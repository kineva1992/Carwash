using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carwash.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Carwash.Controllers
{
    public class CarsController : Controller
    {
        private readonly ProductDbContext _context;
        public CarsController(ProductDbContext context)
        {
            
            _context = context;
        }
        // GET: CarsController
        public async Task <ActionResult> Index()
        {
            return View(await _context.ClassAutos.ToListAsync());

        }

        // GET: CarsController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) {
                return NotFound();
            }

                return View();
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            SelectList classAutos = new SelectList(_context.Products, "ProductID", "ProductName");
            ViewBag.Products = classAutos;
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Create([Bind("ClassAutoID,NameAuto,ClassAutos,ProductID")] ClassAuto classAuto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classAuto);
                await _context.SaveChangesAsync();
                return (RedirectToAction(nameof(Index)));
            }
            else {

                ModelState.AddModelError("", "Что-то пошло не так");
            }

            SelectList classAutos = new SelectList(_context.Products, "ProductID", "ProductName");
            ViewBag.Product = classAutos;
            return View(classAuto);
        }

        // GET: CarsController/Edit/5
        public async Task <ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var classAutos = await _context.ClassAutos.FindAsync(id);

            if (classAutos == null)
            {
                return NotFound();
            }
            SelectList selectClassAutoEditGetMethot = new SelectList(_context.Products, "ProductID", "ProductName");
            ViewBag.Products = selectClassAutoEditGetMethot;
            return View(classAutos);

            

            
        }
    

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Edit(int id, [Bind("ClassAutoID,NameAuto,ClassAutos,ProductID")] ClassAuto classAuto)
        {
            if (id != classAuto.ClassAutoID) {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classAuto);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    if (!ProductExists(classAuto.ClassAutoID))
                    {
                        return NotFound();
                    }

                    else throw;
                    
                }

                //return RedirectToAction(nameof(Index));
            }
            SelectList selectClassAutoEditGetMethot = new SelectList(_context.Products, "ProductID", "ProductName");
            ViewBag.Products = selectClassAutoEditGetMethot;
            return View(classAuto);
        }

        // GET: CarsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

           
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
