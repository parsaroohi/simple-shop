using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEshop.Models
{
    public class DetailsViewModel
    {
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }
    }
}
