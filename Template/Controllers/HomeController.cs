using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.DAL;
using Template.ViewModels;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
                HomeVM homeVM = new HomeVM
                {
                   Sliders=_context.Sliders.ToList(),
                   Facilities=_context.Facilities.ToList(),
                   Featureds=_context.Featureds.ToList(),
                   AboutDescriptions=_context.AboutDescriptions.ToList(),
                   Logos=_context.Logos.ToList()

                };
                return View(homeVM);
            
         
        }
    }
}
