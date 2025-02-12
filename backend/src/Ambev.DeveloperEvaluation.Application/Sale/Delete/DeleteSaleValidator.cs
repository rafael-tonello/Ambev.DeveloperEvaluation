using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sale.Delete
{
    public class DeleteSaleCommandValidator: AbstractValidator<DeleteSaleCommand>
    {
        public DeleteSaleCommandValidator()
        {
            RuleFor(Sale => Sale.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
