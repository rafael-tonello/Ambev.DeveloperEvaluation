using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.Create
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerResult>
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMapper _mapper;

        public CreateCustomerHandler(ICustomerRepository CustomerRepository, IMapper mapper)
        {
            _CustomerRepository = CustomerRepository;
            _mapper = mapper;
        }

        public async Task<CreateCustomerResult> Handle(CreateCustomerCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new CreateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toSave = _mapper.Map<Domain.Entities.Customer>(commandRequest);

            toSave.Id = Guid.NewGuid();

            var saved = await _CustomerRepository.CreateAsync(toSave, cancellationToken);

            return _mapper.Map<CreateCustomerResult>(saved);
        }
    }
}
