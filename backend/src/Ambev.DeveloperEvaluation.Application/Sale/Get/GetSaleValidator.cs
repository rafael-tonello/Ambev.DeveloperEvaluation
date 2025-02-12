using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sale.Get
{
    public class GetSaleCommandValidator: AbstractValidator<GetSaleCommand>
    {
        public GetSaleCommandValidator()
        {
            RuleFor(Sale => Sale.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
