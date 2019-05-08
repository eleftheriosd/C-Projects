using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eshop_11_4.Data;
using Eshop_11_4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Eshop_11_4.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;


        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductType).Include(p => p.Room);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductType)
                .Include(p => p.Room)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        // GET: Products/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["RoomId"] = new SelectList(_context.Rooms, "RoomId", "Name");
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "ProductTypeId", "Name");
            return View();
        }

        ///

        [HttpGet("/ViewProductsCustomer")]
           public async Task<IActionResult> ViewProductsCustomer(int id , string name, string category)
        {
            TempData["var"] = name;
            var applicationDbContext = _context.Products.Include(p => p.ProductType).Include(p => p.Room);
            if(category == "ProductType")
            {
                return View(await _context.Products.Where(x => x.ProductTypeId == id).ToListAsync());
            }
            else if(category=="Room"){
                return View(await _context.Products.Where(x => x.RoomId == id).ToListAsync());
            }
            return View();
        }

        /// <summary>
        /// VIEW PRODUCTS ADMIN
        /// </summary>
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ViewProductsAdmin(int id)
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductType).Include(p => p.Room);
            return View(await applicationDbContext.ToListAsync());
        }


        /// <summary>
        /// VIEW PRODUCTS DETAILS>?
        /// </summary>

        public async Task<IActionResult> ViewProductDetails(int id)
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductType).Include(p => p.Room);
            return View(await _context.Products.Where(x => x.ProductId == id).ToListAsync());
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Name,Description,Image,Price,Stock,DateCreated,DateUpdated,Show,ProductTypeId,RoomId")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ViewProductsAdmin));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "ProductTypeId", "Name", product.ProductTypeId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "RoomId", "Name", product.RoomId);
            return View(product);
        }

        // GET: Products/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
          
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "ProductTypeId", "Name", product.ProductTypeId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "RoomId", "Name", product.RoomId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]                      
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Name,Description,Image,Price,Stock,DateCreated,DateUpdated,Show,ProductTypeId,RoomId")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ViewProductsAdmin));
            }
            ViewData["RoomId"] = new SelectList(_context.Rooms, "RoomId", "RoomId", product.RoomId);
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "ProductTypeId", "ProductTypeId", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductType)
                .Include(p => p.Room)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ViewProductsAdmin));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
