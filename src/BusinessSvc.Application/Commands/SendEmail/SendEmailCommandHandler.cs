using BusinessSvc.Domain.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Commands.SendEmail
{
    public class SendEmailCommandHandler : IRequestHandler<SendEmailCommand, SendEmailCommandResponse>
    {
        public Task<SendEmailCommandResponse> Handle(SendEmailCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
