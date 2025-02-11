using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for User entity operations
/// </summary>
public interface ICompanyBranchRepository
{
    Task<CompanyBranch> CreateAsync(CompanyBranch branch, CancellationToken cancellationToken = default);

    Task<CompanyBranch?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<CompanyBranch> UpdateAsync(CompanyBranch branch, CancellationToken cancellationToken = default);

    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
}
