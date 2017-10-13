using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace OdeToFood_CoreFundamentals.Entities
{
    public class OdeToFoodDbContext : IdentityDbContext<User>
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
