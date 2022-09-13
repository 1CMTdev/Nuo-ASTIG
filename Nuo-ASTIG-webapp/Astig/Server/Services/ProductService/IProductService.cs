﻿using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<Product> GetProduct(int id);
        Task<List<Product>> SearchProducts(string searchText);
        Task<List<Product>> AddProd(Product product);
        Task<List<Product>> GetProductSell(string Sx);
        Task Stockupdater(int Id, int Stock);
        Task Listingupdater(int Id, bool IsPublic);
        Task Soldupdater(int Id, int Sad);


    }
}
