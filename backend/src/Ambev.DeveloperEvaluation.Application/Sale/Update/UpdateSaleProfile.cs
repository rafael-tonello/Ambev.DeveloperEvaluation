using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.Update
{
    public class UpdateSaleProfile: Profile
    {
        UpdateSaleProfile()
        {
            CreateMap<UpdateSaleCommand, Domain.Entities.Sale>();
            CreateMap<Domain.Entities.Sale, UpdateSaleCommand>();
        }
    }
}
