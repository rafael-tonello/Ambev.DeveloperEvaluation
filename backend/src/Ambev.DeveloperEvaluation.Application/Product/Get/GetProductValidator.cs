using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.Get
{
    public class GetProductCommandValidator: AbstractValidator<GetProductCommand>
    {
        public GetProductCommandValidator()
        {
            RuleFor(Product => Product.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
