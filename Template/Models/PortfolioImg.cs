﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Models
{
    public class PortfolioImg
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public Portfolio Portfolio { get; set; }
        public int PortfolioId { get; set; }

    }
}
