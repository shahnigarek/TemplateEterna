using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.DAL;
using Template.ViewModels;

namespace Template.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult AboutIndex()
        {
            AboutVM aboutVM = new AboutVM
            {
              
                AboutDescriptions = _context.AboutDescriptions.ToList(),
                Logos = _context.Logos.ToList(),
                FeedBacks=_context.FeedBacks.ToList(),


            };
            return View(aboutVM);
        }
    }
}
