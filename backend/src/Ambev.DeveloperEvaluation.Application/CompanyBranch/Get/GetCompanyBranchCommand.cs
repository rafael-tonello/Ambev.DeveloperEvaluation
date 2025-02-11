using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Get
{
    public class GetCompanyBranchCommand: IRequest<GetCompanyBranchResult>
    {
        public int Id { get; set; }
        

        public ValidationResultDetail Validate()
        {
            var result = new GetCompanyBranchCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
