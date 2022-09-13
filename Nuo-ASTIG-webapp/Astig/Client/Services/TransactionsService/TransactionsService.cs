using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace BlazingShop.Client.Services.TransactionsService
{
    public class TransactionsService : ITransactionsService
    {
        private readonly HttpClient _http;



        public List<Transactions> Transactions { get; set; } = new List<Transactions>();


        public TransactionsService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Transactions>> AddTransactions(Transactions transactions)
        {
            await _http.PostAsJsonAsync("api/Transactions/", transactions);
            return null;
        }
        public async Task<List<Transactions>> GetTransactions(string Cx)
        {

            return await _http.GetFromJsonAsync<List<Transactions>>($"api/Transactions/{Cx}");

        }
        public async Task<List<Transactions>> GetTransactionsSell(string Sx)
        {

            return await _http.GetFromJsonAsync<List<Transactions>>($"api/Transactions/{Sx}/seller");

        }






    }
}