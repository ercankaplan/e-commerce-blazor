using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceBlazorAPI.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;


        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;
    }
}
