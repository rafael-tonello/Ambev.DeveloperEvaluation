using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSale;

/// <summary>
/// Profile for mapping ListSale feature requests to commands
/// </summary>
public class ListSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListSale feature
    /// </summary>
    public ListSaleProfile()
    {
        CreateMap<ListSaleRequest, Application.Sale.List.ListSaleCommand>()
            .ConstructUsing(tmp => new Application.Sale.List.ListSaleCommand());
    }
}
