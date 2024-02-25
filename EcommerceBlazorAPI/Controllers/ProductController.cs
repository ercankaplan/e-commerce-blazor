using EcommerceBlazorAPI.Model;
using EcommerceBlazorAPI.Services.ProductsService;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EcommerceBlazorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProductsService _productsService;

        public ProductController(ILogger<ProductController> logger, IProductsService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        //[HttpGet("ProductList")]
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(ApiResponse<IEnumerable<Product>>))]
        [SwaggerOperation(Summary = "ProductList", Description = "Gets ProductList", OperationId = "ProductList")]
        public async Task<IActionResult> GetProductList()
        {
            var productList = await _productsService.GetPrductList();
            if (!productList.Any())
                NotFound();

            var result = new ApiResponse<IEnumerable<Product>>() { Data = productList };

            return Ok(result);
        }



        //[HttpGet("/ForeignProduct/{id}")]
        //[Route("/ForeignProduct/{id}")]
        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(ApiResponse<Product>))]
        [SwaggerOperation(Summary = "ProductDetail", Description = "Gets Product Details by id", OperationId = "ProductDetails")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productsService.GetProductById(id);
      
            var result = new ApiResponse<Product>() { Data = product, Success = (product is not null) , Message = product is null  ? "Product not found": string.Empty};

            return Ok(result);
        }

        [HttpGet("category/{urlslug}")]
        [SwaggerResponse(200, Type = typeof(ApiResponse<List<Product>>))]
        [SwaggerOperation(Summary = "Product List Of Category ", Description = "Gets Product List by category url", OperationId = "ProductListofCategory")]
        public async Task<IActionResult> GetProductListByCategorySlug(string urlslug)
        {
            var product = await _productsService.GetProductListByCategorySlug(urlslug);

            var result = new ApiResponse<List<Product>>() { Data = product, Success = (product is not null), Message = product is null ? "Product not found" : string.Empty };

            return Ok(result);
        }

    }
}
