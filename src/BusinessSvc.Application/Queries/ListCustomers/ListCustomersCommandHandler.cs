using BusinessSvc.Domain.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessSvc.Application.Queries.ListCustomers
{
    public class ListCustomersCommandHandler : IRequestHandler<ListCustomersCommand, ListCustomersCommandResponse>
    {
        readonly IBusinessRepository _repository;

        public ListCustomersCommandHandler(IBusinessRepository repository)
        {
            _repository = repository;
        }

        public async Task<ListCustomersCommandResponse> Handle(ListCustomersCommand request, CancellationToken cancellationToken)
        {
            return new ListCustomersCommandResponse()
            {
                Customers = await _repository.GetAllCustomers()
            };
        }
    }
}
