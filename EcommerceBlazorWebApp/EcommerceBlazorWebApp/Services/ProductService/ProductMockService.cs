using EcommerceBlazorShared.Models;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public class ProductMockService : IProductService
    {
        public Task<ServiceResponse<Product>> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Product>>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
