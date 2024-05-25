using CityTourist.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CityTourist.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
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
