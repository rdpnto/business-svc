using MediatR;

namespace BusinessSvc.Application.Queries.ListCustomers
{
    public class ListCustomersCommand : IRequest<ListCustomersCommandResponse>
    {
    }
}
