using asp_net_mvc_shop.Helpers;
using asp_net_mvc_shop.Models;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_shop.Controllers
{
    public class ProductsController : Controller
    {

        ShopDbContext dbContext;
        public ProductsController()
        {
            dbContext = new ShopDbContext();
        }
        public IActionResult Index()
        {
            //TODO : get data from DB
            return View(dbContext.Products.ToList());
        }
        public IActionResult Details(int id)//7
        {
            if (id < 0) { return BadRequest(); }//error 400
      
            var product = dbContext.Products.Find(id);  
         
            if (product == null) { return NotFound(); }//error 404
            return View(product);
        }
    }
}
