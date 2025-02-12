using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using MediatR.NotificationPublishers;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleProd: BaseEntity
    {
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }

        public virtual Product Product {get; set; }
        public virtual Sale Sale {get; set; }

        public ValidationResultDetail Validate()
        {
            throw new NotImplementedException();
        }

    }
}



