using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.Update
{
    public class UpdateProductProfile: Profile
    {
        UpdateProductProfile()
        {
            CreateMap<UpdateProductCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, UpdateProductCommand>();
        }
    }
}
