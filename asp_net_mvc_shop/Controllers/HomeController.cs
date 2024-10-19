using asp_net_mvc_shop.Models;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp_net_mvc_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService service;

        public HomeController(IProductService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            //~Views/Controller/Action     ~Views/Home/Index
            return View(service.GetAll());
        }

        public IActionResult Privacy()
        {
            //code 
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
