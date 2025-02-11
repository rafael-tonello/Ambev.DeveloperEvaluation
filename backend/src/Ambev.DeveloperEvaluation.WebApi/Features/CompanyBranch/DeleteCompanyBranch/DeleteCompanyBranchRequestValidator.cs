using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.DeleteCompanyBranch;

/// <summary>
/// Validator for DeleteCompanyBranchRequest
/// </summary>
public class DeleteCompanyBranchRequestValidator : AbstractValidator<DeleteCompanyBranchRequest>
{
    /// <summary>
    /// Initializes validation rules for DeleteCompanyBranchRequest
    /// </summary>
    public DeleteCompanyBranchRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Company branch ID is required");
    }
}
