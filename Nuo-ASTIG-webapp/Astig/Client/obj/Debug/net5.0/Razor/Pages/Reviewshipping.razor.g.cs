#pragma checksum "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad8599448fcdf422a95c00c835768041dcbc85b4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/reviewshipping")]
    public partial class Reviewshipping : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "id", "Total");
            __builder.AddAttribute(3, "value", 
#nullable restore
#line 10 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                      totalbind

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "hidden");
            __builder.AddAttribute(5, "b-qvj97oktzb");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n\n");
            __builder.AddMarkupContent(7, "<h5 b-qvj97oktzb>Here\'s what you\'ll get:</h5>\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "b-qvj97oktzb");
#nullable restore
#line 15 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
     foreach (var item in cartItems)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "item-container");
            __builder.AddAttribute(12, "b-qvj97oktzb");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "item-image-wrapper");
            __builder.AddAttribute(15, "b-qvj97oktzb");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 18 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                                       item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "class", "item-image");
            __builder.AddAttribute(19, "b-qvj97oktzb");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "item-name");
            __builder.AddAttribute(23, "b-qvj97oktzb");
            __builder.OpenElement(24, "h5");
            __builder.AddAttribute(25, "b-qvj97oktzb");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/product/" + (
#nullable restore
#line 20 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                       item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-qvj97oktzb");
#nullable restore
#line 20 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(29, item.ProductTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "b-qvj97oktzb");
#nullable restore
#line 21 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(33, item.Quantity);

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, " x");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "<br b-qvj97oktzb>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "item-price");
            __builder.AddAttribute(39, "b-qvj97oktzb");
            __builder.AddMarkupContent(40, "₱ ");
#nullable restore
#line 23 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(41, item.Price * item.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
              }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "text-xl-right text-primary");
            __builder.AddAttribute(44, "b-qvj97oktzb");
            __builder.AddMarkupContent(45, "\n        Order total (");
#nullable restore
#line 26 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(46, cartItems.Count);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "): ₱ ");
#nullable restore
#line 26 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(48, cartItems.Sum(item => item.Price * item.Quantity));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "\n        <br b-qvj97oktzb>\n        Transaction fee (2%):₱ ");
#nullable restore
#line 28 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(50, comibind);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\n        <br b-qvj97oktzb>\n        ");
#nullable restore
#line 30 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(52, discounterstatement);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "\n        <br b-qvj97oktzb>\n        Shipping fee: ₱ ");
#nullable restore
#line 32 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(54, shippingbind);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "\n        <br b-qvj97oktzb>\n        ");
            __builder.OpenElement(56, "span");
            __builder.AddAttribute(57, "class", "text-success");
            __builder.AddAttribute(58, "b-qvj97oktzb");
            __builder.AddMarkupContent(59, " Total: ₱ ");
#nullable restore
#line 34 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
__builder.AddContent(60, totalbind);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n\n<hr b-qvj97oktzb>\n<br b-qvj97oktzb>\n");
            __builder.AddMarkupContent(62, "<h6 b-qvj97oktzb>Voucher Code:</h6>\n");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "input-group mb-3");
            __builder.AddAttribute(65, "b-qvj97oktzb");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "input-group-prepend");
            __builder.AddAttribute(68, "b-qvj97oktzb");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "type", "button");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                                                gg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "b-qvj97oktzb");
            __builder.AddContent(74, "Apply");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n    ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "placeholder", "");
            __builder.AddAttribute(80, "aria-label", "");
            __builder.AddAttribute(81, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                                    vouchercode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vouchercode = __value, vouchercode));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(84, "b-qvj97oktzb");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n<br b-qvj97oktzb>\n<br b-qvj97oktzb>\n");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "b-qvj97oktzb");
            __builder.AddMarkupContent(88, "<h6 b-qvj97oktzb>Shipping Address:</h6>\n    ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "input-group mb-3");
            __builder.AddAttribute(91, "b-qvj97oktzb");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "input-group-prepend");
            __builder.AddAttribute(94, "b-qvj97oktzb");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "class", "btn btn-primary");
            __builder.AddAttribute(97, "disabled", 
#nullable restore
#line 53 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                                       IsDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(98, "type", "button");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                                                                           w

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "b-qvj97oktzb");
            __builder.AddContent(101, "Pay via ");
            __builder.AddMarkupContent(102, "<b b-qvj97oktzb>COD</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n        ");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "type", "text");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.AddAttribute(107, "placeholder", "");
            __builder.AddAttribute(108, "aria-label", "");
            __builder.AddAttribute(109, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Reviewshipping.razor"
                                                        shipping

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipping = __value, shipping));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(112, "b-qvj97oktzb");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\n<br b-qvj97oktzb>\n<br b-qvj97oktzb>\n<br b-qvj97oktzb>\n\n\n\n");
            __builder.AddMarkupContent(114, "<div id=\"smart-button-container\" b-qvj97oktzb><div style=\"text-align: center;\" b-qvj97oktzb><div id=\"paypal-button-container\" b-qvj97oktzb></div></div></div>");
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
                discounterstatement = discounterstatement + " - " + "Saved: ₱" + y;
                totalbind = Math.Round(totalbind - y, 2);
                Console.WriteLine(discounterstatement);
                ToastService.ShowSuccess("Save" + "₱" + y, "VOUCHER APPLIED!");


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
                discounterstatement = discounterstatement + " - " + "Saved: ₱" + y;
                totalbind = Math.Round(totalbind - y, 2);
                Console.WriteLine(discounterstatement);
                ToastService.ShowSuccess("Save" + "₱" + y, "VOUCHER APPLIED!");


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