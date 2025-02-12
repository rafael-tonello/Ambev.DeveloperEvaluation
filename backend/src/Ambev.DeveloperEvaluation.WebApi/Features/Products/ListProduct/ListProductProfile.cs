using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProduct;

/// <summary>
/// Profile for mapping ListProduct feature requests to commands
/// </summary>
public class ListProductProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListProduct feature
    /// </summary>
    public ListProductProfile()
    {
        CreateMap<ListProductRequest, Application.Product.List.ListProductCommand>()
            .ConstructUsing(tmp => new Application.Product.List.ListProductCommand { Name = tmp.Name });
    }
}
