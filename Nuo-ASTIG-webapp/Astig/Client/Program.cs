using BlazingShop.Client.Services.CartService;
using BlazingShop.Client.Services.CategoryService;
using BlazingShop.Client.Services.ProductService;
using BlazingShop.Client.Services.StatsService;
using BlazingShop.Client.Services.CustomerService;
using BlazingShop.Client.Services.SellerService;
using BlazingShop.Client.Services.TransactionsService;
using BlazingShop.Client.Services.TranschunkService;
using BlazingShop.Client.Services.VoucherService;
using BlazingShop.Client.Services.CaresService;
using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<ISellerService, SellerService>();
            builder.Services.AddScoped<ITransactionsService, TransactionsService>();
            builder.Services.AddScoped<ITranschunkService, TranschunkService>();
            builder.Services.AddScoped<IVoucherService, VoucherService>();
            builder.Services.AddScoped<ICaresService, CaresService>();





            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
            builder.Services.AddScoped<IStatsService, StatsService>();

            await builder.Build().RunAsync();
        }
    }
}
