using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEshop.Models
{
    public class CategoryToProduct
    {
        public int CategoryId { get; set; }

        public int ProductId { get; set; }

        //Navigation Property
        public Category Category { get; set; }

        public Product Product { get; set; }
    }
}
