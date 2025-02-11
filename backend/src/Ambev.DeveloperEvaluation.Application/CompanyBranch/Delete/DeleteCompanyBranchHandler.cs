using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Delete
{
    public class UpdateCompanyBranchHandler : IRequestHandler<DeleteCompanyBranchCommand, DeleteCompanyBranchResult>
    {
        private readonly ICompanyBranchRepository _companyBranchRepository;
        private readonly IMapper _mapper;

        public UpdateCompanyBranchHandler(ICompanyBranchRepository companyBranchRepository, IMapper mapper)
        {
            _companyBranchRepository = companyBranchRepository;
            _mapper = mapper;
        }

        public async Task<DeleteCompanyBranchResult> Handle(DeleteCompanyBranchCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new DeleteCompanyBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toDelete = _mapper.Map<Domain.Entities.CompanyBranch>(commandRequest);

            var deleted = await _companyBranchRepository.DeleteAsync(toDelete.Id, cancellationToken);

            return _mapper.Map<DeleteCompanyBranchResult>(deleted);
        }
    }
}
