using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.List
{
    public class ListCustomerProfile: Profile
    {
        ListCustomerProfile()
        {
            CreateMap<ListCustomerCommand, Domain.Entities.Customer>();
            CreateMap<Domain.Entities.Customer, ListCustomerCommand>();
        }
    }
}
