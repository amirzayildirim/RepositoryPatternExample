using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Data.Context;
using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Repository;

namespace RepositoryPatternExample.Business.Repository;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    private readonly MyCustomDbContext _customDbContext;

    public CategoryRepository(MyCustomDbContext customDbContext) : base(customDbContext) => _customDbContext = customDbContext;

    public async Task<Category?> GetByName(string name) => await _customDbContext.Set<Category>().FirstOrDefaultAsync(o => o.Name.ToLower() == name.ToLower());
}
