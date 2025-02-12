using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.Create
{
    public class CreateCustomerProfile: Profile
    {
        CreateCustomerProfile()
        {
            CreateMap<CreateCustomerCommand, Domain.Entities.Customer>();
            CreateMap<Domain.Entities.Customer, CreateCustomerCommand>();
        }
    }
}
