using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.List
{
    public class ListCustomerHandler: IRequestHandler<ListCustomerCommand, List<ListCustomerResult>>
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMapper _mapper;

        public ListCustomerHandler(ICustomerRepository CustomerRepository, IMapper mapper)
        {
            _CustomerRepository = CustomerRepository;
            _mapper = mapper;
        }

        public async Task<List<ListCustomerResult>> Handle(ListCustomerCommand commandRequest, CancellationToken cancellationToken)
        {

            var foundCustomers = await _CustomerRepository.SearchByName(commandRequest.Name, cancellationToken);

            return _mapper.Map<List<ListCustomerResult>>(foundCustomers);
        }
    }
}
