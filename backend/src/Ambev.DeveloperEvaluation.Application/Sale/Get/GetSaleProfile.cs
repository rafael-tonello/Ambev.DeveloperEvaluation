using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.Get
{
    public class GetSaleProfile: Profile
    {
        GetSaleProfile()
        {
            CreateMap<GetSaleCommand, Domain.Entities.Sale>();
            CreateMap<Domain.Entities.Sale, GetSaleCommand>();
        }
    }
}
