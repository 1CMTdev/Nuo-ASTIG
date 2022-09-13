using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public class SellerService : ISellerService
    {
        private readonly DataContext _context;
        public SellerService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> AddSeller(Seller seller)
        {
            _context.Seller.Add(seller);
            await _context.SaveChangesAsync();
            return null;
        }



        public async Task<Seller> LoginSeller(string em, string pa)
        {

            var response = await _context.Seller
                .FirstOrDefaultAsync(p => p.Email == em && p.Password == pa && p.Allowed==true);
            if (response == null)
            {
                return null;
            }
            else
                return response;
        }



        public async Task<Seller> Sellerdet(string shopname)
        {

            var response = await _context.Seller
                .FirstOrDefaultAsync(p => p.Shopname == shopname && p.Allowed == true);
                

            if (response == null)
            {
                return null;
            }
            else
                return response;
        }


    }
}
