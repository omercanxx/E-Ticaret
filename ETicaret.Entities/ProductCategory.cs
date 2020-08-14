using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Entities
{
    public class ProductCategory
    {
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
