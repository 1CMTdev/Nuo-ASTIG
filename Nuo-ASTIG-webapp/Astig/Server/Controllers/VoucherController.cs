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
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Voucher>>> AddVoucher(Voucher voucher)
        {
            await _voucherService.AddVoucher(voucher);
            return null;
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<Voucher>> CheckVouch(string Id)
        {
            var response = await _voucherService.CheckVouch(Id);
            if (response == null)
            {
                return StatusCode(200, "NOT FOUND");
            }
            else
            {
                return Ok(response);
            }
        }
        [HttpPut("{Id}/offer")]
        public async Task<ActionResult> Offvouch(string Id)
        {
            await _voucherService.Offvouch(Id);
            return null;
        }




    }
}