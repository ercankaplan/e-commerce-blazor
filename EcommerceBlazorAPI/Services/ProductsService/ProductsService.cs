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
            return await _dbContext.Products
                .Include(i => i.Variants)
                .ToListAsync();
        }
        public async Task<Product?> GetProductById(int id)
        {
            return await _dbContext.Products
                .Include(i=> i.Category)
                .Include(i=> i.Variants).ThenInclude(p=> p.ProductType)
                .FirstOrDefaultAsync(x=> x.Id == id);
        }

        public async Task<List<Product>> GetProductListByCategorySlug(string urlSlug)
        {
            var response =  await _dbContext.Products
                .Include(i => i.Category)
               .Include(i => i.Variants).ThenInclude(p => p.ProductType)
               .Where(x=> x.Category.Url.ToLower().Equals(urlSlug.ToLower())).ToListAsync();

            return response;
        }
    }
}
