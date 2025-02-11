using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Delete
{
    public class DeleteCompanyBranchCommand: IRequest<DeleteCompanyBranchResult>
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";

        public ValidationResultDetail Validate()
        {
            var result = new DeleteCompanyBranchCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
