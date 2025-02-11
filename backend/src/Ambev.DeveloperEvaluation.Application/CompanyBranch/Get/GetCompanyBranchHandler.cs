using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Get
{
    public class GetCompanyBranchHandler: IRequestHandler<GetCompanyBranchCommand, GetCompanyBranchResult>
    {
        private readonly ICompanyBranchRepository _companyBranchRepository;
        private readonly IMapper _mapper;

        public GetCompanyBranchHandler(ICompanyBranchRepository companyBranchRepository, IMapper mapper)
        {
            _companyBranchRepository = companyBranchRepository;
            _mapper = mapper;
        }

        public async Task<GetCompanyBranchResult> Handle(GetCompanyBranchCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new GetCompanyBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var foundCompanyBranch = _companyBranchRepository.GetByIdAsync(commandRequest.Id, cancellationToken);

            return foundCompanyBranch == null
                ? throw new KeyNotFoundException("The branch was not found")
                : _mapper.Map<GetCompanyBranchResult>(foundCompanyBranch);
        }
    }
}
