using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.DeleteCompanyBranch;

public class DeleteCompanyBranchProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for Delete Company Branch feature
    /// </summary>
    public DeleteCompanyBranchProfile()
    {
        CreateMap<Guid, Application.CompanyBranch.Delete.DeleteCompanyBranchCommand>()
            .ConstructUsing(id => new Application.CompanyBranch.Delete.DeleteCompanyBranchCommand { Id = id });
    }
}
