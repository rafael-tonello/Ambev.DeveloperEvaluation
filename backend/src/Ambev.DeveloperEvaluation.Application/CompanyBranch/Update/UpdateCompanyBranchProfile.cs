using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Update
{
    public class UpdateCompanyBranchProfile: Profile
    {
        UpdateCompanyBranchProfile()
        {
            CreateMap<UpdateCompanyBranchCommand, Domain.Entities.CompanyBranch>();
            CreateMap<Domain.Entities.CompanyBranch, UpdateCompanyBranchCommand>();
        }
    }
}
