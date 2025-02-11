using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.Create
{
    public class CreateCompanyBranchHandler : IRequestHandler<CreateCompanyBranchCommand, CreateCompanyBranchResult>
    {
        private readonly ICompanyBranchRepository _companyBranchRepository;
        private readonly IMapper _mapper;

        public CreateCompanyBranchHandler(ICompanyBranchRepository companyBranchRepository, IMapper mapper)
        {
            _companyBranchRepository = companyBranchRepository;
            _mapper = mapper;
        }

        public async Task<CreateCompanyBranchResult> Handle(CreateCompanyBranchCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new CreateCompanyBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toSave = _mapper.Map<Domain.Entities.CompanyBranch>(commandRequest);

            toSave.Id = new Random(DateTime.Now.Millisecond).Next();

            var saved = await _companyBranchRepository.CreateAsync(toSave, cancellationToken);

            return _mapper.Map<CreateCompanyBranchResult>(saved);
        }
    }
}
