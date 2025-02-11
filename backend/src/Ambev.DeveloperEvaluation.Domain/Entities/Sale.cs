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

        public double Discount { get; set; }

        public double FinalValue { get; set; }

        public int CompanyBranchId { get; set; }

        public int CustomerId { get; set; }

        public bool Cancelled { get; set; }

        public ValidationResultDetail Validate()
        {
            throw new NotImplementedException();
        } 

    }
}
