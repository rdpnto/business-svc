using BusinessSvc.Domain.Contracts;
using BusinessSvc.Domain.Entities;
using BusinessSvc.Repository.Persistence.SQL;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BusinessSvc.Repository.Persistence
{
    public class BusinessRepository : IBusinessRepository
    {
        IDbConnection _context;

        public BusinessRepository(IDbConnection context)
        {
            _context = context;
        }

        public async Task<bool> AddCustomer(Customer customer)
        {
            var result = await _context.ExecuteAsync(BusinessSQL.INSERT_CUSTOMER, new 
            { 
                name =  customer.Name,
                email = customer.Email
            });

            return result == 1;
        }

        public async Task<bool> AddOrder(Order order, int customerId)
        {
            var result = await _context.ExecuteAsync(BusinessSQL.INSERT_ORDER, new
            {
                customerId = customerId,
                price =      order.Price,
                createdAt =  order.CreatedAt,
                status =     order.Status
            });

            return result == 1;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var response = await _context.QueryAsync<Customer>(BusinessSQL.GET_ALL_CUSTOMERS);

            return response;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _context.QueryFirstOrDefaultAsync<Customer>(BusinessSQL.GET_CUSTOMER_BY_ID, new
            {
                customerId = id
            });
        }

        public async Task<Customer> GetCustomerByName(string name)
        {
            return await _context.QueryFirstOrDefaultAsync<Customer>(BusinessSQL.GET_CUSTOMER_BY_NAME, new
            {
                name = name
            });
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomerId(int customerId)
        {
            return await _context.QueryAsync<Order>(BusinessSQL.GET_ORDERS_BY_CUSTOMER_ID, new
            {
                customerId = customerId
            });
        }
    }
}
