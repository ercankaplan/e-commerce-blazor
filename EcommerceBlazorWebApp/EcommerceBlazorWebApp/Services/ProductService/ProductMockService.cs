using EcommerceBlazorShared.Models;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public class ProductMockService : IProductService
    {
        public List<Product>? Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action ProductListChanged;

        public Task<ServiceResponse<Product>> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Product>>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Product>>> GetProducts(string? urlSlug = null)
        {
            throw new NotImplementedException();
        }
    }
}
