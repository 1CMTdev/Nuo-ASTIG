using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public class CaresService : ICaresService
    {
        private readonly DataContext _context;
        public CaresService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Cares>> AddCares(Cares cares)
        {
            _context.Cares.Add(cares);
            await _context.SaveChangesAsync();
            return null;
        }






    }
}