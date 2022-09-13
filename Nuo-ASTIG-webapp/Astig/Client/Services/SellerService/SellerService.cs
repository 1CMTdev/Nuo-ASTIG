using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace BlazingShop.Client.Services.SellerService
{
    public class SellerService : ISellerService
    {
        private readonly HttpClient _http;



        public List<Seller> Sellers { get; set; } = new List<Seller>();


        public SellerService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Seller>> AddSeller(Seller seller)
        {
            await _http.PostAsJsonAsync("api/Seller/", seller);
            return null;
        }
        public async Task<Seller> LoginSeller(string em, string pa)
        {
            return await _http.GetFromJsonAsync<Seller>($"api/Seller/{em},{pa}");
        }

        public async Task<Seller> Sellerdet(string shopname)
        {
            return await _http.GetFromJsonAsync<Seller>($"api/Seller/{shopname}/sellerdetails");
        }




    }
}
