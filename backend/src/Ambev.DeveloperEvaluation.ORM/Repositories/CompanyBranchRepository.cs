using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ICompanyBranchRepository using Entity Framework Core
/// </summary>
public class CompanyBranchRepository : ICompanyBranchRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of CompanyBranchRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public CompanyBranchRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<CompanyBranch> CreateAsync(CompanyBranch branch, CancellationToken cancellationToken = default)
    {
        await _context.CompanyBranches.AddAsync(branch, cancellationToken);
        await _context.SaveChangesAsync();
        return branch;
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var companyBranch = await GetByIdAsync(id, cancellationToken);
        if (companyBranch == null)
            return false;

        _context.CompanyBranches.Remove(companyBranch);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<CompanyBranch?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.CompanyBranches.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    public async Task<List<CompanyBranch>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _context.CompanyBranches.ToListAsync(cancellationToken);
    }

    public Task<CompanyBranch> UpdateAsync(CompanyBranch branch, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
