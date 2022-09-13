using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public interface ISellerService
    {
        Task<List<Seller>> AddSeller(Seller seller);
        Task<Seller> LoginSeller(string em, string pa);
        Task<Seller> Sellerdet(string shopname);
    }
}
