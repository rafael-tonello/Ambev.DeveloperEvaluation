using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.Create
{
    public class CreateProductCommand: IRequest<CreateProductResult>
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public double Price { get; set; }

        public ValidationResultDetail Validate()
        {
            var result = new CreateProductCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
