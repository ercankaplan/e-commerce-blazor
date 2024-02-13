using EcommerceBlazorAPI.Infrastructure;
using EcommerceBlazorAPI.Model;

namespace EcommerceBlazorAPI.Services.ProductsService
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
        public async Task<Product> GetProductById(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }
    }
}
