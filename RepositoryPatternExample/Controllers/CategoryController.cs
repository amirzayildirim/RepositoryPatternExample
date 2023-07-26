using Microsoft.AspNetCore.Mvc;
using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Service;

namespace RepositoryPatternExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;

        [HttpGet("Get")]
        public async Task<IEnumerable<Category>> Get() => await _categoryService.GetAllAsync();

        [HttpPost("Add")]
        public async Task<Category> Add(Category model) => await _categoryService.AddAsync(model);

        [HttpPut("Update")]
        public async Task<Category> Update(Category model) => await _categoryService.UpdateAsync(model);

        [HttpDelete("Delete")]
        public async Task Delete([FromBody] Guid id) => await _categoryService.DeleteByIdAsync(id);

        [HttpPost("Get")]
        public async Task<Category?> Get([FromQuery] string name) => await _categoryService.GetByName(name);

        [HttpPost("GetById")]
        public async Task<Category?> Get([FromBody] Guid id) => await _categoryService.GetByIdAsync(id);

    }
}
