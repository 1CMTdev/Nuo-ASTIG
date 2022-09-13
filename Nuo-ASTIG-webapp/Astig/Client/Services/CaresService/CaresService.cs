
using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace BlazingShop.Client.Services.CaresService
{
    public class CaresService : ICaresService
    {
        private readonly HttpClient _http;



        public List<Cares> Cares { get; set; } = new List<Cares>();


        public CaresService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Cares>> AddCares(Cares cares)
        {
            await _http.PostAsJsonAsync("api/Cares/", cares);
            return null;
        }





    }
}