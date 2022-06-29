using BusinessSvc.Domain.Contracts;
using MediatR;
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

        public async Task<SendEmailCommandResponse> Handle(SendEmailCommand request, CancellationToken cancellationToken)
        {
            await _repository.SetupContext();

            return new SendEmailCommandResponse()
            {
                Customers = await _repository.GetAllCustomers()
            };
        }
    }
}
