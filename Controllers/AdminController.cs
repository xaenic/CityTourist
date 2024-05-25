using CityTourist.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityTourist.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly TouristDbContext dbContext;
        public AdminController(TouristDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult City() {

            return View();

        }

        [HttpPost]
        public IActionResult City(City city)
        {

            return View();
        }
        public IActionResult Place()
        {

            ViewBag.Cities  = dbContext.City.Where( c => c.Id != 0).ToArray(); 
            
            return View();
        }

        [HttpPost]
        public IActionResult Place(Place place)
        {

            return View(place);
        }
    }
}
