using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleRepository using Entity Framework Core
/// </summary>
public class SaleRepository : ISaleRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of SaleRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<Sale> CreateAsync(Sale branch, CancellationToken cancellationToken = default)
    {
        await _context.Sales.AddAsync(branch, cancellationToken);
        await _context.SaveChangesAsync();
        return branch;
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var Sale = await GetByIdAsync(id, cancellationToken);
        if (Sale == null)
            return false;

        _context.Sales.Remove(Sale);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    public async Task<List<Sale>> GetSales(CancellationToken cancellationToken = default)
    {
        return await _context.Sales.ToListAsync(cancellationToken);
    }

    public Task<Sale> UpdateAsync(Sale branch, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    
}
