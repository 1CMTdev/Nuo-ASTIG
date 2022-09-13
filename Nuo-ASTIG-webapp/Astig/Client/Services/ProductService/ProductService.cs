﻿using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if (categoryUrl == null)
            {
                Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }
            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Product>>($"api/Product/Search/{searchText}");
        }

        public async Task<List<Product>> AddProd(Product product)
        {
            await _http.PostAsJsonAsync("api/Product/",product);
            return null;
        }
        public async Task<List<Product>> GetProductSell(string Sx)
        {

            return await _http.GetFromJsonAsync<List<Product>>($"api/Product/{Sx}/byseller");

        }
        public async Task Stockupdater(int Id, int Stock)
        {
            Product product=null;
            await _http.PutAsJsonAsync($"api/Product/{Id}/{Stock}/stocker",product);
        }
        public async Task Listingupdater(int Id, bool IsPublic)
        {
            Product product = null;
            await _http.PutAsJsonAsync($"api/Product/{Id}/{IsPublic}/lister", product);
        }


        public async Task Soldupdater(int Id, int Sad)
        {
            Product product = null;
            await _http.PutAsJsonAsync($"api/Product/{Id}/{Sad}/solder", product);
        }






    }
}