using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;

namespace Template.ViewModels
{
    public class ServiceVM
    {
        public List<Facility> Facilities { get; set; }
        public List<SServices> SServices { get; set; }

    }
}
