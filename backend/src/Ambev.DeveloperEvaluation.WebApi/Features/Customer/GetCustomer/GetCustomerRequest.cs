namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.GetCustomer;

/// <summary>
/// Request model for getting a user by ID
/// </summary>
public class GetCustomerRequest
{
    public Guid Id { get; set; }
}
