using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.Delete
{
    public class UpdateProductHandler : IRequestHandler<DeleteProductCommand, DeleteProductResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        public UpdateProductHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        public async Task<DeleteProductResult> Handle(DeleteProductCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new DeleteProductCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toDelete = _mapper.Map<Domain.Entities.Product>(commandRequest);

            var deleted = await _ProductRepository.DeleteAsync(toDelete.Id, cancellationToken);

            return _mapper.Map<DeleteProductResult>(deleted);
        }
    }
}
