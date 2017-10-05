using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood_CoreFundamentals.Entities;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood_CoreFundamentals.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine{ get; set; }
    }
}
