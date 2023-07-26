using RepositoryPatternExample.Data.Context;
using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Repository;

namespace RepositoryPatternExample.Business.Repository;

public class BlogRepository : BaseRepository<Blog>, IBlogRepository
{
    public BlogRepository(MyCustomDbContext customDbContext) : base(customDbContext)
    {
    }
}
