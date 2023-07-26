using RepositoryPatternExample.Data.Entities;

namespace RepositoryPatternExample.Infrastructure.Repository;

public interface IBaseRepository<T> where T : EntityBase
{
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<T?> GetByIdAsync(Guid id);
    public Task DeleteByIdAsync(Guid id);
    public Task<T> UpdateAsync(T entity);
    public Task<T> AddAsync(T entity);
    public Task SaveAndChangesAsync();

}
