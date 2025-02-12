using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.Get
{
    public class GetProductHandler: IRequestHandler<GetProductCommand, GetProductResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        public GetProductHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        public async Task<GetProductResult> Handle(GetProductCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new GetProductCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var foundProduct = _ProductRepository.GetByIdAsync(commandRequest.Id, cancellationToken);

            return foundProduct == null
                ? throw new KeyNotFoundException("The branch was not found")
                : _mapper.Map<GetProductResult>(foundProduct);
        }
    }
}
