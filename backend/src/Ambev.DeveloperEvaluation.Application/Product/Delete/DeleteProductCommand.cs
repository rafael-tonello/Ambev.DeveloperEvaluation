using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.Delete
{
    public class DeleteProductCommand: IRequest<DeleteProductResult>
    {
        public Guid Id { get; set; }
        
        public ValidationResultDetail Validate()
        {
            var result = new DeleteProductCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
