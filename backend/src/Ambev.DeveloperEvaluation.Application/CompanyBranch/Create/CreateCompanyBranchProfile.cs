using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Create
{
    public class CreateCompanyBranchProfile: Profile
    {
        CreateCompanyBranchProfile()
        {
            CreateMap<CreateCompanyBranchCommand, Domain.Entities.CompanyBranch>();
            CreateMap<Domain.Entities.CompanyBranch, CreateCompanyBranchCommand>();
        }
    }
}
