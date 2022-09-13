using System;
using System.Collections.Generic;
using System.Linq;
using BlazingShop.Shared;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.CaresService
{
    public interface ICaresService
    {
        Task<List<Cares>> AddCares(Cares cares);

    }
}