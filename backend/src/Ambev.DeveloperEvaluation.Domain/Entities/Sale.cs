using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    internal class Sale
    {
        public int Id { get; set; }

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
