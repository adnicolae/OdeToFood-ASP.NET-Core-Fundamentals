using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood_CoreFundamentals.Services;
using OdeToFood_CoreFundamentals.ViewModels;
using OdeToFood_CoreFundamentals.Entities;

namespace OdeToFood_CoreFundamentals.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetGreeting();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);

            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // Get the form
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Post the data back to the server
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newRestaurant = new Restaurant();
                newRestaurant.Cuisine = model.Cuisine;
                newRestaurant.Name = model.Name;

                newRestaurant = _restaurantData.Add(newRestaurant);
                return RedirectToAction("Details", new { id = newRestaurant.Id });
            }
            return View();
        }
    }
}
