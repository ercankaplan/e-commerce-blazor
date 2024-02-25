namespace EcommerceBlazorAPI.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<IList<Category>> GetAllCategories();
    }
}
