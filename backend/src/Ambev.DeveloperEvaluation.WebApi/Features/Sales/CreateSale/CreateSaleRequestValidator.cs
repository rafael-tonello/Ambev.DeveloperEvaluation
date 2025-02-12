using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleRequest that defines validation rules for Sale creation.
/// </summary>
public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    public CreateSaleRequestValidator()
    {
        RuleFor(Sale => Sale.CustomerId).NotEmpty().NotNull();
        RuleFor(Sale => Sale.CompanyBranchId).NotEmpty().NotNull();
        RuleFor(Sale => Sale.Items)
            .NotEmpty().WithMessage("At least one item is required")
            .Must(items => items != null && items.Count > 0).WithMessage("At least one item is required.");

    }
}