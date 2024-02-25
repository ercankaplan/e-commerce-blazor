using EcommerceBlazorShared.Models;

namespace EcommerceBlazorWebApp.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
