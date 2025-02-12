using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Represents a request to create a new Sale in the system.
/// </summary>
public class CreateSaleRequest
{
    public DateTime DateTime { get; set; }

    public Guid CompanyBranchId { get; set; }

    public Guid CustomerId { get; set; }

    public bool Cancelled { get; set; }

    //TODO: change it to use a DTO
    public virtual required List<SaleProd> Items { get; set; }

}