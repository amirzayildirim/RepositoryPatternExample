using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Repository;
using RepositoryPatternExample.Infrastructure.Service;

namespace RepositoryPatternExample.Business.Service;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : EntityBase
{
    private readonly IBaseRepository<TEntity> _repository;

    public BaseService(IBaseRepository<TEntity> repository) => _repository = repository;

    public async Task<TEntity> AddAsync(TEntity entity) => await _repository.AddAsync(entity);

    public async Task DeleteByIdAsync(Guid id) => await _repository.DeleteByIdAsync(id);

    public async Task<IEnumerable<TEntity>> GetAllAsync() => await _repository.GetAllAsync();

    public async Task<TEntity?> GetByIdAsync(Guid id) => await _repository.GetByIdAsync(id);

    public async Task<TEntity> UpdateAsync(TEntity entity) => await _repository.UpdateAsync(entity);
}
