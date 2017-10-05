using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood_CoreFundamentals.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        Japanese,
        American
    }

    public class Restaurant
    {
        public int Id { get; set; }

        // add an annotation to change the display name of the name property inside the label
        [Required, MaxLength(80)]
        [Display(Name="Restaurant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
