#pragma checksum "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "face6b46ad61741a84c7a9df1a957ae6d2e5f150"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/sellerpage")]
    public partial class Sellerpage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row d-flex justify-content-center");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-7");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card p-3 py-4");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "text-center");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 13 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
                                                         seller.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "width", "100");
            __builder.AddAttribute(13, "class", "rounded-circle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "text-center mt-3");
            __builder.AddMarkupContent(17, "<span class=\"bg-secondary p-1 px-4 rounded text-white\">Verified</span>\n                        ");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "class", "mt-2 mb-0");
#nullable restore
#line 16 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
__builder.AddContent(20, seller.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(21, " ");
            __builder.OpenElement(22, "span");
            __builder.AddMarkupContent(23, "🛒 ");
#nullable restore
#line 16 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
__builder.AddContent(24, seller.Shopname);

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, " from ");
#nullable restore
#line 16 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
__builder.AddContent(26, seller.Adresscavite);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "px-4 mt-1");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "class", "fonts small");
#nullable restore
#line 18 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
__builder.AddContent(32, seller.Bio);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "buttons");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-outline-primary px-4");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
                                                                                                     chatter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Message");
            __builder.CloseElement();
            __builder.AddContent(40, "  ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "href", 
#nullable restore
#line 20 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
                                                                                                                                          seller.IG

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "class", "btn btn-primary px-4 ms-3");
            __builder.AddMarkupContent(44, "📷 Instagram");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n\n    <hr>\n    ");
            __builder.AddMarkupContent(46, "<h3 class=\"text-center\">Artist\'s Products</h3>\n    ");
            __builder.OpenElement(47, "ul");
            __builder.AddAttribute(48, "class", "list-unstyled");
#nullable restore
#line 30 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
         foreach (var t in xprod.Where(n => n.IsPublic == true))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "class", "media my-3");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "media-img-wrapper mr-2");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", "/product/" + (
#nullable restore
#line 34 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
                                       t.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(55, "img");
            __builder.AddAttribute(56, "class", "media-img");
            __builder.AddAttribute(57, "src", 
#nullable restore
#line 35 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
                                                     t.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "alt", 
#nullable restore
#line 35 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
                                                                    t.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "media-body");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "href", "/product/" + (
#nullable restore
#line 39 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
                                       t.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(64, "h4");
            __builder.AddAttribute(65, "class", "mb-0");
#nullable restore
#line 40 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
__builder.AddContent(66, t.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                    ");
            __builder.OpenElement(68, "p");
#nullable restore
#line 42 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
__builder.AddContent(69, t.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerpage.razor"
           
        List<Product> xprod = new List<Product>();
        BlazingShop.Shared.Seller seller = new BlazingShop.Shared.Seller();
        string shopname;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                string pnp = await LocalStorage.GetItemAsync<string>("PNP");
                if (pnp == "S")
                {
                    shopname = await LocalStorage.GetItemAsync<string>("credname");
                }
                else
                {
                    shopname = await LocalStorage.GetItemAsync<string>("shopnamer");
                }




                seller = await SellerService.Sellerdet(shopname);
                xprod = await ProductService.GetProductSell(shopname);
            }
            catch
            {
                Console.WriteLine("GG");
            }
        }
        public async void chatter()
        {

            await JSRuntime.InvokeVoidAsync("initchat");
            StateHasChanged();


        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISellerService SellerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
