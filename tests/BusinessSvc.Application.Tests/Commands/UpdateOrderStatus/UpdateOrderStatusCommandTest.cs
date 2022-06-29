using BusinessSvc.Application.Commands.UpdateOrderStatus;
using BusinessSvc.Domain.Entities;
using BusinessSvc.Domain.Enums;
using MediatR;
using Shouldly;
using Xunit;

namespace BusinessSvc.Application.Tests.Commands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommandTest
    {
        UpdateOrderStatusCommand _command;

        [Fact]
        public void ShouldImplementMediator()
        {
            _command.ShouldBeAssignableTo<IRequest<UpdateOrderStatusCommandResponse>>();
        }

        [Fact]
        public void ShouldHaveOrderProperty()
        {
            _command = new UpdateOrderStatusCommand(1, OrderStatus.Completed);

            _command.Order.ShouldBeOfType<Order>();
        }
    }
}
