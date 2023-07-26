using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Data.Entities;
using RepositoryPatternExample.Infrastructure.Repository;
using RepositoryPatternExample.Infrastructure.Service;

namespace RepositoryPatternExample.Business.Service;

public class CategoryService : BaseService<Category>, ICategoryService {

    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository) => _categoryRepository = categoryRepository;

    public async Task<Category?> GetByName(string name) => await _categoryRepository.GetByName(name);
}

