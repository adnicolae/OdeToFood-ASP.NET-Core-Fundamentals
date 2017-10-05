using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood_CoreFundamentals.Entities;

namespace OdeToFood_CoreFundamentals.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
