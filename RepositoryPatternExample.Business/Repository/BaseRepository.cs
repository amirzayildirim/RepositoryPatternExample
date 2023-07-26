using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Repository;

namespace RepositoryPatternExample.Business.Repository;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase
{
    private readonly DbContext _context;

    public BaseRepository(DbContext context) => this._context = context;

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await SaveAndChangesAsync();

        return entity;
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var data = await GetByIdAsync(id);
        if (data != null)
            _context.Set<TEntity>().Remove(data);
        await SaveAndChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync() => await _context.Set<TEntity>().AsNoTracking().ToListAsync();

    public async Task<TEntity?> GetByIdAsync(Guid id) => await _context.Set<TEntity>().Where(x => x.Id == id).FirstOrDefaultAsync();

    public async Task SaveAndChangesAsync() => await _context.SaveChangesAsync();

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (_context.Set<TEntity>().Entry(entity).State == EntityState.Modified)
            await SaveAndChangesAsync();

        return entity;
    }

}
