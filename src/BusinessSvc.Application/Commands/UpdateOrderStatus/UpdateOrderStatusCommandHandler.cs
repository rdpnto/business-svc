using BusinessSvc.Domain.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Commands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommandHandler : IRequestHandler<UpdateOrderStatusCommand, UpdateOrderStatusCommandResponse>
    {
        readonly IBusinessRepository _repository;

        public UpdateOrderStatusCommandHandler(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public async Task<UpdateOrderStatusCommandResponse> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repository.UpdateOrderStatusById(request.Order);

                return new UpdateOrderStatusCommandResponse()
                {
                    Success = result,
                    Message = result ? "Order updated" : "Order not found"
                };
            }
            catch (Exception ex)
            {
                return new UpdateOrderStatusCommandResponse() { Message = $"Order not found. {ex.Message}" };
            }
        }
    }
}
