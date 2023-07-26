using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Data.Entities;

namespace RepositoryPatternExample.Data.Context;

public class MyCustomDbContext : DbContext
{
    public MyCustomDbContext(DbContextOptions<MyCustomDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase(databaseName: "RepositoryPatternDatabase");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) => base.OnModelCreating(modelBuilder);

    public DbSet<Category> Categories { get; set; }
    public DbSet<Blog> Blogs { get; set; }

}
