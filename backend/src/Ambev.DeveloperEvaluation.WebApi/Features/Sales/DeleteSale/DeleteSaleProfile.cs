using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale;

public class DeleteSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for Delete Sale feature
    /// </summary>
    public DeleteSaleProfile()
    {
        CreateMap<Guid, Application.Sale.Delete.DeleteSaleCommand>()
            .ConstructUsing(id => new Application.Sale.Delete.DeleteSaleCommand { Id = id });
    }
}
