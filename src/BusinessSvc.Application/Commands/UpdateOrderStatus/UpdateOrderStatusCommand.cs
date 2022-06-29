using BusinessSvc.Domain.Entities;
using BusinessSvc.Domain.Enums;
using MediatR;

namespace BusinessSvc.Application.Commands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommand : IRequest<UpdateOrderStatusCommandResponse>
    {
        public Order Order { get; set; }

        public UpdateOrderStatusCommand(int orderId, OrderStatus status)
        {
            Order = new Order()
            {
                OrderId = orderId,
                Status = status
            };
        }
    }
}
