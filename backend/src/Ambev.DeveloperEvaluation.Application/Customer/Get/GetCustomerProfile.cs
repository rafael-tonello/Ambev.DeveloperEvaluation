using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.Get
{
    public class GetCustomerProfile: Profile
    {
        GetCustomerProfile()
        {
            CreateMap<GetCustomerCommand, Domain.Entities.Customer>();
            CreateMap<Domain.Entities.Customer, GetCustomerCommand>();
        }
    }
}
