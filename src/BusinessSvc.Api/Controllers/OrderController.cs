using BusinessSvc.Application.Commands.AddOrder;
using BusinessSvc.Application.Commands.UpdateOrderStatus;
using BusinessSvc.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BusinessSvc.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class OrderController : ControllerBase
    {
        readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("{id:int}")]
        public async Task<AddOrderCommandResponse> PostOrder([FromBody] Order order, int id)
        {
            var command = new AddOrderCommand(order, customerId: id);

            return await _mediator.Send(command);
        }

        [HttpPost]
        [Route("{name:alpha}")]
        public async Task<AddOrderCommandResponse> PostOrder([FromBody] Order order, string name)
        {
            var command = new AddOrderCommand(order, name: name);

            return await _mediator.Send(command);
        }

        [HttpPatch]
        [Route("{orderId:int}")]
        public async Task<UpdateOrderStatusCommandResponse> UpdateOrderStatus([FromBody] Order order, int orderId)
        {
            var command = new UpdateOrderStatusCommand(orderId, order.Status);

            return await _mediator.Send(command);
        }

    }
}
