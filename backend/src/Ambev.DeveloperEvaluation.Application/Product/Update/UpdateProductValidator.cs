using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.Update
{
    public class UpdateProductCommandValidator: AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(Product => Product.Name).NotEmpty().MinimumLength(5).WithMessage("Name should have at least 5 characters");
            RuleFor(Product => Product.Price).GreaterThan(0);
        }
    }
}
