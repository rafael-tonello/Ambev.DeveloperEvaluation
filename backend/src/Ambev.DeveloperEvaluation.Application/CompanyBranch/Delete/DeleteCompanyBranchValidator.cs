using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Delete
{
    public class DeleteCompanyBranchCommandValidator: AbstractValidator<DeleteCompanyBranchCommand>
    {
        public DeleteCompanyBranchCommandValidator()
        {
            RuleFor(companyBranch => companyBranch.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
