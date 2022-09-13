using System;
using System.Collections.Generic;
using System.Linq;
using BlazingShop.Shared;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.VoucherService
{
    public interface IVoucherService
    {
        Task<List<Voucher>> AddVoucher(Voucher voucher);
        Task<Voucher> CheckVouch(string Id);
        Task Offvouch(string Id);

    }
}