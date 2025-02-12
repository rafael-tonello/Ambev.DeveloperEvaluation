using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.Create
{
    public class CreateProductProfile: Profile
    {
        CreateProductProfile()
        {
            CreateMap<CreateProductCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, CreateProductCommand>();
        }
    }
}
