using BusinessSvc.Domain.Contracts;
using MediatR;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Commands.SendEmail
{
    public class SendEmailCommandHandler : IRequestHandler<SendEmailCommand, SendEmailCommandResponse>
    {
        readonly IBusinessRepository _repository;

        public SendEmailCommandHandler(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public Task<SendEmailCommandResponse> Handle(SendEmailCommand request, CancellationToken cancellationToken)
        {
            _repository.SetupContext();

            var customers = _repository.GetAllCustomers();
            
            return Task.FromResult(new SendEmailCommandResponse() { EmailSent = true });
        }
    }
}
