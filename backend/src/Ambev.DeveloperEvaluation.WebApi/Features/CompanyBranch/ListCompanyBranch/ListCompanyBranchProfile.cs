using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.ListCompanyBranch;

/// <summary>
/// Profile for mapping ListCompanyBranch feature requests to commands
/// </summary>
public class ListCompanyBranchProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListCompanyBranch feature
    /// </summary>
    public ListCompanyBranchProfile()
    {
        CreateMap<Guid, Application.CompanyBranch.List.ListCompanyBranchCommand>()
            .ConstructUsing(id => new Application.CompanyBranch.List.ListCompanyBranchCommand());
    }
}
