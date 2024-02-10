using EcommerceBlazorShared.Models;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public class ProductMockService : IProductService
    {
        public Task<ServiceResponse<List<Product>>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
