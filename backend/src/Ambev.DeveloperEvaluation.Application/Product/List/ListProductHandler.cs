using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.List
{
    public class ListProductHandler: IRequestHandler<ListProductCommand, List<ListProductResult>>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        public ListProductHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        public async Task<List<ListProductResult>> Handle(ListProductCommand commandRequest, CancellationToken cancellationToken)
        {
            var foundProducts = await _ProductRepository.SearchByName(commandRequest.Name, cancellationToken);

            return _mapper.Map<List<ListProductResult>>(foundProducts);
        }
    }
}
