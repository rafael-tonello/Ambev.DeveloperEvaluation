using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.Delete
{
    public class DeleteCustomerCommand: IRequest<DeleteCustomerResult>
    {
        public Guid Id { get; set; }
        
        public ValidationResultDetail Validate()
        {
            var result = new DeleteCustomerCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
