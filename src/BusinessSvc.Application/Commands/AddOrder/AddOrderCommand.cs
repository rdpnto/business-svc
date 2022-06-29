using BusinessSvc.Domain.Entities;
using MediatR;

namespace BusinessSvc.Application.Commands.AddOrder
{
    public class AddOrderCommand : IRequest<AddOrderCommandResponse>
    {
        public Order Order { get; set; }
        public Customer Customer { get; set; }

        public AddOrderCommand(Order order, int customerId = 0, string name = null)
        {
            Order = order;
            Customer = new Customer() 
            { 
                CustomerId = customerId,
                Name = name
            };

        }
    }
}
