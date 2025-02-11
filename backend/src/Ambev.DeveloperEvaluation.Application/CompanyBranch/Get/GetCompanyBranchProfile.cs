using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Get
{
    public class GetCompanyBranchProfile: Profile
    {
        GetCompanyBranchProfile()
        {
            CreateMap<GetCompanyBranchCommand, Domain.Entities.CompanyBranch>();
            CreateMap<Domain.Entities.CompanyBranch, GetCompanyBranchCommand>();
        }
    }
}
