using RepositoryPatternExample.Data.Entities;

namespace RepositoryPatternExample.Infrastructure.Repository;

public interface ICategoryRepository:IBaseRepository<Category>
{
    //custom method example
    Task<Category?> GetByName(string name);
}
