using AutoMapper;
using Ambev.DeveloperEvaluation.Application.CompanyBranch.Create;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.CreateCompanyBranch;

/// <summary>
/// Profile for mapping between Application and API CreateCompanyBranch responses
/// </summary>
public class CreateCompanyBranchProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateCompanyBranch feature
    /// </summary>
    public CreateCompanyBranchProfile()
    {
        CreateMap<CreateCompanyBranchRequest, CreateCompanyBranchCommand>();
        CreateMap<CreateCompanyBranchResult, CreateCompanyBranchResponse>();
    }
}
