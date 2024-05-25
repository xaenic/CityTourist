using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using CityTourist.Models;
namespace CityTourist.Components
{
    public class SideBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var links = new List<NavLinkModel>
            {
                new NavLinkModel { Url = "/admin", Name="Dashboard", Controller="Admin"},
                new NavLinkModel { Url = "/admin/city", Name="City",Controller="Admin"},
                new NavLinkModel { Url = "/admin/place", Name="Place", Controller = "Admin"},
            };
            return View(links);
        }
    }
}
