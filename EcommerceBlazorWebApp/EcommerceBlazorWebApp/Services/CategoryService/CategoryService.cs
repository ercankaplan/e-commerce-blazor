

namespace EcommerceBlazorWebApp.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpRequestProvider _httpRequestProvider;

        public CategoryService(IHttpRequestProvider httpRequestProvider)
        {
            this._httpRequestProvider = httpRequestProvider;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {

            var response = await _httpRequestProvider.GetAsync<ServiceResponse<List<Category>>>(GlobalSetting.Instance.CategoriesEndpoint);

            return response;

        }
    }
}
