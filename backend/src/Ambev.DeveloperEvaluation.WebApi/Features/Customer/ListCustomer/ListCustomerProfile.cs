using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.ListCustomer;

/// <summary>
/// Profile for mapping ListCustomer feature requests to commands
/// </summary>
public class ListCustomerProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListCustomer feature
    /// </summary>
    public ListCustomerProfile()
    {
        CreateMap<ListCustomerRequest, Application.Customer.List.ListCustomerCommand>()
            .ConstructUsing(tmp => new Application.Customer.List.ListCustomerCommand { Name = tmp.Name });
    }
}
