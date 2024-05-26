using CityTourist.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CityTourist.Controllers
{
    public class HomeController : Controller
    {


        private readonly TouristDbContext dbContext;



        public HomeController(TouristDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {

            ViewBag.Luzon = dbContext.City.Where(c => c.State == "Luzon").ToArray();
            ViewBag.Visayas = dbContext.City.Where(c => c.State == "Visayas").ToArray();
            ViewBag.Mindanao = dbContext.City.Where(c => c.State == "Mindanao").ToArray();
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
