using BlazingShop.Server.Services;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)
        {
            await _customerService.AddCustomer(customer);
            return null;
        }

        [HttpGet("{em},{pa}")]
        public async Task<ActionResult<Customer>> LoginCustomer(string em,string pa)
        {
            var response = await _customerService.LoginCustomer(em,pa);
            if (response == null)
            {
                return StatusCode(200, "NOT FOUND");
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpPut("{Name}/leveler")]
        public async Task<ActionResult> Lev(string Name)
        {
            await _customerService.Lev(Name);
            return null;
        }


    }
}
