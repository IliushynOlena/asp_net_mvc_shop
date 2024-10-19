using asp_net_mvc_shop.Helpers;
using asp_net_mvc_shop.Models;
using BusinessLogic.Interfaces;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp_net_mvc_shop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            //GET : ~/Products/Index
            //TODO : get data from DB
            return View(service.GetAll());
        }
        //GET : ~/Products/Edit
        public IActionResult Edit(int id)
        {
            var product = service.GetById(id);
            if (product == null) return NotFound();
            LoadCategories();
            return View(product);
        }
        //Post : ~/Products/Edit
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View(product);
            }
           service.Edit(product);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            service.Delete(id);  
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int id, string returnUrl = null)//7
        {
            //GET : ~/Products/Details
            if (id < 0) { return BadRequest(); }//error 400
      
            var product = service.GetById(id); 
         
            if (product == null) { return NotFound(); }//error 404
            ViewBag.ReturnUrl = returnUrl;
            return View(product);
        }
        private void LoadCategories()
        {
            //ViewData and ViewBag
            //ViewData["List"] = new List<int> { 1, 2, 3 }; // List as Object
            ViewBag.CategoryList = new SelectList(service.GetCategories(),
                nameof(Category.Id), nameof(Category.Name));
        }
        //GET : ~/Products/Create
        public IActionResult Create()
        {
            LoadCategories();
            return View();
        }
        //Post : ~/Products/Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            //TODO: add validators 
            //if (product.Name.Length > 0 && string.IsNullOrWhiteSpace(product.Name) && product.Price > 0)
            //{
            //}
            if (!ModelState.IsValid) {
                LoadCategories();
                return View(product);
            }

           service.Create(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
