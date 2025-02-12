using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.Get
{
    public class GetCustomerHandler: IRequestHandler<GetCustomerCommand, GetCustomerResult>
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMapper _mapper;

        public GetCustomerHandler(ICustomerRepository CustomerRepository, IMapper mapper)
        {
            _CustomerRepository = CustomerRepository;
            _mapper = mapper;
        }

        public async Task<GetCustomerResult> Handle(GetCustomerCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new GetCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var foundCustomer = _CustomerRepository.GetByIdAsync(commandRequest.Id, cancellationToken);

            return foundCustomer == null
                ? throw new KeyNotFoundException("The branch was not found")
                : _mapper.Map<GetCustomerResult>(foundCustomer);
        }
    }
}
