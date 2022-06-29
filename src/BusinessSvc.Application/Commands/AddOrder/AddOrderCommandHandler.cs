using BusinessSvc.Domain.Contracts;
using MediatR;
using System;
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
            int customerId = request.Customer.CustomerId;

            if (request.Customer.CustomerId == 0)
            {
                var customer = await _repository.GetCustomerByName(request.Customer.Name);

                if (customer == null) return new AddOrderCommandResponse() { Message = "Customer name not found" };

                customerId = customer.CustomerId;
            }

            try
            {
                request.Order.CreatedAt = DateTime.Now;

                return new AddOrderCommandResponse()
                {
                    Success = await _repository.AddOrder(request.Order, customerId),
                    Message = "Order created"
                };
            }
            catch (Exception ex)
            {
                return new AddOrderCommandResponse() { Message = $"Unable to create order. {ex.Message}" };
            }

        }
    }
}
