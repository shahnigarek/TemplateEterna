using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;

namespace Template.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>  options) :base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<AboutDescription> AboutDescriptions  { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Clients>  Clients   { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Featured> Featureds { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Logo> Logos{ get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioImg> PortfolioImgs{ get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Pricing > Pricings { get; set; }
        public DbSet<PricingServices> PricingServices{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider> Sliders{ get; set; }
        public DbSet<SServices> SServices{ get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }











    }
}
