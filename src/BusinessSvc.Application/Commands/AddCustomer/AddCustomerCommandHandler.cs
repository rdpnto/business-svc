using BusinessSvc.Domain.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Commands.AddCustomer
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, AddCustomerCommandResponse>
    {
        readonly IBusinessRepository _repository;

        public AddCustomerCommandHandler(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddCustomerCommandResponse> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            return new AddCustomerCommandResponse() 
            { 
                Success = await _repository.AddCustomer(request.Customer)
            };
        }
    }
}
