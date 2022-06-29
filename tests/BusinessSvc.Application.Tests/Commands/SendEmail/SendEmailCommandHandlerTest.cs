using BusinessSvc.Domain.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Tests.Commands.SendEmail
{
    public class SendEmailCommandHandlerTest : IRequestHandler<SendEmailCommandTest, SendEmailCommandResponseTest>
    {
        readonly IBusinessRepository _repository;

        public SendEmailCommandHandlerTest(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public async Task<SendEmailCommandResponseTest> Handle(SendEmailCommandTest request, CancellationToken cancellationToken)
        {
            return new SendEmailCommandResponseTest()
            {
                Customers = await _repository.GetAllCustomers()
            };
        }
    }
}
