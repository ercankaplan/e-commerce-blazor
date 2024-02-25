using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EcommerceBlazorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        [HttpGet]
        [SwaggerResponse(200, Type = typeof(ApiResponse<IEnumerable<Category>>))]
        [SwaggerOperation(Summary = "CategoryList", Description = "Gets CategoryList", OperationId = "CategoryList")]
        public async Task<IActionResult> Get() 
        {

            var allCategories = await _categoryService.GetAllCategories();
            if (!allCategories.Any())
                return NotFound();

            return Ok(new ApiResponse<IEnumerable<Category>>() { Data = allCategories });
        }
    }
}
