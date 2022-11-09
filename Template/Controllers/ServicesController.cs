using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.DAL;

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
            return View();
        }
    }
}
