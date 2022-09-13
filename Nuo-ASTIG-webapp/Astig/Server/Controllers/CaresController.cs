using BlazingShop.Server.Services;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaresController : ControllerBase
    {
        private readonly ICaresService _caresService;

        public CaresController(ICaresService caresService)
        {
            _caresService = caresService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Cares>>> AddCares(Cares cares)
        {
            await _caresService.AddCares(cares);
            return null;
        }




    }
}