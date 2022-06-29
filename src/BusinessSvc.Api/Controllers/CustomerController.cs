using BusinessSvc.Application.Commands.SendEmail;
using BusinessSvc.Application.Queries.ListCustomers;
using BusinessSvc.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        public async Task<ListCustomersCommandResponse> GetAllCustomers()
        {
            return await _mediator.Send(new ListCustomersCommand());
        }
    }
}
