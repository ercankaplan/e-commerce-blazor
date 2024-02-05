namespace EcommerceBlazorAPI.Services
{
    public interface IProductsService
    {
        Task<List<Product>> GetPrductList();
    }
}
