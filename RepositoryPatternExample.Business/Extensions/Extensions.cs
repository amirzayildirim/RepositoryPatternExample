using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternExample.Business.Repository;
using RepositoryPatternExample.Business.Service;
using RepositoryPatternExample.Data.Context;
using RepositoryPatternExample.Infrastructure.Repository;
using RepositoryPatternExample.Infrastructure.Service;

namespace RepositoryPatternExample.Business.Extensions;

public static class Extensions
{
    public static IServiceCollection AddServicesAndRepositoryInjection(this IServiceCollection services)
    {
        //repositories
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IBlogRepository, BlogRepository>();

        //services
        services.AddTransient<IBlogService, BlogService>();
        services.AddTransient<ICategoryService, CategoryService>();

        return services;

    }

    public static IServiceCollection AddDbContextInjection(this IServiceCollection services) => services.AddDbContext<MyCustomDbContext>();
}
