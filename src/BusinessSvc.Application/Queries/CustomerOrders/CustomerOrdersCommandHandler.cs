using BusinessSvc.Domain.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Queries.CustomerOrders
{
    public class CustomerOrdersCommandHandler : IRequestHandler<CustomerOrdersCommand, CustomerOrdersCommandResponse>
    {
        readonly IBusinessRepository _repository;

        public CustomerOrdersCommandHandler(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public async Task<CustomerOrdersCommandResponse> Handle(CustomerOrdersCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var customer = request.Customer.CustomerId == 0
                    ? await _repository.GetCustomerByName(request.Customer.Name)
                    : await _repository.GetCustomerById(request.Customer.CustomerId);

                if (customer == null) return new CustomerOrdersCommandResponse();

                return new CustomerOrdersCommandResponse() 
                { 
                    Customer = customer,
                    Orders = await _repository.GetOrdersByCustomerId(customer.CustomerId)
                };
            }
            catch (Exception)
            {
                return new CustomerOrdersCommandResponse();
            }

        }
    }
}
