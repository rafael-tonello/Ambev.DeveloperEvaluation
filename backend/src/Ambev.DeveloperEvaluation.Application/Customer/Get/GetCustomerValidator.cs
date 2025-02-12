using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.Get
{
    public class GetCustomerCommandValidator: AbstractValidator<GetCustomerCommand>
    {
        public GetCustomerCommandValidator()
        {
            RuleFor(Customer => Customer.Id).NotNull().NotEmpty().WithMessage("Id cannot be empty");
        }
    }
}
