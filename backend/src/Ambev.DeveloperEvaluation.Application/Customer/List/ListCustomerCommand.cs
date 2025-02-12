using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.List
{
    public class ListCustomerCommand: IRequest<List<ListCustomerResult>>
    {
        public string Name { get; set; } = "";
        public ValidationResultDetail Validate()
        {
            var result = new ListCustomerCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
