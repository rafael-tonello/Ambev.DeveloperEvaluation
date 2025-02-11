using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.CreateCompanyBranch;

/// <summary>
/// API response model for CreateCompanyBranch operation
/// </summary>
public class CreateCompanyBranchResponse
{
    /// <summary>
    /// The unique identifier of the created CompanyBranch
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The CompanyBranch's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The CompanyBranch's address
    /// </summary>
    public string Address { get; set; } = string.Empty;

}
