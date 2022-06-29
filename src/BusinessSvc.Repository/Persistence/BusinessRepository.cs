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

        public void AddCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrder(Order order, Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.QueryAsync<Customer>(BusinessSQL.GET_ALL_CUSTOMERS);
        }
    }
}
