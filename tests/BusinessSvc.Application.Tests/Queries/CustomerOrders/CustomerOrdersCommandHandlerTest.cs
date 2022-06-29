using BusinessSvc.Application.Queries.CustomerOrders;
using BusinessSvc.Domain.Contracts;
using BusinessSvc.Domain.Entities;
using MediatR;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace BusinessSvc.Application.Tests.Queries.CustomerOrders
{
    public class CustomerOrdersCommandHandlerTest
    {
        readonly Mock<IBusinessRepository> _repository;
        readonly CustomerOrdersCommandHandler _handler;

        public CustomerOrdersCommandHandlerTest()
        {
            _repository = new Mock<IBusinessRepository>();
            _handler = new CustomerOrdersCommandHandler(_repository.Object);
        }

        [Fact]
        public void ShouldImplementMediator()
        {
            _handler.ShouldBeAssignableTo<IRequestHandler<CustomerOrdersCommand, CustomerOrdersCommandResponse>>();
        }

        [Fact]
        public async void ShouldHandleCustomerOrders()
        {
            var command = new CustomerOrdersCommand("customer");

            _repository
                .Setup(m => m.GetCustomerByName(It.IsAny<string>()))
                .ReturnsAsync(new Customer());
            _repository
                .Setup(m => m.GetOrdersByCustomerId(It.IsAny<int>()))
                .ReturnsAsync(new List<Order>());

            var response = await _handler.Handle(command, CancellationToken.None);

            response.ShouldNotBeNull();
        }
    }
}
