using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Eshop_11_4.Infrastructure;
using Eshop_11_4.Models;
using Eshop_11_4.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Eshop_11_4.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private Cart cart;


        public CartController(ApplicationDbContext context,Cart cartService)
        {
            _context = context;
            cart = cartService;
        }

        [Authorize]
        [HttpGet("/ViewOrderDetails")]
        public async Task<IActionResult> ViewOrderDetails(int id)
        {
            var applicationDbContext = _context.Lines.Include(p => p.Order).Include(p=>p.Product);
            return View(await applicationDbContext.Where(x =>(x.OrderID==id) && x.Order.AuthenticateUserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).ToListAsync());
        }

        [Authorize(Roles = "Admin,Manager")]
        [HttpGet("/ViewOrderDetailsAdmin")]
        public async Task<IActionResult> ViewOrderDetailsAdmin(int id)
        {
            var applicationDbContext = _context.Lines.Include(p => p.Order).Include(p => p.Product);
            return View(await applicationDbContext.Where(x => x.OrderID == id).ToListAsync());
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }



        public ActionResult AddToCart(int productId, string returnUrl, int quantity)
        {
            Product product = _context.Products
            .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {        
                cart.AddItem(product, quantity);
            }
        return Redirect(returnUrl);
        }


      



        public RedirectToActionResult RemoveFromCart(int productId,
        string returnUrl)
        {
            Product product = _context.Products
            .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
      
 
    }
}