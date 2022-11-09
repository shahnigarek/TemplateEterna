using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        

        public List<PricingServices> PricingServices { get; set; }

    }
}
