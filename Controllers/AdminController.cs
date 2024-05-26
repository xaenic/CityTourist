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

        public IActionResult City()
        {
            City[] cities = Array.Empty<City>();


            cities = dbContext.City.ToArray();

            return View(cities);
        }

        [HttpPost]
        public IActionResult City(City city)
        {

            return View();
        }


        [HttpPost]
        public IActionResult Edit(City city)
        {
            if (ModelState.IsValid)
            {
                dbContext.Update(city);
                dbContext.SaveChanges();
                return RedirectToAction("City");
            }
            return View(city);

            var Cities  = dbContext.City.Where( c => c.Id != 0).ToArray(); 
            
            return View();

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var city = dbContext.City.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            dbContext.City.Remove(city);
            dbContext.SaveChanges();

            TempData["Success"] = "City deleted successfully!";
            return RedirectToAction("City");
        }
        [HttpPost]
        public IActionResult Insert(City model)
        {
            if (ModelState.IsValid)
            {
                var newCity = new City
                {
                    Name = model.Name,
                    State = model.State
                };

                dbContext.City.Add(newCity);
                dbContext.SaveChanges();

                TempData["Success"] = "City inserted successfully!";
                return RedirectToAction("City");
            }
            else
            {
                return View("Index", model);
            }
        }
        public IActionResult Place()
        {

            ViewBag.Cities  = dbContext.City.Where( c => c.Id != 0).ToArray();
            ViewBag.place = dbContext.Place.Where(c => c.Id != 0).ToArray();

            return View();
        }

        [HttpPost]
        public IActionResult Place(Place place)
        {

            return View(place);
        }
        [HttpPost]
        public IActionResult Account([FromBody] Place place)
        {
            if (ModelState.IsValid)
            {
                if (place.Id == 0)
                {
                 
                    dbContext.Place.Add(place);
                }
                else
                {
                    dbContext.Place.Update(place);
                }

                dbContext.SaveChanges();
                return Ok(); 
            }
            return BadRequest(ModelState); 
        }
        [HttpPost]
        public IActionResult DeletePlace(int id)
        {
            var place = dbContext.Place.Find(id);
            if (place == null)
            {
                return NotFound(); // Place not found
            }

            dbContext.Place.Remove(place);
            dbContext.SaveChanges();
            return Ok();
        }


    }
}
