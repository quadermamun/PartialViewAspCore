using Microsoft.AspNetCore.Mvc;
using PartialViewAspCore.Models;
using System.Diagnostics;

namespace PartialViewAspCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            List<Product> products = new List<Product>() 
            { 
                   new Product { Id=101, Name="Rebok Shoes", Description="Description 1", Price=10000.00, Image="~/images/rebok.jpg"},
                   new Product { Id=102, Name="Reyben Glass", Description="Description 2", Price=80000.00, Image="~/images/reyben.jpg"},
                   new Product { Id=103, Name="Rolex Watch", Description="Description 3", Price=110000.00, Image="~/images/rolex.jpg"}
            };

            return View(products);
        }



        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
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
