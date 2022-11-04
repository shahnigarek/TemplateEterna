 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogIndex()
        {
            return View();
        }
    }
}
