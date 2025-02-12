using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customers.DeleteCustomer;

public class DeleteCustomerProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for Delete Company Branch feature
    /// </summary>
    public DeleteCustomerProfile()
    {
        CreateMap<Guid, Application.Customer.Delete.DeleteCustomerCommand>()
            .ConstructUsing(id => new Application.Customer.Delete.DeleteCustomerCommand { Id = id });
    }
}
