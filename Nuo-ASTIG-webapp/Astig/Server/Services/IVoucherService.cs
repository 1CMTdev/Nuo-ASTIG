using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public interface IVoucherService
    {
        Task<List<Voucher>> AddVoucher(Voucher voucher);
        Task<Voucher> CheckVouch(string Id);
        Task Offvouch(string Id);
    }
}
