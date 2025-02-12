using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.Get
{
    public class GetSaleHandler: IRequestHandler<GetSaleCommand, GetSaleResult>
    {
        private readonly ISaleRepository _SaleRepository;
        private readonly IMapper _mapper;

        public GetSaleHandler(ISaleRepository SaleRepository, IMapper mapper)
        {
            _SaleRepository = SaleRepository;
            _mapper = mapper;
        }

        public async Task<GetSaleResult> Handle(GetSaleCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new GetSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var foundSale = _SaleRepository.GetByIdAsync(commandRequest.Id, cancellationToken);

            return foundSale == null
                ? throw new KeyNotFoundException("Not found")
                : _mapper.Map<GetSaleResult>(foundSale);
        }
    }
}
