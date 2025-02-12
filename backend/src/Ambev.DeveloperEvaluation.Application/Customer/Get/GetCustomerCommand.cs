using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.Get
{
    public class GetCustomerCommand: IRequest<GetCustomerResult>
    {
        public Guid Id { get; set; }

        public ValidationResultDetail Validate()
        {
            var result = new GetCustomerCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
