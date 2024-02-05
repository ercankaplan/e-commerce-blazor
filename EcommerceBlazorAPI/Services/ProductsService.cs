using EcommerceBlazorAPI.Infrastructure;

namespace EcommerceBlazorAPI.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ECommerceDBContext _dbContext;
        public ProductsService(ECommerceDBContext context) 
        {
            _dbContext = context;
        }

        public async Task<List<Product>> GetPrductList()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
