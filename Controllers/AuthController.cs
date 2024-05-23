using CityTourist.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Flexify.Controllers
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
        [HttpGet]
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;


            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("", "App");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }
        [HttpPost]
        public async Task<IActionResult> Login(AdminModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            var userFound = dbContext.Admin.FirstOrDefault(u => u.UserName == user.UserName);
            if (userFound == null)
            {
                TempData["Error"] = "Account Not Found";
                return View(user);
            }
            if (userFound.Password != user.Password)
            {
                TempData["Error"] = "Incorrect password";
                return View(user); 
            }

            List<Claim> claims = new List<Claim>() {
                new Claim(ClaimTypes.NameIdentifier, userFound.UserName),
                new Claim("UserId", userFound.Id +""),
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            AuthenticationProperties properties = new AuthenticationProperties()
            {
                AllowRefresh = true,
                IsPersistent = true,
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity), properties
                );

            return RedirectToAction("", "App");
        }


    }
}
