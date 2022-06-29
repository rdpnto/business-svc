using BusinessSvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessSvc.Domain.Contracts
{
    public interface IBusinessRepository
    {
        Task<bool> AddOrder(Order order);

        Task<bool> AddCustomer(Customer customer);

        Task<IEnumerable<Customer>> GetAllCustomers();
    }
}
