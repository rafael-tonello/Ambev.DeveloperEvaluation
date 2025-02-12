using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleProdRepository using Entity Framework Core
/// </summary>
public class SaleProdRepository : ISaleProdRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of SaleProdRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleProdRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<SaleProd> CreateAsync(SaleProd branch, CancellationToken cancellationToken = default)
    {
        await _context.SaleProds.AddAsync(branch, cancellationToken);
        await _context.SaveChangesAsync();
        return branch;
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var SaleProd = await GetByIdAsync(id, cancellationToken);
        if (SaleProd == null)
            return false;

        _context.SaleProds.Remove(SaleProd);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<SaleProd?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.SaleProds.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    public async Task<List<SaleProd>> GetSaleProds(Guid saleId, CancellationToken cancellationToken = default)
    {
        return await _context.SaleProds.Where(i => i.SaleId == saleId).ToListAsync(cancellationToken);
    }

    public async Task<bool> DeleteSaleProdsAsync(Guid saleId, CancellationToken cancellationToken = default)
    {
        var items = await GetSaleProds(saleId, cancellationToken);
        foreach (var item in items)
        {
            await DeleteAsync(item.Id, cancellationToken);
        }

        return true;
    }

    
}
