﻿using BusinessSvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessSvc.Domain.Contracts
{
    public interface IBusinessRepository
    {
        void SetupContext();

        void AddOrder(Order order, Customer customer);

        void AddCustomer(Customer customer);

        Task<IEnumerable<Customer>> GetAllCustomers();
    }
}
