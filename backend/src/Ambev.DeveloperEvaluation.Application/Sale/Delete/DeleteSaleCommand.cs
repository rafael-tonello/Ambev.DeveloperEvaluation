using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.Delete
{
    public class DeleteSaleCommand: IRequest<DeleteSaleResult>
    {
        public Guid Id { get; set; }
        
        public ValidationResultDetail Validate()
        {
            var result = new DeleteSaleCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
