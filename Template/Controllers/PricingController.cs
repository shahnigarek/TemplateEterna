using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.DAL;
using Template.Models;

namespace Template.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult PricingIndex()
        {
            List<Pricing> pricings = _context.Pricings.Include(p => p.PricingServices).ThenInclude(ps => ps.Service).ToList();
            ViewBag.Services = _context.Services.ToList();
            return View(pricings);
        }
    }
}
