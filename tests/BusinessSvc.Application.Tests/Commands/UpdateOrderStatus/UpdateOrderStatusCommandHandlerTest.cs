using BusinessSvc.Application.Commands.UpdateOrderStatus;
using BusinessSvc.Domain.Contracts;
using BusinessSvc.Domain.Entities;
using BusinessSvc.Domain.Enums;
using MediatR;
using Moq;
using Shouldly;
using System.Threading;
using Xunit;

namespace BusinessSvc.Application.Tests.Commands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommandHandlerTest
    {
        readonly Mock<IBusinessRepository> _repository;
        readonly UpdateOrderStatusCommandHandler _handler;

        public UpdateOrderStatusCommandHandlerTest()
        {
            _repository = new Mock<IBusinessRepository>();
            _handler = new UpdateOrderStatusCommandHandler(_repository.Object);
        }

        [Fact]
        public void ShouldImplementMediator()
        {
            _handler.ShouldBeAssignableTo<IRequestHandler<UpdateOrderStatusCommand, UpdateOrderStatusCommandResponse>>();
        }

        [Fact]
        public async void ShouldHandleOrderStatusUpdate()
        {
            var command = new UpdateOrderStatusCommand(10, OrderStatus.Completed);

            _repository
                .Setup(m => m.UpdateOrderStatusById(It.IsAny<Order>()))
                .ReturnsAsync(true);

            var response = await _handler.Handle(command, CancellationToken.None);

            response.Success.ShouldBeTrue();
        }
    }
}
