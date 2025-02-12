using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.List
{
    public class ListSaleCommand: IRequest<List<ListSaleResult>>
    {
        public ValidationResultDetail Validate()
        {
            var result = new ListSaleCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
