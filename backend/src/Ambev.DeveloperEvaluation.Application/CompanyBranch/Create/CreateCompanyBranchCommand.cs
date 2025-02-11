using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Create
{
    public class CreateCompanyBranchCommand: IRequest<CreateCompanyBranchResult>
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";

        public ValidationResultDetail Validate()
        {
            var result = new CreateCompanyBranchCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
