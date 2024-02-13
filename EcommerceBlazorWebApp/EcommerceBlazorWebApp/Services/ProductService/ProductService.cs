using EcommerceBlazorShared.Models;
using EcommerceBlazorWebApp.Helpers;
using EcommerceBlazorWebApp.Services.RequestProvider;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IHttpRequestProvider _httpRequestProvider;

        public ProductService(IHttpRequestProvider httpRequestProvider)
        {
            _httpRequestProvider = httpRequestProvider;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var uri = UriHelper.CombineUri(GlobalSetting.Instance.ProductsEndpoint);
      
            var response = await _httpRequestProvider.GetAsync<ServiceResponse<List<Product>>>(uri);

            return response;
        }
        public async Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var uri = UriHelper.CombineUri(GlobalSetting.Instance.ProductsEndpoint,$"/{id}");

            var response = await _httpRequestProvider.GetAsync<ServiceResponse<Product>>(uri);

            return response;
        }
    }
}
