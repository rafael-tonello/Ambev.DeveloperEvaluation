using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// API response model for CreateProduct operation
/// </summary>
public class CreateProductResponse
{
    /// <summary>
    /// The unique identifier of the created Product
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Product's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The Product's description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    public double Price { get; set; }


}
