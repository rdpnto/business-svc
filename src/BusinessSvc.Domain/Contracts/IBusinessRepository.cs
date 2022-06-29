using BusinessSvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessSvc.Domain.Contracts
{
    public interface IBusinessRepository
    {
        Task<bool> AddOrder(Order order, int customerId);

        Task<bool> AddCustomer(Customer customer);

        Task<bool> UpdateOrderStatusById(Order order);

        Task<Customer> GetCustomerById(int id);

        Task<Customer> GetCustomerByName(string name);
        
        Task<IEnumerable<Customer>> GetAllCustomers();

        Task<IEnumerable<Order>> GetOrdersByCustomerId(int customerId);
    }
}
