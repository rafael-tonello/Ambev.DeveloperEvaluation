using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sale.Update
{
    public class UpdateSaleCommandValidator: AbstractValidator<UpdateSaleCommand>
    {
        public UpdateSaleCommandValidator()
        {
            RuleFor(Sale => Sale.CustomerId).NotEmpty().NotNull();
            RuleFor(Sale => Sale.CompanyBranchId).NotEmpty().NotNull();
            RuleFor(Sale => Sale.Items)
                .NotEmpty().WithMessage("At least one item is required")
                .Must(items => items != null && items.Count > 0).WithMessage("At least one item is required.");
        }
    }
}
