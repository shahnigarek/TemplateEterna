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
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult PortfolioIndex()
        {
            List<Portfolio> portfolios = _context.Portfolios.Include(pi => pi.PortfolioImg).ToList();
            return View(portfolios);
        }

        public IActionResult PortfolioDetail(int? id)
        {
            Portfolio portfolio = _context.Portfolios.Include(pi => pi.PortfolioImg).FirstOrDefault(p => p.Id == id);
            return View(portfolio);
        }
    }
}
