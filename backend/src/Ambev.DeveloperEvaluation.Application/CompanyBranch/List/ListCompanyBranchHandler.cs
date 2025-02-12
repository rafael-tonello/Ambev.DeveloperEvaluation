using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.CompanyBranch.List
{
    public class ListCompanyBranchHandler: IRequestHandler<ListCompanyBranchCommand, List<ListCompanyBranchResult>>
    {
        private readonly ICompanyBranchRepository _companyBranchRepository;
        private readonly IMapper _mapper;

        public ListCompanyBranchHandler(ICompanyBranchRepository companyBranchRepository, IMapper mapper)
        {
            _companyBranchRepository = companyBranchRepository;
            _mapper = mapper;
        }

        public async Task<List<ListCompanyBranchResult>> Handle(ListCompanyBranchCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new ListCompanyBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var foundCompanyBranches = _companyBranchRepository.GetAllAsync(cancellationToken);

            return _mapper.Map<List<ListCompanyBranchResult>>(foundCompanyBranches.Result);
        }
    }
}
