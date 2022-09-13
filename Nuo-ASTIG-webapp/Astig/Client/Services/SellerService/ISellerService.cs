using System;
using System.Collections.Generic;
using System.Linq;
using BlazingShop.Shared;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.SellerService
{
    public interface ISellerService
    {
        Task<List<Seller>> AddSeller(Seller seller);
        Task<Seller> LoginSeller(string em, string pa);
        Task<Seller> Sellerdet(string shopname);
    }
}
