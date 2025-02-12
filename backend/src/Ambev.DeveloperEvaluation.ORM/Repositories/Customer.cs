using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ICustomerRepository using Entity Framework Core
/// </summary>
public class CustomerRepository : ICustomerRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of CustomerRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public CustomerRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<Customer> CreateAsync(Customer branch, CancellationToken cancellationToken = default)
    {
        await _context.Customers.AddAsync(branch, cancellationToken);
        await _context.SaveChangesAsync();
        return branch;
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var Customer = await GetByIdAsync(id, cancellationToken);
        if (Customer == null)
            return false;

        _context.Customers.Remove(Customer);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Customers.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    public Task<Customer> UpdateAsync(Customer branch, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Customer>> SearchByName(string name, CancellationToken cancellationToken)
    {
        return await _context.Customers.Where(i => i.Name.ToUpper().Contains(name.ToUpper())).ToListAsync(cancellationToken);
    }
}
