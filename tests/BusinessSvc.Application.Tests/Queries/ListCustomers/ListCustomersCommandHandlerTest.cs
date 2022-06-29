using BusinessSvc.Application.Queries.ListCustomers;
using BusinessSvc.Domain.Contracts;
using BusinessSvc.Domain.Entities;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace BusinessSvc.Application.Tests.Queries.ListCustomers
{
    public class ListCustomersCommandHandlerTest
    {
        readonly Mock<IBusinessRepository> _repository;
        readonly ListCustomersCommandHandler _handler;

        public ListCustomersCommandHandlerTest()
        {
            _repository = new Mock<IBusinessRepository>();
            _handler = new ListCustomersCommandHandler(_repository.Object);
        }

        [Fact]
        public async void ShouldHandleListOfCustomers()
        {
            var command = new ListCustomersCommand();

            _repository
                .Setup(m => m.GetAllCustomers())
                .ReturnsAsync(new List<Customer>());

            var response = await _handler.Handle(command, CancellationToken.None);

            response.Customers.ShouldNotBeNull();
        }
    }
}
