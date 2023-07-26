using RepositoryPatternExample.Data.Entities;

namespace RepositoryPatternExample.Infrastructure.Service;

public interface ICategoryService : IBaseService<Category>
{
    //custom method example
    Task<Category?> GetByName(string name);
}
