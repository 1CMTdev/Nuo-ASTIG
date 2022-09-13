using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly DataContext _context;
        public VoucherService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Voucher>> AddVoucher(Voucher voucher)
        {
            _context.Voucher.Add(voucher);
            await _context.SaveChangesAsync();
            return null;
        }


        public async Task<Voucher> CheckVouch(string Id)
        {
            var response = await _context.Voucher
                .FirstOrDefaultAsync(p => p.Id == Id && p.Usage == false);
            return response;
        }


        public async Task Offvouch(string Id)
        {
            Voucher voucher = await _context.Voucher
           .FirstOrDefaultAsync(p => p.Id == Id);
            voucher.Usage = true;
            await _context.SaveChangesAsync();
        }






    }
}