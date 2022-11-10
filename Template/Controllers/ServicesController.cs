using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.DAL;
using Template.ViewModels;

namespace Template.Controllers
{
    public class ServicesController : Controller
    {
          private readonly AppDbContext _context;
        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult ServicesIndex()
        {
            ServiceVM serviceVM = new ServiceVM
            {
                SServices = _context.SServices.ToList(),
                Facilities = _context.Facilities.ToList()
            };
            
            
            return View(serviceVM);

        }
    }
}
