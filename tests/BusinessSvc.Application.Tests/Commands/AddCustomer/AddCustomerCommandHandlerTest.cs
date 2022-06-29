using BusinessSvc.Domain.Contracts;
using BusinessSvc.Domain.Entities;
using Moq;
using Xunit;

namespace BusinessSvc.Application.Tests.Commands.AddCustomer
{
    public class AddCustomerCommandHandlerTest
    {
        Mock<IBusinessRepository> _repository;

        public AddCustomerCommandHandlerTest()
        {
            _repository = new Mock<IBusinessRepository>();
        }

        [Fact]
        public void ShouldPersistNewCustomer()
        {
            var command = new AddCustomerCommand();
            
            _repository
                .Setup(m => m.AddCustomer(It.IsAny<Customer>()))
                .ReturnsAsync(true);


        }
    }
}
