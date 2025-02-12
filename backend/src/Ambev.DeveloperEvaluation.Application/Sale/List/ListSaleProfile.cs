using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.List
{
    public class ListSaleProfile: Profile
    {
        ListSaleProfile()
        {
            CreateMap<ListSaleCommand, Domain.Entities.Sale>();
            CreateMap<Domain.Entities.Sale, ListSaleCommand>();
        }
    }
}
