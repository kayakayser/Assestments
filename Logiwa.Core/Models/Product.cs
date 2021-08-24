using System;
using System.Collections.Generic;
using System.Text;

namespace Logiwa.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        public virtual Category Category { get; set; }

    }
}
