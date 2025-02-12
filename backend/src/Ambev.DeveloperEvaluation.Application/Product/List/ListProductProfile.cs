using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.List
{
    public class ListProductProfile: Profile
    {
        ListProductProfile()
        {
            CreateMap<ListProductCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, ListProductCommand>();
        }
    }
}
