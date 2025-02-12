using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.Update
{
    public class UpdateSaleCommand: IRequest<UpdateSaleResult>
    {
        public Guid Id {get; set; }
        public DateTime DateTime { get; set; }

        public Guid CompanyBranchId { get; set; }

        public Guid CustomerId { get; set; }

        public bool Cancelled { get; set; }

        //TODO: change it to use a DTO
        public required List<SaleProd> Items { get; set; }

        public ValidationResultDetail Validate()
        {
            var result = new UpdateSaleCommandValidator().Validate(this);

            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
