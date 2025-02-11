using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.GetCompanyBranch;

/// <summary>
/// Profile for mapping GetCompanyBranch feature requests to commands
/// </summary>
public class GetCompanyBranchProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetCompanyBranch feature
    /// </summary>
    public GetCompanyBranchProfile()
    {
        CreateMap<Guid, Application.CompanyBranch.Get.GetCompanyBranchCommand>()
            .ConstructUsing(id => new Application.CompanyBranch.Get.GetCompanyBranchCommand { Id = id });
    }
}
