using BusinessSvc.Domain.Entities;
using MediatR;

namespace BusinessSvc.Application.Queries.CustomerOrders
{
    public class CustomerOrdersCommand : IRequest<CustomerOrdersCommandResponse>
    {
        public Customer Customer { get; set; }

        public CustomerOrdersCommand(string name = null, int customerId = 0)
        {
            Customer = new Customer() 
            { 
                CustomerId = customerId,
                Name = name
            };

        }
    }
}
