namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.DeleteCompanyBranch;

/// <summary>
/// Request model for deleting a user
/// </summary>
public class DeleteCompanyBranchRequest
{
    /// <summary>
    /// The unique identifier of the user to delete
    /// </summary>
    public Guid Id { get; set; }
}
