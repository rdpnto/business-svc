using BusinessSvc.Application.Queries.CustomerOrders;
using BusinessSvc.Domain.Entities;
using MediatR;
using Shouldly;
using Xunit;

namespace BusinessSvc.Application.Tests.Queries.CustomerOrders
{
    public class CustomerOrdersCommandTest
    {
        CustomerOrdersCommand _command;

        [Fact]
        public void ShouldImplementMediator()
        {
            _command.ShouldBeAssignableTo<IRequest<CustomerOrdersCommandResponse>>();
        }

        [Fact]
        public void ShouldHaveCustomerProperty()
        {
            _command = new CustomerOrdersCommand();

            _command.Customer.ShouldBeOfType<Customer>();
        }
    }
}
