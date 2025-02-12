using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.GetCompanyBranch;

/// <summary>
/// Validator for GetCompanyBranchRequest
/// </summary>
public class GetCompanyBranchRequestValidator : AbstractValidator<GetCompanyBranchRequest>
{
    /// <summary>
    /// Initializes validation rules for GetCompanyBranchRequest
    /// </summary>
    public GetCompanyBranchRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("ID is required");
    }
}
