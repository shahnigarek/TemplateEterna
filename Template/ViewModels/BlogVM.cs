using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;

namespace Template.ViewModels
{
    public class BlogVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Category> Categories { get; set; }
    }
}
