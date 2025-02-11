using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Update
{
    public class UpdateCompanyBranchHandler : IRequestHandler<UpdateCompanyBranchCommand, UpdateCompanyBranchResult>
    {
        private readonly ICompanyBranchRepository _companyBranchRepository;
        private readonly IMapper _mapper;

        public UpdateCompanyBranchHandler(ICompanyBranchRepository companyBranchRepository, IMapper mapper)
        {
            _companyBranchRepository = companyBranchRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCompanyBranchResult> Handle(UpdateCompanyBranchCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new UpdateCompanyBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toSave = _mapper.Map<Domain.Entities.CompanyBranch>(commandRequest);

            toSave.Id = new Random(DateTime.Now.Millisecond).Next();

            var saved = await _companyBranchRepository.UpdateAsync(toSave, cancellationToken);

            return _mapper.Map<UpdateCompanyBranchResult>(saved);
        }
    }
}
