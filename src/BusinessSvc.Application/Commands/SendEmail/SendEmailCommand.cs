using BusinessSvc.Domain.Entities;
using MediatR;

namespace BusinessSvc.Application.Commands.SendEmail
{
    public class SendEmailCommand : IRequest<SendEmailCommandResponse>
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
    }
}
