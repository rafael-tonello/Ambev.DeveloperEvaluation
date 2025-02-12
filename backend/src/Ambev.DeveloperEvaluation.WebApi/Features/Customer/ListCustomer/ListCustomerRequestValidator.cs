using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.ListCustomer;

/// <summary>
/// Validator for ListCustomerRequest
/// </summary>
public class ListCustomerRequestValidator : AbstractValidator<ListCustomerRequest>
{
    /// <summary>
    /// Initializes validation rules for ListCustomerRequest
    /// </summary>
    public ListCustomerRequestValidator()
    {
        
    }
}
