using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.Delete
{
    public class DeleteCustomerCommandValidator: AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            RuleFor(Customer => Customer.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
