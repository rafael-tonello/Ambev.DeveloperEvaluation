using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface ISaleProdRepository
{
    Task<SaleProd> CreateAsync(SaleProd branch, CancellationToken cancellationToken = default);

    Task<SaleProd?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<List<SaleProd>> GetSaleProds(Guid saleId , CancellationToken cancellationToken = default);

    Task<bool> DeleteSaleProdsAsync(Guid saleId, CancellationToken cancellationToken = default);

    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
