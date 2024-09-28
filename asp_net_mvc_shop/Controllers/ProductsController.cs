using asp_net_mvc_shop.Helpers;
using asp_net_mvc_shop.Models;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp_net_mvc_shop.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ShopDbContext dbContext;
        public ProductsController(ShopDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            //GET : ~/Products/Index
            //TODO : get data from DB
            return View(dbContext.Products.ToList());
        }
        public IActionResult Details(int id)//7
        {
            //GET : ~/Products/Details
            if (id < 0) { return BadRequest(); }//error 400
      
            var product = dbContext.Products.Find(id);  
         
            if (product == null) { return NotFound(); }//error 404
            return View(product);
        }
        //GET : ~/Products/Create
        public IActionResult Create()
        {
            //ViewData and ViewBag
            //ViewData["List"] = new List<int> { 1, 2, 3 }; // List as Object
            ViewBag.CategoryList = new SelectList( dbContext.Categories.ToList(), 
                nameof(Category.Id), nameof(Category.Name));    
            return View();
        }
        //Post : ~/Products/Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            //add to database
            dbContext.Products.Add(product);
            dbContext.SaveChanges();    
            return RedirectToAction(nameof(Index));
        }
    }
}
