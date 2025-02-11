using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Create
{
    public class CreateCompanyBranchCommandValidator: AbstractValidator<CreateCompanyBranchCommand>
    {
        public CreateCompanyBranchCommandValidator()
        {
            RuleFor(companyBranch => companyBranch.Name).NotEmpty().MinimumLength(5).WithMessage("Company branch name should have at least 5 characters");
            RuleFor(companyBranch => companyBranch.Address).NotEmpty().MinimumLength(10).WithMessage("Company branch address should have at least 10 characters");
        }
    }
}
