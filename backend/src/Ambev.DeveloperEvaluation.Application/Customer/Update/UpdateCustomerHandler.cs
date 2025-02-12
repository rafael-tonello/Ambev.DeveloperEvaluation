using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.Update
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, UpdateCustomerResult>
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerHandler(ICustomerRepository CustomerRepository, IMapper mapper)
        {
            _CustomerRepository = CustomerRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCustomerResult> Handle(UpdateCustomerCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new UpdateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toSave = _mapper.Map<Domain.Entities.Customer>(commandRequest);

            var saved = await _CustomerRepository.UpdateAsync(toSave, cancellationToken);

            return _mapper.Map<UpdateCustomerResult>(saved);
        }
    }
}
