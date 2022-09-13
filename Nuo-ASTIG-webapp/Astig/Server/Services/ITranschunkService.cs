
using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services
{
    public interface ITranschunkService
    {
        Task<List<Transchunk>> AddTranschunk(Transchunk transchunk);
        Task<List<Transchunk>> GetTranschunk(string Cx);
    }
}