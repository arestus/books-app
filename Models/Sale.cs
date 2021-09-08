using System;
using System.Collections.Generic;

#nullable disable

namespace BookAuthor.Models
{
    public partial class Sale
    {
        public string Name { get; set; }
        public int? Price { get; set; }
        public string Author { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
    }
}
