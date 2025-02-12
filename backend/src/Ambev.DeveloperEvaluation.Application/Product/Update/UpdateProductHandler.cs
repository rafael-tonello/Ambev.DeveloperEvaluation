using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.Update
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult>
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        public UpdateProductHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
        }

        public async Task<UpdateProductResult> Handle(UpdateProductCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new UpdateProductCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toSave = _mapper.Map<Domain.Entities.Product>(commandRequest);

            var saved = await _ProductRepository.UpdateAsync(toSave, cancellationToken);

            return _mapper.Map<UpdateProductResult>(saved);
        }
    }
}
