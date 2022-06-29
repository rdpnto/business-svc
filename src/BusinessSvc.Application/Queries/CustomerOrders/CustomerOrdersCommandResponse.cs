using BusinessSvc.Domain.Entities;
using System.Collections.Generic;

namespace BusinessSvc.Application.Queries.CustomerOrders
{
    public class CustomerOrdersCommandResponse
    {
        public Customer Customer { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
