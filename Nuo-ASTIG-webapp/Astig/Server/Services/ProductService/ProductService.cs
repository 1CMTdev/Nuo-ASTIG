using BlazingShop.Server.Data;
using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.Include(p => p.Variants).Where(p => p.IsPublic == true).ToListAsync();
        }




        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products
                .Where(p => p.IsPublic == true)
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Views++;

            await _context.SaveChangesAsync();

            return product;
        }


        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Include(p => p.Variants).Where(p => p.CategoryId == category.Id && p.IsPublic == true).ToListAsync();
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _context.Products
                .Where(p => p.Title.Contains(searchText) && p.IsPublic == true || p.Description.Contains(searchText) && p.IsPublic == true)
                .ToListAsync();
        }

        public async Task<List<Product>> AddProd(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return null;
        }


        public async Task<List<Product>> GetProductSell(string Sx)
        {
            return await _context.Products.Where(p => p.Sx == Sx).ToListAsync();
        }




        public async Task Stockupdater(int Id, int Stock)
        {
            Product product = await _context.Products
           .FirstOrDefaultAsync(p => p.Id == Id);
           product.Stock = Stock;
            await _context.SaveChangesAsync();
        }

        public async Task Listingupdater(int Id, bool IsPublic)
        {
            Product product = await _context.Products
           .FirstOrDefaultAsync(p => p.Id == Id);
            product.IsPublic = IsPublic;
            await _context.SaveChangesAsync();
        }

        public async Task Soldupdater(int Id, int Sad)
        {
            Product product = await _context.Products
           .FirstOrDefaultAsync(p => p.Id == Id);
            product.Sad += Sad;
            await _context.SaveChangesAsync();
        }







    }
}
