using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class CompanyBranch
    {
        public int Id {  get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";

        public ValidationResultDetail Validate()
        {
            throw new NotImplementedException();
        }

    }
}
