using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.Create
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        public CreateProductHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        public async Task<CreateProductResult> Handle(CreateProductCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new CreateProductCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toSave = _mapper.Map<Domain.Entities.Product>(commandRequest);

            toSave.Id = Guid.NewGuid();

            var saved = await _ProductRepository.CreateAsync(toSave, cancellationToken);

            return _mapper.Map<CreateProductResult>(saved);
        }
    }
}
