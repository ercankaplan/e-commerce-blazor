﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBlazorShared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title  { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }    

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public Category? Category { get; set; }
    }
}
