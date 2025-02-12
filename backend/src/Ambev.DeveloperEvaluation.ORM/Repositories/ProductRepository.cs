using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of IProductRepository using Entity Framework Core
/// </summary>
public class ProductRepository : IProductRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of ProductRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public ProductRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<Product> CreateAsync(Product branch, CancellationToken cancellationToken = default)
    {
        await _context.Products.AddAsync(branch, cancellationToken);
        await _context.SaveChangesAsync();
        return branch;
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var Product = await GetByIdAsync(id, cancellationToken);
        if (Product == null)
            return false;

        _context.Products.Remove(Product);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Products.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    public Task<Product> UpdateAsync(Product branch, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    async Task<List<Product>> IProductRepository.SearchByName(string name, CancellationToken cancellationToken)
    {
        return await _context.Products.Where(i => i.Name.ToUpper().Contains(name.ToUpper())).ToListAsync(cancellationToken);
    }
}
