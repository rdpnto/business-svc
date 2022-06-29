using BusinessSvc.Domain.Entities;
using MediatR;

namespace BusinessSvc.Application.Commands.AddCustomer
{
    public class AddCustomerCommand : IRequest<AddCustomerCommandResponse>
    {
        public Customer Customer { get; set; }

        public AddCustomerCommand(Customer customer) => Customer = customer;
    }
}
