using CityTourist.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityTourist.Controllers
{
    public class AuthController : Controller
    {
        private readonly TouristDbContext dbContext;
        public AuthController(TouristDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
