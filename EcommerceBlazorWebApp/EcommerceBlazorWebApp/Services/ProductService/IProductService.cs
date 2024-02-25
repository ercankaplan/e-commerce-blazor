using EcommerceBlazorShared.Models;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public interface IProductService
    {
        List<Product>? Products { get; set; }

        event Action ProductListChanged;
        Task<ServiceResponse<List<Product>>> GetProducts(string? urlSlug = null);
        Task<ServiceResponse<Product>> GetProductById(int id);

    }
}
