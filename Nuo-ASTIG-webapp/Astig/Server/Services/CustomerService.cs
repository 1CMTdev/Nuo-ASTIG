using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();
            return null;
        }



        public async Task<Customer> LoginCustomer(string em, string pa)
        {

            var response = await _context.Customer
                // .Where(c => c.Email == true)
                // .Include(p => p.Variants)
                //.ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Email == em && p.Password == pa);
            if (response == null)
            {
                return null;
            }
            else
                return response;
        }


        public async Task Lev(string Name)
        {
            Customer customer = await _context.Customer
           .FirstOrDefaultAsync(p => p.Name == Name);
            customer.Lvl++;
            await _context.SaveChangesAsync();
        }



    }
}
