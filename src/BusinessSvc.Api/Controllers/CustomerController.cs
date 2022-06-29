using BusinessSvc.Application.Commands.AddCustomer;
using BusinessSvc.Application.Queries.CustomerOrders;
using BusinessSvc.Application.Queries.ListCustomers;
using BusinessSvc.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BusinessSvc.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class CustomerController : ControllerBase
    {
        readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<AddCustomerCommandResponse> AddCustomer([FromBody] Customer customer)
        {
            var command = new AddCustomerCommand(customer);

            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ListCustomersCommandResponse> GetAllCustomers()
        {
            return await _mediator.Send(new ListCustomersCommand());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<CustomerOrdersCommandResponse> GetCustomerOrders(int id)
        {
            var command = new CustomerOrdersCommand(customerId: id);

            return await _mediator.Send(command);
        }

        [HttpGet]
        [Route("{name:alpha}")]
        public async Task<CustomerOrdersCommandResponse> GetCustomerOrders(string name)
        {
            var command = new CustomerOrdersCommand(name: name);

            return await _mediator.Send(command);
        }
    }
}
