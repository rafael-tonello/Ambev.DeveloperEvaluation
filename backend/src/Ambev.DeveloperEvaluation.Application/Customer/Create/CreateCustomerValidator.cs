using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.Create
{
    public class CreateCustomerCommandValidator: AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(Customer => Customer.Name).NotEmpty().MinimumLength(10).WithMessage("Name should have at least 10 characters");
        }
    }
}
