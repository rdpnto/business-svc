using BusinessSvc.Domain.Entities;
using System.Collections.Generic;

namespace BusinessSvc.Application.Queries.ListCustomers
{
    public class ListCustomersCommandResponse
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}
