using RepositoryPatternExample.Data.Entities;

namespace RepositoryPatternExample.Infrastructure.Service;

public interface IBaseService<TEntity> where TEntity : EntityBase 
{
    public Task<IEnumerable <TEntity>> GetAllAsync();
    public Task<TEntity?> GetByIdAsync(Guid id);
    public Task DeleteByIdAsync(Guid id);
    public Task<TEntity> UpdateAsync(TEntity entity);
    public Task<TEntity> AddAsync(TEntity entity);
}
