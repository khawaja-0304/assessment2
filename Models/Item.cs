using System;
using System.Collections.Generic;

namespace assessment2.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public int? CostPrice { get; set; }
        public int? SalePrice { get; set; }
        public string MainImage { get; set; }
        public string ItemCode { get; set; }
        public string MainColor { get; set; }
        public string Status { get; set; }
    }
}
