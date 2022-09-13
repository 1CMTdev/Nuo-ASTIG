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
    public class TranschunkController : ControllerBase
    {
        private readonly ITranschunkService _transchunkService;

        public TranschunkController(ITranschunkService transchunkService)
        {
            _transchunkService = transchunkService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Transchunk>>> AddTranschunk(Transchunk transchunk)
        {
            await _transchunkService.AddTranschunk(transchunk);
            return null;
        }


        [HttpGet("{Cx}")]
        public async Task<ActionResult<List<Transchunk>>> GetTranschunk(string Cx)
        {
            return Ok(await _transchunkService.GetTranschunk(Cx));
        }




    }
}