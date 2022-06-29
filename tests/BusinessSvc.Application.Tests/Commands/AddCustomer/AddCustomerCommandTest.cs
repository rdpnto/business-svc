using BusinessSvc.Application.Commands.AddCustomer;
using BusinessSvc.Domain.Entities;
using MediatR;
using Shouldly;
using Xunit;

namespace BusinessSvc.Application.Tests.Commands.AddCustomer
{
    public class AddCustomerCommandTest
    {
        AddCustomerCommand _command;

        [Fact]
        public void ShouldImplementMediator()
        {
            _command.ShouldBeAssignableTo<IRequest<AddCustomerCommandResponse>>();
        }

        [Fact]
        public void ShouldHaveCustomerProperty()
        {
            _command = new AddCustomerCommand(new Customer());
        }
    }
}
