using BusinessLogic.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_shop.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService service;

        public CartController(IProductService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            //1 5 7 8 9 99 25 14
            var productIds = HttpContext.Session.GetObject<List<int>>("cart");
            List<Product> products = new List<Product>();

           
            if (productIds != null)
            {
                products = service.Get(productIds.ToArray());
            }
            return View(products);
        }
        public IActionResult Add(int productId, string returnUrl )
        {
            var productIds = HttpContext.Session.GetObject<List<int>>("cart");
            if (productIds == null) { productIds = new List<int>(); }
            productIds.Add(productId);
            HttpContext.Session.SetObject("cart", productIds);
            return Redirect(returnUrl);
        }

        public IActionResult Remove(int productId, string returnUrl)
        {
            var productIds = HttpContext.Session.GetObject<List<int>>("cart");
            if (productIds == null) { productIds = new List<int>(); }
            productIds.Remove(productId);
            HttpContext.Session.SetObject("cart", productIds);
            return Redirect(returnUrl);
        }
    }
}
