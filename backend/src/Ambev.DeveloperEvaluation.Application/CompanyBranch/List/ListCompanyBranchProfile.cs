using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.List
{
    public class ListCompanyBranchProfile: Profile
    {
        ListCompanyBranchProfile()
        {
            CreateMap<ListCompanyBranchCommand, Domain.Entities.CompanyBranch>();
            CreateMap<Domain.Entities.CompanyBranch, ListCompanyBranchCommand>();
        }
    }
}
