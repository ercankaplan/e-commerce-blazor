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

        public async Task<List<Product>> GetProducts()
        {
            var uri = UriHelper.CombineUri(GlobalSetting.Instance.ProductsEndpoint);

            var list = await _httpRequestProvider.GetAsync<List<Product>>(uri);

            return list;
        }
    }
}
