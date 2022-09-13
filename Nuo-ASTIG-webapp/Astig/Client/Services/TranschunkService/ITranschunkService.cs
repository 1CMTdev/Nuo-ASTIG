using System;
using System.Collections.Generic;
using System.Linq;
using BlazingShop.Shared;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.TranschunkService
{
    public interface ITranschunkService
    {
        Task<List<Transchunk>> AddTranschunk(Transchunk transchunk);
        Task<List<Transchunk>> GetTranschunk(string Cx);
        List<Transchunk> Transchunk { get; set; }
    }
}