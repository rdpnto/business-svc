using BusinessSvc.Application.Commands.AddOrder;
using BusinessSvc.Domain.Entities;
using MediatR;
using Shouldly;
using Xunit;

namespace BusinessSvc.Application.Tests.Commands.AddOrder
{
    public class AddOrderCommandTest
    {
        AddOrderCommand _command;

        [Fact]
        public void ShouldImplementMediator()
        {
            _command.ShouldBeAssignableTo<IRequest<AddOrderCommandResponse>>();
        }

        [Fact]
        public void ShouldHaveOrderProperty()
        {
            _command = new AddOrderCommand(new Order());
        }
    }
}
