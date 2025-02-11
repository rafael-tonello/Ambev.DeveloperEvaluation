using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Get
{
    public class GetCompanyBranchCommandValidator: AbstractValidator<GetCompanyBranchCommand>
    {
        public GetCompanyBranchCommandValidator()
        {
            RuleFor(companyBranch => companyBranch.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
