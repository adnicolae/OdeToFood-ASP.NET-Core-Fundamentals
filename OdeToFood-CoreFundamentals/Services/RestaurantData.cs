using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood_CoreFundamentals.Entities;

namespace OdeToFood_CoreFundamentals.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "The house of Kobe"},
                new Restaurant { Id = 2, Name = "Cat's Restaurant" },
                new Restaurant { Id = 3, Name = "Dog's"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
