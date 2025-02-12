using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.ListCompanyBranch;

/// <summary>
/// API response model for GetCompanyBranch operation
/// </summary>
public class ListCompanyBranchResponse
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The user's address
    /// </summary>
    public string Address { get; set; } = string.Empty;

}
