using System;
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

        //public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public Category? Category { get; set; }

        public List<ProductVariant> Variants { get; set; }=new List<ProductVariant>();

        public string PriceText
        {

            get
            {
                return this.Variants.Any() ? this.Variants.Count() > 1 ? $"Starting at {this.Variants.Min(x => x.Price).ToString("C")}" : this.Variants.First().Price.ToString("C") : string.Empty;
            }
        }

        public ProductVariant GetSelectedVariant(int selectedTypeId)
        {
            var v =  this.Variants.FirstOrDefault(x => x.ProductTypeId == selectedTypeId);

            return v == null ? new ProductVariant() : v;
        }
    }
}
