using BusinessSvc.Domain.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Commands.AddCustomer
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, AddCustomerCommandResponse>
    {
        readonly IBusinessRepository _repository;

        public AddCustomerCommandHandler(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddCustomerCommandResponse> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return new AddCustomerCommandResponse() 
                { 
                    Success = await _repository.AddCustomer(request.Customer),
                    Message = "Customer created"
                };
            }
            catch (Exception ex)
            {
                return new AddCustomerCommandResponse()
                {
                    Success = false,
                    Message = $"Unable to create customer. {ex.Message}"
                };
            }
        }
    }
}
