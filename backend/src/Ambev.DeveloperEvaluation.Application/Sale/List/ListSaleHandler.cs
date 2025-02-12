using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.List
{
    public class ListSaleHandler: IRequestHandler<ListSaleCommand, List<ListSaleResult>>
    {
        private readonly ISaleRepository _SaleRepository;
        private readonly IMapper _mapper;

        public ListSaleHandler(ISaleRepository SaleRepository, IMapper mapper)
        {
            _SaleRepository = SaleRepository;
            _mapper = mapper;
        }

        public async Task<List<ListSaleResult>> Handle(ListSaleCommand commandRequest, CancellationToken cancellationToken)
        {
            var foundSales = await _SaleRepository.GetSales(cancellationToken);

            return _mapper.Map<List<ListSaleResult>>(foundSales);
        }
    }
}
