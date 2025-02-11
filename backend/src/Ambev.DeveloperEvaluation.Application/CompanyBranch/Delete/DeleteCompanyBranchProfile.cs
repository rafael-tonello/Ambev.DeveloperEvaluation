using Ambev.DeveloperEvaluation.Application.CompanyBranch.Get;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Delete
{

    
    public class DeleteCompanyBranchProfile: Profile
    {
        DeleteCompanyBranchProfile()
        {
            CreateMap<GetCompanyBranchCommand, Domain.Entities.CompanyBranch>();
            CreateMap<Domain.Entities.CompanyBranch, GetCompanyBranchCommand>();
        }
    }
}
