using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sale.Create
{
    public class CreateSaleProfile: Profile
    {
        CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, Domain.Entities.Sale>();
            CreateMap<Domain.Entities.Sale, CreateSaleCommand>();
        }
    }
}
