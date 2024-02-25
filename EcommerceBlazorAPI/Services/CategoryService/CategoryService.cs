
using EcommerceBlazorAPI.Infrastructure;

namespace EcommerceBlazorAPI.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ECommerceDBContext _context;
        public CategoryService(ECommerceDBContext context) 
        { 
          _context = context;
        }
        public async Task<IList<Category>> GetAllCategories()
        {
           return  await _context.Categories.ToListAsync();
        }
    }
}
