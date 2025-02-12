using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.Update
{
    public class UpdateCustomerCommandValidator: AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(Customer => Customer.Name).NotEmpty().MinimumLength(10).WithMessage("Name should have at least 10 characters");
        }
    }
}
