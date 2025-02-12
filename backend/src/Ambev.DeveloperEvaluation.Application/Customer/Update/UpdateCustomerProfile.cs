using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.Update
{
    public class UpdateCustomerProfile: Profile
    {
        UpdateCustomerProfile()
        {
            CreateMap<UpdateCustomerCommand, Domain.Entities.Customer>();
            CreateMap<Domain.Entities.Customer, UpdateCustomerCommand>();
        }
    }
}
