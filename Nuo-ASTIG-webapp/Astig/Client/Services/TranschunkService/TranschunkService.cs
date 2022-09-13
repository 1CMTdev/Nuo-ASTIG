using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace BlazingShop.Client.Services.TranschunkService
{
    public class TranschunkService : ITranschunkService
    {
        private readonly HttpClient _http;
  


        public List<Transchunk> Transchunk { get; set; } = new List<Transchunk>();


        public TranschunkService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Transchunk>> AddTranschunk(Transchunk transchunk)
        {
            await _http.PostAsJsonAsync("api/Transchunk/", transchunk);
            return null;
        }

        public async Task<List<Transchunk>> GetTranschunk(string Cx)
        {
            //Transchunk = await _http.GetFromJsonAsync<List<Transchunk>>($"api/Transchunk/{Cx}");
            return await _http.GetFromJsonAsync<List<Transchunk>>($"api/Transchunk/{Cx}");
      
        }






    }
}