using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace OdeToFood_CoreFundamentals.Controllers
{ 
    [Authorize]
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1+555-555-5555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
