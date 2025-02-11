namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.GetCompanyBranch;

/// <summary>
/// Request model for getting a user by ID
/// </summary>
public class GetCompanyBranchRequest
{
    /// <summary>
    /// The unique identifier of the user to retrieve
    /// </summary>
    public Guid Id { get; set; }
}
