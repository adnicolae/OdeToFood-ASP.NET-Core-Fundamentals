using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood_CoreFundamentals.Entities;

namespace OdeToFood_CoreFundamentals.ViewModels
{
    public class RestaurantEditViewModel
    {
        public string Name { get; set; }
        public CuisineType Cuisine{ get; set; }
    }
}
