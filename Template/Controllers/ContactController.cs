using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.DAL;
using Template.Models;
using Template.ViewModels;

namespace Template.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult ContactIndex()
        {
            ContactVM contactVM = new ContactVM
            {
                Contacts = _context.Contacts.ToList()
            };

            return View(contactVM);
        }
    }
}
