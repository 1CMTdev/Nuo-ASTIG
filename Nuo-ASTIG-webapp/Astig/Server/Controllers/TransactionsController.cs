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
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService _transactionsService;

        public TransactionsController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Transactions>>> AddTransactions(Transactions transactions)
        {
            await _transactionsService.AddTransactions(transactions);
            return null;
        }

        [HttpGet("{Cx}")]
        public async Task<ActionResult<List<Transactions>>> GetTransactions(string Cx)
        {
            return Ok(await _transactionsService.GetTransactions(Cx));
        }
        
        [HttpGet("{Sx}/seller")]
        public async Task<ActionResult<List<Transactions>>> GetTransactionsSell(string Sx)
        {
            return Ok(await _transactionsService.GetTransactionsSell(Sx));
        }




    }
}