using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public class TransactionsService : ITransactionsService
    {
        private readonly DataContext _context;
        public TransactionsService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Transactions>> AddTransactions(Transactions transactions)
        {
            _context.Transactions.Add(transactions);
            await _context.SaveChangesAsync();
            return null;
        }
        public async Task<List<Transactions>> GetTransactions(string Cx)
        {
            return await _context.Transactions.Where(p => p.Cx == Cx && p.Id!=null).ToListAsync();
        }

        public async Task<List<Transactions>> GetTransactionsSell(string Sx)
        {
            return await _context.Transactions.Where(p => p.Sx == Sx).ToListAsync();
        }





    }
}
