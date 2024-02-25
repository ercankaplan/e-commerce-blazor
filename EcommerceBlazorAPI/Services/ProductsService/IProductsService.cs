using EcommerceBlazorAPI.Model;

namespace EcommerceBlazorAPI.Services.ProductsService
{
    public interface IProductsService
    {
        Task<List<Product>> GetPrductList();
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetProductListByCategorySlug(string urlSlug);
    }
}
