using MediatR;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.CreateCompanyBranch;
using Ambev.DeveloperEvaluation.Application.CompanyBranch.Create;
using Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.GetCompanyBranch;
using Ambev.DeveloperEvaluation.Application.CompanyBranch.Get;
using Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.DeleteCompanyBranch;
using Ambev.DeveloperEvaluation.Application.CompanyBranch.Delete;
using Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranchs.ListCompanyBranch;
using Ambev.DeveloperEvaluation.Application.CompanyBranch.List;

namespace Ambev.DeveloperEvaluation.WebApi.Features.CompanyBranch;

/// <summary>
/// Controller for managing company branches operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CompanyBranchController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CompanyBranchController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public CompanyBranchController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new Compan yBranch
    /// </summary>
    /// <param name="request">The CompanyBranch creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created CompanyBranch details</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateCompanyBranchResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCompanyBranch([FromBody] CreateCompanyBranchRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateCompanyBranchRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreateCompanyBranchCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateCompanyBranchResponse>
        {
            Success = true,
            Message = "Sucess",
            Data = _mapper.Map<CreateCompanyBranchResponse>(response)
        });
    }

    /// <summary>
    /// Retrieves a company branch by their ID
    /// </summary>
    /// <param name="id">The unique identifier of the CompanyBranch</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The CompanyBranch details if found</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetCompanyBranchResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCompanyBranch([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new GetCompanyBranchRequest { Id = id };
        var validator = new GetCompanyBranchRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<GetCompanyBranchCommand>(request.Id);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<GetCompanyBranchResponse>
        {
            Success = true,
            Message = "Sucess",
            Data = _mapper.Map<GetCompanyBranchResponse>(response)
        });
    }

    /// <summary>
    /// Deletes a company branch by their ID
    /// </summary>
    /// <param name="id">The unique identifier of the company branch to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success response if the company branch was deleted</returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteCompanyBranch([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new DeleteCompanyBranchRequest { Id = id };
        var validator = new DeleteCompanyBranchRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<DeleteCompanyBranchCommand>(request.Id);
        await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponse
        {
            Success = true,
            Message = "Sucess",
        });
    }

    [HttpGet("all")]
    [ProducesResponseType(typeof(ApiResponseWithData<List<ListCompanyBranchResponse>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ListCustomers(CancellationToken cancellationToken)
    {
        var command = new ListCompanyBranchCommand();
        var response = await _mediator.Send(command, cancellationToken);

        return new JsonResult(new ApiResponseWithData<List<ListCompanyBranchResponse>>
        {
            Success = true,
            Message = "Customers retrieved successfully",
            Data = _mapper.Map<List<ListCompanyBranchResponse>>(response)
        });
    }
}
