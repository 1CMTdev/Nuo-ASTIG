using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public class TranschunkService : ITranschunkService
    {
        private readonly DataContext _context;
        public TranschunkService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Transchunk>> AddTranschunk(Transchunk transchunk)
        {
            _context.Transchunk.Add(transchunk);
            await _context.SaveChangesAsync();
            return null;
        }


        public async Task<List<Transchunk>> GetTranschunk(string Cx)
        {
            return await _context.Transchunk.Where(p => p.Cx == Cx).ToListAsync();
        }






    }
}