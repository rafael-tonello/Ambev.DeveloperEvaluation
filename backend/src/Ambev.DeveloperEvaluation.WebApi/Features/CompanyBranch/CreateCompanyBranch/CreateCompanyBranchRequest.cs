using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.CreateCompanyBranch;

/// <summary>
/// Represents a request to create a new CompanyBranch in the system.
/// </summary>
public class CreateCompanyBranchRequest
{
    /// <summary>
    /// Gets or sets the CompanyBranchname.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    public string Address { get; set; } = "";

}