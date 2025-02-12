using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.List
{
    public class ListCompanyBranchCommand: IRequest<List<ListCompanyBranchResult>>
    {
        public ValidationResultDetail Validate()
        {
            var result = new ListCompanyBranchCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
