using Microsoft.AspNetCore.Mvc;

namespace CityTourist.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
