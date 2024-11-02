using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace asp_net_mvc_shop.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrderService orderService;
        private string GetUseId()=> User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }
       // [AllowAnonymous]
        public IActionResult Index()
        {
            return View(orderService.GetAll(GetUseId()));
        }
      
        public IActionResult Create()
        {
            //create order
            //id
            //date.now
            //cartService.GetProducts
          
            orderService.Create(GetUseId());

            return RedirectToAction(nameof(Index));
        }
    }
}
