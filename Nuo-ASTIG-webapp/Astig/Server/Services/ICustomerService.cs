using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> AddCustomer(Customer customer);
        Task<Customer> LoginCustomer(string em, string pa);
        Task Lev(string Name);
    }
}
