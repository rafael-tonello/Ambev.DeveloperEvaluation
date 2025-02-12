using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.Delete
{
    public class UpdateSaleHandler : IRequestHandler<DeleteSaleCommand, DeleteSaleResult>
    {
        private readonly ISaleRepository _SaleRepository;
        private readonly ISaleProdRepository _SaleProdRepository;
        private readonly IMapper _mapper;

        public UpdateSaleHandler(ISaleRepository SaleRepository, ISaleProdRepository SaleProdRepository, IMapper mapper)
        {
            _SaleRepository = SaleRepository;
            _SaleProdRepository = SaleProdRepository;
            _mapper = mapper;
        }

        public async Task<DeleteSaleResult> Handle(DeleteSaleCommand commandRequest, CancellationToken cancellationToken)
        {

            var validator = new DeleteSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var toDelete = _mapper.Map<Domain.Entities.Sale>(commandRequest);

            var deleted = await _SaleRepository.DeleteAsync(toDelete.Id, cancellationToken);

            if (!deleted)
                throw new Exception("Sale not deleted");

            await _SaleProdRepository.DeleteSaleProdsAsync(toDelete.Id, cancellationToken);

            return _mapper.Map<DeleteSaleResult>(deleted);
        }
    }
}
