using Ambev.DeveloperEvaluation.Application.Product.Get;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.Delete
{

    
    public class DeleteProductProfile: Profile
    {
        DeleteProductProfile()
        {
            CreateMap<GetProductCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, GetProductCommand>();
        }
    }
}
