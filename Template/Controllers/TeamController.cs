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
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult TeamIndex()
        {
            List<Team> teams = _context.Teams.Include(t => t.Position).ToList();    
            return View(teams);
        }
    }
}
