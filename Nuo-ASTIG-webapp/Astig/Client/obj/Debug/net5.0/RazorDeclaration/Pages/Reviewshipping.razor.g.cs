// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/reviewshipping")]
    public partial class Reviewshipping : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
       
    bool IsDisabled;
    List<CartItem> cartItems = new List<CartItem>();
    BlazingShop.Shared.Voucher xvoucher = new BlazingShop.Shared.Voucher();

    decimal totalbind, shippingbind, comibind;
    string discounterstatement = "";
    public string vouchercode;
    string shipping;

    protected override async Task OnInitializedAsync()
    {
        string pnp;
        pnp = await LocalStorage.GetItemAsync<string>("PNP");
        if (pnp != "C")
        {
            NavigationManager.NavigateTo("login");
        }

        //initiate value
        shipping = await LocalStorage.GetItemAsync<string>("credadd");
        cartItems = await CartService.GetCartItems();

        //COD Button Disabler
        string nc = null;
        int tc = 0;
        foreach (var t in cartItems.Where(n => n.Istan == false))
        {
            nc = nc + t.ProductTitle + "\n";
            tc++;
        }

        if (nc != null)
        {
            if (tc == cartItems.Count)
            {
                IsDisabled = true;
                decimal x = Math.Round(cartItems.Sum(item => item.Price * item.Quantity), 2);
                comibind = Math.Round(0.02m * x, 2);
                shippingbind = 0;
                totalbind = Math.Round(x + comibind + shippingbind, 2); StateHasChanged();
                ToastService.ShowSuccess("Non-shippable product Checkout.", "COD DISABLED");

            }
            else
            {
                IsDisabled = true;
                StateHasChanged();
                decimal x = Math.Round(cartItems.Sum(item => item.Price * item.Quantity), 2);
                comibind = Math.Round(0.02m * x, 2);
                shippingbind = 0;
                totalbind = Math.Round(x + comibind + shippingbind, 2); StateHasChanged();
                ToastService.ShowSuccess("Non-shippable product Checkout.", "COD DISABLED");
            }
        }
        else { IsDisabled = false;
            decimal x = Math.Round(cartItems.Sum(item => item.Price * item.Quantity), 2);
            comibind = Math.Round(0.02m * x, 2);
            shippingbind = 100;
            totalbind = Math.Round(x + comibind + shippingbind, 2);
            StateHasChanged();
        }

        //*********************COD Button Disabler





        //locs
        await LocalStorage.SetItemAsync<decimal>("chunkover", totalbind);
        await LocalStorage.SetItemAsync<decimal>("chunktot", comibind);
        await LocalStorage.SetItemAsync<string>("chunkvouch", "None");
        await LocalStorage.SetItemAsync<string>("chunkadd", shipping);
        await LocalStorage.SetItemAsync<string>("chunkmode", "Paypal");
        await LocalStorage.SetItemAsync<bool>("xxx", true);

    }


    //paypal--------------------------------
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("initPayPalButton");
            StateHasChanged();

        }

    }//paypal--------------------------------

    //COD BUTTON
    private async void w()
    {

        //locs
        decimal x = Math.Round(cartItems.Sum(item => item.Price * item.Quantity), 2);
        await LocalStorage.SetItemAsync<decimal>("chunkover", totalbind);
        await LocalStorage.SetItemAsync<decimal>("chunktot", comibind);
        await LocalStorage.SetItemAsync<string>("chunkvouch", xvoucher.Type);
        await LocalStorage.SetItemAsync<string>("chunkadd", shipping);
        await LocalStorage.SetItemAsync<string>("chunkmode", "COD");
        NavigationManager.NavigateTo("complete");
        await LocalStorage.SetItemAsync<bool>("xxx", true);
    }




    public async void gg()
    {
        try
        {
            xvoucher = await VoucherService.CheckVouch(vouchercode);
            Console.WriteLine(xvoucher.Value);
            if (xvoucher.Type == "Free Shipping" && IsDisabled==false)
            {
                discounterstatement = "Free Shipping Voucher Applied";
                decimal x = Math.Round(cartItems.Sum(item => item.Price * item.Quantity), 2);
                comibind = Math.Round(0.02m * x, 2);
                shippingbind = 0;
                totalbind = Math.Round(x + comibind + shippingbind, 2);
                Console.WriteLine(discounterstatement);
                ToastService.ShowSuccess("Free Shipping yay!", "VOUCHER APPLIED!");
                //locs
                await LocalStorage.SetItemAsync<decimal>("chunkover", totalbind);
                await LocalStorage.SetItemAsync<decimal>("chunktot", comibind);
                await LocalStorage.SetItemAsync<string>("chunkvouch", "Free Shipping");
                await LocalStorage.SetItemAsync<string>("chunkadd", shipping);
                await LocalStorage.SetItemAsync<string>("chunkmode", "Paypal");


                StateHasChanged();


            }
            else if (xvoucher.Type == "Personal Code")
            {
                discounterstatement = "" + xvoucher.Type;
                decimal x = Math.Round(cartItems.Sum(item => item.Price * item.Quantity), 2);
                comibind = Math.Round(0.02m * x, 2);
                //shippingbind = 100;
                decimal y = Math.Round(x * xvoucher.Value, 2);
                totalbind = Math.Round(x + comibind + shippingbind, 2);
                discounterstatement = discounterstatement + " - " + "Saved: ???" + y;
                totalbind = Math.Round(totalbind - y, 2);
                Console.WriteLine(discounterstatement);
                ToastService.ShowSuccess("Save" + "???" + y, "VOUCHER APPLIED!");


                //locs
                await LocalStorage.SetItemAsync<decimal>("chunkover", totalbind);
                await LocalStorage.SetItemAsync<decimal>("chunktot", comibind);
                await LocalStorage.SetItemAsync<string>("chunkvouch", xvoucher.Type);
                await LocalStorage.SetItemAsync<string>("chunkadd", shipping);
                await LocalStorage.SetItemAsync<string>("chunkmode", "Paypal");
                await LocalStorage.SetItemAsync<string>("voucheroffer", vouchercode);
                StateHasChanged();

            }
            else
            {
                discounterstatement = "" + xvoucher.Type;
                decimal x = Math.Round(cartItems.Sum(item => item.Price * item.Quantity), 2);
                comibind = Math.Round(0.02m * x, 2);
                //shippingbind = 100;
                decimal y = Math.Round(x * xvoucher.Value, 2);
                totalbind = Math.Round(x + comibind + shippingbind, 2);
                discounterstatement = discounterstatement + " - " + "Saved: ???" + y;
                totalbind = Math.Round(totalbind - y, 2);
                Console.WriteLine(discounterstatement);
                ToastService.ShowSuccess("Save" + "???" + y, "VOUCHER APPLIED!");


                //locs
                await LocalStorage.SetItemAsync<decimal>("chunkover", totalbind);
                await LocalStorage.SetItemAsync<decimal>("chunktot", comibind);
                await LocalStorage.SetItemAsync<string>("chunkvouch", xvoucher.Type);
                await LocalStorage.SetItemAsync<string>("chunkadd", shipping);
                await LocalStorage.SetItemAsync<string>("chunkmode", "Paypal");

                StateHasChanged();
            }
        }
        catch
        {

            Console.WriteLine("ERROR");
            ToastService.ShowError("Please try again & double check", "VOUCHER INVALID");
        }
    }











#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVoucherService VoucherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
    }
}
#pragma warning restore 1591
