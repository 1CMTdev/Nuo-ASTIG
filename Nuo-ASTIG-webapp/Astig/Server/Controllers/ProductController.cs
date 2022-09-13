using BlazingShop.Server.Services.ProductService;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
         
            return Ok(await _productService.GetAllProducts());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) {
            return Ok(await _productService.GetProduct(id));
        }

        [HttpGet("Search/{searchText}")]
        public async Task<ActionResult<List<Product>>> SearchProducts(string searchText)
        {
            return Ok(await _productService.SearchProducts(searchText));
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProd(Product product)
        {
            await _productService.AddProd(product);
            return null;
        }

        [HttpGet("{Sx}/byseller")]
        public async Task<ActionResult<List<Product>>> GetProductSell(string Sx)
        {
            return Ok(await _productService.GetProductSell(Sx));
        }



        [HttpPut("{id}/{Stock}/stocker")]
        public async Task<ActionResult> Stockupdater(int Id, int Stock)
        {
            await _productService.Stockupdater(Id, Stock);
            return null;
        }


        [HttpPut("{Id}/{IsPublic}/lister")]
        public async Task<ActionResult> Listingupdater(int Id, bool IsPublic)
        {
            await _productService.Listingupdater(Id, IsPublic);
            return null;
        }

        [HttpPut("{Id}/{Sad}/solder")]
        public async Task<ActionResult> Soldupdater(int Id, int Sad)
        {
            await _productService.Soldupdater(Id, Sad);
            return null;
        }





    }
}
