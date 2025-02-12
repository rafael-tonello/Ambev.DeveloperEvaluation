using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.Get
{
    public class GetProductProfile: Profile
    {
        GetProductProfile()
        {
            CreateMap<GetProductCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, GetProductCommand>();
        }
    }
}
