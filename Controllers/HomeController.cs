using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Carwash.Models;


namespace Carwash.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext _contex;

        public HomeController(ProductDbContext context) {
            _contex = context;
        }

        //GET index page
        public async Task <IActionResult> Index()
        {

            return View(await _contex.NewsModels.ToListAsync());
        }


        //// GET: Products/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Products/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ProductID,ProductName,Discriptio,Price,ReleaseDate")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        product.ReleaseDate = DateTime.Today;
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(product);
        //}
    }
}
