using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop_11_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eshop_11_4.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Eshop_11_4.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AuthenticateUser> _userManager;
        public OrderController(IOrderRepository repoService, Cart cartService, UserManager<AuthenticateUser> userManager, ApplicationDbContext context)
        {
            repository = repoService;
            cart = cartService;
            _userManager = userManager;
            _context = context;
        }
    
        [Authorize]
        public ViewResult Checkout() {
            return View(new Order());
        } 

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                
                order.Lines = cart.Lines.ToArray();
                
                order.AuthenticateUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                
                repository.SaveOrder(order);


                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        [Authorize]
        [HttpGet("/ViewOrders")]
        public async Task<IActionResult> ViewOrders()
        {
            var applicationDbContext = _context.Orders;
            return View(await applicationDbContext.Where(x => x.AuthenticateUserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).ToListAsync());
        }

        [Authorize(Roles = "Admin,Manager")]
        [HttpGet("/ViewOrdersAdmin")]
        public async Task<IActionResult> ViewOrdersAdmin()
        {
            var applicationDbContext = _context.Orders;
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,Name,LastName,OrderShipped,DateCreated,Phone,Address,City,Zip,Country,AuthenticateUserId")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                    _context.Update(order);
                    await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(ViewOrdersAdmin));
            }
            return View(order);
        }

        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}