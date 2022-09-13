using System;
using System.Collections.Generic;
using System.Linq;
using BlazingShop.Shared;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.TransactionsService
{
    public interface ITransactionsService
    {
        Task<List<Transactions>> AddTransactions(Transactions transactions);
        Task<List<Transactions>> GetTransactions(string Cx);
        Task<List<Transactions>> GetTransactionsSell(string Sx);
    }
}