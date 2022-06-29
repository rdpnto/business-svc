using BusinessSvc.Application.Commands.AddOrder;
using BusinessSvc.Domain.Contracts;
using BusinessSvc.Domain.Entities;
using MediatR;
using Moq;
using Shouldly;
using System.Threading;
using Xunit;

namespace BusinessSvc.Application.Tests.Commands.AddOrder
{
    public class AddOrderCommandHandlerTest
    {
        readonly Mock<IBusinessRepository> _repository;
        readonly AddOrderCommandHandler _handler;

        public AddOrderCommandHandlerTest()
        {
            _repository = new Mock<IBusinessRepository>();
            _handler = new AddOrderCommandHandler(_repository.Object);
        }

        [Fact]
        public void ShouldImplementMediator()
        {
            _handler.ShouldBeAssignableTo<IRequestHandler<AddOrderCommand, AddOrderCommandResponse>>();
        }

        [Fact]
        public async void ShouldHandleNewOrder()
        {
            var command = new AddOrderCommand(new Order());

            _repository
                .Setup(m => m.AddOrder(It.IsAny<Order>(), It.IsAny<int>()))
                .ReturnsAsync(true);

            var response = await _handler.Handle(command, CancellationToken.None);

            response.Success.ShouldBeTrue();
        }
    }
}
