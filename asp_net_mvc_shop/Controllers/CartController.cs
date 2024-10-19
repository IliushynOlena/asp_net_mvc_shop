using BusinessLogic.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;

        public CartController(ICartService service)
        {
            this.cartService = service;
        }
        public IActionResult Index()
        {            
            return View(cartService.GetProducts());
        }
        public IActionResult Add(int productId, string returnUrl )
        {
            cartService.Add(productId);    
            return Redirect(returnUrl);
        }

        public IActionResult Remove(int productId, string returnUrl)
        {
            cartService.Remove(productId);
            return Redirect(returnUrl);
        }
    }
}
