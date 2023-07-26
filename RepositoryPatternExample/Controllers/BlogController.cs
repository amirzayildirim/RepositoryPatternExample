using Microsoft.AspNetCore.Mvc;
using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Service;

namespace RepositoryPatternExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _BlogService;

        public BlogController(IBlogService BlogService) => _BlogService = BlogService;

        [HttpGet("Get")]
        public async Task<IEnumerable<Blog>> Get() => await _BlogService.GetAllAsync();

        [HttpPost("Add")]
        public async Task<Blog> Add(Blog model) => await _BlogService.AddAsync(model);

        [HttpPut("Update")]
        public async Task<Blog> Update(Blog model) => await _BlogService.UpdateAsync(model);

        [HttpDelete("Delete")]
        public async Task Delete([FromBody] Guid id) => await _BlogService.DeleteByIdAsync(id);

        [HttpPost("GetById")]
        public async Task<Blog?> Get([FromBody] Guid id) => await _BlogService.GetByIdAsync(id);

    }
}
