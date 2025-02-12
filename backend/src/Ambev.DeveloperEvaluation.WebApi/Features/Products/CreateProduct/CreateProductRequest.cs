using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Represents a request to create a new Product in the system.
/// </summary>
public class CreateProductRequest
{
    /// <summary>
    /// Gets or sets the Productname.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    public string Description { get; set; } = "";

    /// <summary>
    /// Gets or sets the product Price. Product price is valid if it is greater than 0.
    /// </summary>
    public double Price { get; set; }
}