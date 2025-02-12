using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.Delete
{
    public class DeleteProductCommandValidator: AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(Product => Product.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
