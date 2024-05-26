using CityTourist.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Sights()
        {

            var placesInLuzon = dbContext.Place
                                 .Include(p => p.City)
                                 .Where(p => p.City.State == "Luzon")
                                 .ToList();
            var visayas = dbContext.Place
                                 .Include(p => p.City)
                                 .Where(p => p.City.State == "Visayas")
                                 .ToList();
            var mindanao = dbContext.Place
                                 .Include(p => p.City)
                                 .Where(p => p.City.State == "Mindanao")
                                 .ToList();
            ViewBag.Luzon = placesInLuzon;

            ViewBag.Visayas = visayas;
            ViewBag.Mindanao = mindanao;
            return View();
        }
        public IActionResult CityView(string id)
        {
            if (string.IsNullOrEmpty(id))
            {

                return RedirectToAction("Index", "Home");
            }
            var plachere = dbContext.Place
                                 .Include(p => p.City)
                                 .Where(p => p.City.Id == int.Parse(id))
                                 .ToList();
            if(plachere.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.CityName = plachere[0].City.Name;
            ViewBag.Places = plachere;
            return View("City");
        }
        public IActionResult PlaceView(string id)
        {
            if (string.IsNullOrEmpty(id))
            {

                return RedirectToAction("Index", "Home");
            }
            Place place = dbContext.Place.FirstOrDefault(u => u.Id == int.Parse(id));
            return View(place);
        }
        public IActionResult Category(string category)
        {
            if (string.IsNullOrEmpty(category))
            {

                return RedirectToAction("Index", "Home");
            }
            var plachere = dbContext.Place
                                .Include(p => p.City)
                                .Where(p => p.Category == category)
                                .ToList();
            ViewBag.Places = plachere;
            ViewBag.Category = category;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
