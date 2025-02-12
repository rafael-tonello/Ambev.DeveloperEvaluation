using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.Create
{
    public class CreateProductCommandValidator: AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(Product => Product.Name).NotEmpty().MinimumLength(5).WithMessage("Company branch name should have at least 5 characters");
            RuleFor(Product => Product.Price).GreaterThan(0);
        }
    }
}
