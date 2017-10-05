using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood_CoreFundamentals.Services;
using OdeToFood_CoreFundamentals.ViewModels;

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
    }
}
