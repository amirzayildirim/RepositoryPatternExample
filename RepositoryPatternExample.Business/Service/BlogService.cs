using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Repository;
using RepositoryPatternExample.Infrastructure.Service;

namespace RepositoryPatternExample.Business.Service;

public class BlogService : BaseService<Blog>, IBlogService
{
    public BlogService(IBlogRepository repository) : base(repository)
    {
    }
}
