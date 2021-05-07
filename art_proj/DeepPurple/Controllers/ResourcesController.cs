using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult Resources()
        {
            return View();
        }
    }
}
