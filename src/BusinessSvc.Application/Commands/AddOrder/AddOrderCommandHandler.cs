using BusinessSvc.Domain.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Commands.AddOrder
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, AddOrderCommandResponse>
    {
        readonly IBusinessRepository _repository;

        public AddOrderCommandHandler(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddOrderCommandResponse> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            int customerId = request.Customer.CustomerId != 0 ? request.Customer.CustomerId
                    : (await _repository.GetCustomerByName(request.Customer.Name)).CustomerId;

            return new AddOrderCommandResponse()
            {
                Success = await _repository.AddOrder(request.Order, customerId)
            };
        }
    }
}
