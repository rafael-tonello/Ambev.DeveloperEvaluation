using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale: BaseEntity
    {
        public DateTime DateTime { get; set; }

        public double GrossValue { get; set; }

        public double TotalDiscount { get; set; }

        public double FinalValue { get; set; }

        public Guid CompanyBranchId { get; set; }

        public Guid CustomerId { get; set; }

        public bool Cancelled { get; set; }

        public virtual Customer Customer {get; set; }

        public virtual CompanyBranch CompanyBranch {get; set; }

        public virtual List<SaleProd> Items { get; set; }

        public ValidationResultDetail Validate()
        {
            throw new NotImplementedException();
        } 

    }
}
