#pragma checksum "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Complete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b6662fe5f4fac7a169d77b9e75b2e2542e43d06"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CustomerService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.SellerService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.TransactionsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.TranschunkService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.VoucherService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CaresService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/complete")]
    public partial class Complete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Complete.razor"
 if (stopper == true)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, @"<div class=""jumbotron""><h1 class=""display-4"">THANK YOU FOR YOUR PURCHASE!</h1>
        <p class=""lead"">Share the fun of getting ARTS! <span class=""text-light"">FOLLOW US ON SOCIAL MEDIA!</span></p>
        <a class=""btn btn-secondary btn-lg"" href=""mytransactions"" role=""button"">Go to Transactions</a>
        <hr class=""my-4"">
        <center><iframe src=""https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2Fastigecommerce%2Fposts%2F103935922202321&show_text=true&width=500"" width=""500"" height=""674"" style=""border:none;overflow:hidden;background:#ffffff"" scrolling=""no"" frameborder=""0"" allowfullscreen=""true"" allow=""autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share""></iframe></center></div>");
#nullable restore
#line 24 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Complete.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h1 class=\"alert-danger\">PROCESSING......</h1>");
#nullable restore
#line 29 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Complete.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Complete.razor"
       


    string chunkprod = "";
    string chunkid = new Random().Next(1000, 9999) + "";
    List<CartItem> cartItems = new List<CartItem>();
    BlazingShop.Shared.Transactions transactions = new BlazingShop.Shared.Transactions();
    BlazingShop.Shared.Transchunk transchunk = new BlazingShop.Shared.Transchunk();
    bool stopper;


    protected override async Task OnInitializedAsync()
    {
        string pnp;
        pnp = await LocalStorage.GetItemAsync<string>("PNP");
        if (pnp != "C")
        {
            NavigationManager.NavigateTo("login");
        }


        stopper = await LocalStorage.GetItemAsync<bool>("xxx");
        cartItems = await CartService.GetCartItems();
        string e = await LocalStorage.GetItemAsync<string>("credname");
        string vouch = await LocalStorage.GetItemAsync<string>("voucheroffer");

        try
        {

            if (stopper == true)
            {

                //saving per product
                //each item
                foreach (var item in cartItems)
                {
                    transactions.Id = item.ProductId + "-" + chunkid;
                    transactions.TransID = chunkid;
                    transactions.Total = item.Quantity * item.Price;
                    transactions.Px = "[" + item.Quantity + "] " + item.ProductTitle + "-" + item.Category;
                    Console.WriteLine(transactions.Px);
                    transactions.Deliverymode = await LocalStorage.GetItemAsync<string>("chunkmode");
                    transactions.Cx = e;
                    transactions.Sx = item.Sx;
                    chunkprod = "- " + "(" + item.Quantity + ") " + item.ProductTitle + chunkprod;
                    await TransactionsService.AddTransactions(transactions);

                    //product service
                    await ProductService.Stockupdater(item.ProductId, item.Stock - item.Quantity);
                    await ProductService.Soldupdater(item.ProductId, item.Quantity);
                    await CustomerService.Lev(e);
                    Console.WriteLine("Complete T");
                }


                if (vouch != null)
                {
                    await VoucherService.Offvouch(vouch);
                }

                ////transchunk
                transchunk.Id = chunkid;
                transchunk.Voucher = await LocalStorage.GetItemAsync<string>("chunkvouch");
                transchunk.Mode = await LocalStorage.GetItemAsync<string>("chunkmode");
                transchunk.Address = await LocalStorage.GetItemAsync<string>("chunkadd");
                transchunk.Status = "Processing";
                transchunk.Cx = e;
                transchunk.OverallTotal = await LocalStorage.GetItemAsync<decimal>("chunkover");
                transchunk.WithoutShipping = await LocalStorage.GetItemAsync<decimal>("chunktot");
                transchunk.Products = chunkprod;
                await TranschunkService.AddTranschunk(transchunk);
                Console.WriteLine("Complet TC");
                await LocalStorage.SetItemAsync<bool>("xxx", false);
                await CartService.EmptyCart();

            }//else
        }
        catch
        {
            ToastService.ShowError("Error", "NO TRANSACTIONS ARE MADE");
        }
    }//end of initialized





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVoucherService VoucherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService CustomerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITranschunkService TranschunkService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITransactionsService TransactionsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
