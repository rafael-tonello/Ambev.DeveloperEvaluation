using Ambev.DeveloperEvaluation.Application.Sale.Get;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.Delete
{

    
    public class DeleteSaleProfile: Profile
    {
        DeleteSaleProfile()
        {
            CreateMap<GetSaleCommand, Domain.Entities.Sale>();
            CreateMap<Domain.Entities.Sale, GetSaleCommand>();
        }
    }
}
