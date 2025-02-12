using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// API response model for CreateSale operation
/// </summary>
public class CreateSaleResponse
{
    public DateTime DateTime { get; set; }

    public double GrossValue { get; set; }

    public double TotalDiscount { get; set; }

    public double FinalValue { get; set; }

    public Guid CompanyBranchId { get; set; }

    public Guid CustomerId { get; set; }

    public bool Cancelled { get; set; }

    public virtual List<SaleProd> Items { get; set; }

}
