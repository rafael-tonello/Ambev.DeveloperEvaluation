using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.CreateCustomer;

/// <summary>
/// Represents a request to create a new Customer in the system.
/// </summary>
public class CreateCustomerRequest
{
    /// <summary>
    /// Gets or sets the Customername.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    public string Description { get; set; } = "";

    /// <summary>
    /// Gets or sets the Customer Price. Customer price is valid if it is greater than 0.
    /// </summary>
    public double Price { get; set; }
}