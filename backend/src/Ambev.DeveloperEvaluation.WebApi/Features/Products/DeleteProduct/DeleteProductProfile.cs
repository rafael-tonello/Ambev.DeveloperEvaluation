using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct;

public class DeleteProductProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for Delete Company Branch feature
    /// </summary>
    public DeleteProductProfile()
    {
        CreateMap<Guid, Application.Product.Delete.DeleteProductCommand>()
            .ConstructUsing(id => new Application.Product.Delete.DeleteProductCommand { Id = id });
    }
}
