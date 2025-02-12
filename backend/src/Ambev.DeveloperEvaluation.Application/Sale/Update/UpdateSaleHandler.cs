using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.Update
{
    public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
    {
        private readonly ISaleRepository _SaleRepository;

        private readonly ISaleProdRepository _SaleProdRepository;
        private readonly IMapper _mapper;

        public UpdateSaleHandler(ISaleRepository SaleRepository, IMapper mapper)
        {
            _SaleRepository = SaleRepository;
            _mapper = mapper;
        }

        public async Task<UpdateSaleResult> Handle(UpdateSaleCommand commandRequest, CancellationToken cancellationToken)
        {
            var validator = new UpdateSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(commandRequest, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            //{ TODO: Move it to a Business layer
                double itemsPricesSum = 0.0f;
                double totalDiscount = 0.0f;
                foreach (var item in commandRequest.Items)
                {
                    itemsPricesSum += item.Price * item.Amount;
                    totalDiscount += item.Price * item.Amount * item.Discount;
                }

                var toSave = _mapper.Map<Domain.Entities.Sale>(commandRequest);

                toSave.GrossValue = itemsPricesSum;
                toSave.TotalDiscount = totalDiscount;
                toSave.FinalValue = itemsPricesSum - totalDiscount;
            //}


            toSave.Id = Guid.NewGuid();

            var saved = await _SaleRepository.CreateAsync(toSave, cancellationToken);


            //remove old items
            await _SaleProdRepository.DeleteSaleProdsAsync(commandRequest.Id, cancellationToken);

            //insert sale itens in appopriate repository
            foreach (var item in commandRequest.Items)
            {
                await _SaleProdRepository.CreateAsync(item, cancellationToken);
            }

            return _mapper.Map<UpdateSaleResult>(saved);
        }
    }
}
