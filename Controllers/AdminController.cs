using CityTourist.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityTourist.Controllers
{
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

            return View();
        }

        [HttpPost]
        public IActionResult Place(Place place)
        {

            return View();
        }
    }
}
