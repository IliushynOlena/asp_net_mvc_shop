using asp_net_mvc_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp_net_mvc_shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //~Views/Controller/Action     `Views/Home/Index
            return View();
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
