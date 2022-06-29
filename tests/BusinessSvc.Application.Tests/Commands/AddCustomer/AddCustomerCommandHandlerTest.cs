using BusinessSvc.Application.Commands.AddCustomer;
using BusinessSvc.Domain.Contracts;
using BusinessSvc.Domain.Entities;
using MediatR;
using Moq;
using Shouldly;
using System.Threading;
using Xunit;

namespace BusinessSvc.Application.Tests.Commands.AddCustomer
{
    public class AddCustomerCommandHandlerTest
    {
        readonly Mock<IBusinessRepository> _repository;
        readonly AddCustomerCommandHandler _handler;

        public AddCustomerCommandHandlerTest()
        {
            _repository = new Mock<IBusinessRepository>();
            _handler = new AddCustomerCommandHandler(_repository.Object);
        }

        [Fact]
        public void ShouldImplementMediator()
        {
            _handler.ShouldBeAssignableTo<IRequestHandler<AddCustomerCommand, AddCustomerCommandResponse>>();
        }

        [Fact]
        public async void ShouldHandleNewCustomer()
        {
            var command = new AddCustomerCommand(new Customer());
            
            _repository
                .Setup(m => m.AddCustomer(It.IsAny<Customer>()))
                .ReturnsAsync(true);

            var response = await _handler.Handle(command, CancellationToken.None);

            response.Success.ShouldBeTrue();
        }
    }
}
