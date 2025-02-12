using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.List
{
    public class ListProductCommand: IRequest<List<ListProductResult>>
    {
        public string Name { get; set; } = "";
        public ValidationResultDetail Validate()
        {
            var result = new ListProductCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
