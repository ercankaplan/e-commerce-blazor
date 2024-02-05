using EcommerceBlazorShared.Models;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
    }
}
