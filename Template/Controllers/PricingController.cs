﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult PricingIndex()
        {
            return View();
        }
    }
}
