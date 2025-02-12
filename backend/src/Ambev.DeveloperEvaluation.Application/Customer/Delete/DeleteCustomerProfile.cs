using Ambev.DeveloperEvaluation.Application.Customer.Get;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.Delete
{

    
    public class DeleteCustomerProfile: Profile
    {
        DeleteCustomerProfile()
        {
            CreateMap<GetCustomerCommand, Domain.Entities.Customer>();
            CreateMap<Domain.Entities.Customer, GetCustomerCommand>();
        }
    }
}
