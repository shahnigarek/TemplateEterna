using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;

namespace Template.ViewModels
{
    public class AboutVM
    {
        public List<AboutDescription> AboutDescriptions { get; set; }
        public List<Logo> Logos { get; set; }
        public List<FeedBack> FeedBacks { get; set; }
    }
}

