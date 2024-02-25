using EcommerceBlazorShared.Models;
using EcommerceBlazorWebApp.Helpers;
using EcommerceBlazorWebApp.Services.RequestProvider;

namespace EcommerceBlazorWebApp.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IHttpRequestProvider _httpRequestProvider;

        public List<Product>? Products { get ; set ; }

        public event Action ProductListChanged;

        public ProductService(IHttpRequestProvider httpRequestProvider)
        {
            _httpRequestProvider = httpRequestProvider;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts(string? urlSlug = null)
        {

            var uri = UriHelper.CombineUri(GlobalSetting.Instance.ProductsEndpoint);

            if (urlSlug is not null)
                uri = $"{GlobalSetting.Instance.ProductsByCategoryEndpoint}{urlSlug}";

            var response = await _httpRequestProvider.GetAsync<ServiceResponse<List<Product>>>(uri);

            this.Products = response.Success ? response.Data : null;

            ProductListChanged.Invoke();
            
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
