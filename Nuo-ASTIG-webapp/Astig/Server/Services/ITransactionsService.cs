using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public interface ITransactionsService
    {
        Task<List<Transactions>> AddTransactions(Transactions transactions);
        Task<List<Transactions>> GetTransactions(string Cx);
        Task<List<Transactions>> GetTransactionsSell(string Sx);
    }
}
