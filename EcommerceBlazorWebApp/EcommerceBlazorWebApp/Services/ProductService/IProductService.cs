using EcommerceBlazorShared.Models;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProducts();
    }
}
