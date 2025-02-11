using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.CreateCompanyBranch;

/// <summary>
/// Validator for CreateCompanyBranchRequest that defines validation rules for CompanyBranch creation.
/// </summary>
public class CreateCompanyBranchRequestValidator : AbstractValidator<CreateCompanyBranchRequest>
{
    public CreateCompanyBranchRequestValidator()
    {
        RuleFor(CompanyBranch => CompanyBranch.Name).MinimumLength(5);
        RuleFor(CompanyBranch => CompanyBranch.Address).MinimumLength(10);
    }
}