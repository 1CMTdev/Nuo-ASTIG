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
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService;

        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Seller>>> AddSeller(Seller seller)
        {
            await _sellerService.AddSeller(seller);
            return null;
        }

        [HttpGet("{em},{pa}")]
        public async Task<ActionResult<Seller>> LoginSeller(string em, string pa)
        {
            var response = await _sellerService.LoginSeller(em, pa);
            if (response == null)
            {
                return StatusCode(200, "NOT FOUND");
            }
            else
            {
                return Ok(response);
            }
        }


        [HttpGet("{shopname}/sellerdetails")]
        public async Task<ActionResult<Seller>> Sellerdet(string shopname)
        {
            var response = await _sellerService.Sellerdet(shopname);
            if (response == null)
            {
                return StatusCode(200, "NOT FOUND");
            }
            else
            {
                return Ok(response);
            }
        }


    }
}
