using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.Delete
{
    public class UpdateCustomerHandler : IRequestHandler<DeleteCustomerCommand, DeleteCustomerResult>
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerHandler(ICustomerRepository CustomerRepository, IMapper mapper)
        {
            _CustomerRepository = CustomerRepository;
            _mapper = mapper;
        }

        public async Task<DeleteCustomerResult> Handle(DeleteCustomerCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new DeleteCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toDelete = _mapper.Map<Domain.Entities.Customer>(commandRequest);

            var deleted = await _CustomerRepository.DeleteAsync(toDelete.Id, cancellationToken);

            return _mapper.Map<DeleteCustomerResult>(deleted);
        }
    }
}
