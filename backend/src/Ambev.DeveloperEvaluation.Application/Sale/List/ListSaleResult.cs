using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sale.List
{
    public class ListSaleResult
    {
        public DateTime DateTime { get; set; }

        public Guid CompanyBranchId { get; set; }

        public Guid CustomerId { get; set; }

        public bool Cancelled { get; set; }

        //TODO: change it to use a DTO
        public required List<SaleProd> Items { get; set; }
    }
}
