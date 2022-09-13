using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace BlazingShop.Client.Services.CustomerService
{
    public class CustomerService:ICustomerService
    {
        private readonly HttpClient _http;
        
   

        public List<Customer> Customers { get; set; } = new List<Customer>();


        public CustomerService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Customer>> AddCustomer(Customer customer)
        {
            await _http.PostAsJsonAsync("api/Customer/", customer);
            return null;
        }
        public async Task<Customer> LoginCustomer(string em, string pa)
        {
            return await _http.GetFromJsonAsync<Customer>($"api/Customer/{em},{pa}");
        }

        public async Task Lev(string Name)
        {
            Customer customer = null;
            await _http.PutAsJsonAsync($"api/Customer/{Name}/leveler", customer);
        }





    }
}
