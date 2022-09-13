using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace BlazingShop.Client.Services.VoucherService
{
    public class VoucherService : IVoucherService
    {
        private readonly HttpClient _http;



        public List<Voucher> Voucher { get; set; } = new List<Voucher>();


        public VoucherService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Voucher>> AddVoucher(Voucher voucher)
        {
            await _http.PostAsJsonAsync("api/Voucher/", voucher);
            return null;
        }

        public async Task<Voucher> CheckVouch(string Id)
        {
            return await _http.GetFromJsonAsync<Voucher>($"api/Voucher/{Id}");
        }
        public async Task Offvouch(string Id)
        {
            Voucher voucher = null;
            await _http.PutAsJsonAsync($"api/Voucher/{Id}/offer", voucher);
        }


    }
}
