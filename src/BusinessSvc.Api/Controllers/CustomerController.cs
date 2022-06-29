using BusinessSvc.Application.Commands.SendEmail;
using BusinessSvc.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BusinessSvc.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CustomerController : ControllerBase
    {
        readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<SendEmailCommandResponse> GetAllCustomers()
        {
            return await _mediator.Send(new SendEmailCommand());
        }
    }
}
