#pragma checksum "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "610107c52568d9a93eff1fc3ea69eb3d8068f046"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "text-lg-center");
            __builder.AddContent(2, "Welcome to the ");
#nullable restore
#line 12 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor"
__builder.AddContent(3, category.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " section!");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n                ");
            __builder.OpenComponent<BlazingShop.Client.Shared.ProductList>(6);
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor"
 }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, @"<div class=""card mb-3""><img class=""card-img-top"" src=""img/card1.jpg"" alt=""Card image cap"">
    <div class=""card-body""><h3 class=""card-title"">LONG LIVE FILIPINO ARTISTS!</h3>
        <p class=""card-text"">Astig Ph is a Web-based Consumer to Consumer Marketplace for Filipino Artworks and Artistic Services.</p>
        <p class=""card-text""><small class=""text-muted"">Develop by Null Object (DLSU-D)</small></p></div></div>");
#nullable restore
#line 24 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor"
       //card------------------------------------------------- group

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, @"<div class=""card-deck""><div class=""card""><img class=""card-img-top"" src=""img/deck1.jpg"" alt=""Card image cap"">
        <div class=""card-body""><h5 class=""card-title"">VOUCHERS & DISCOUNTS!</h5>
            <p class=""card-text"">Exclusive memberships and vouchers for customers! Have fun shopping and art collenting.</p>
            <a href=""https://astigph.netlify.app/membership"" class=""btn btn-secondary mx-auto d-block"">Membership FAQs</a></div></div>
    <div class=""card""><img class=""card-img-top"" src=""img/deck2.jpg"" alt=""Card image cap"">
        <div class=""card-body""><h5 class=""card-title"">ARTS FOR EVERYONE</h5>
            <p class=""card-text"">Buy arts from verified local artists.Dedicated and master of their crafts.</p>
            <a href=""cregistration"" class=""btn btn-secondary mx-auto d-block"">Register Customer Account</a></div></div>
    <div class=""card""><img class=""card-img-top"" src=""img/deck3.jpg"" alt=""Card image cap"">
        <div class=""card-body""><h5 class=""card-title"">COLOR THE WORLD</h5>
            <p class=""card-text"">Start earning with your artistic talent. Expand your horizons! A full creative freedom!</p>
            <a href=""sregistration"" class=""btn btn-secondary mx-auto d-block"">Register Seller Account</a></div></div></div>");
#nullable restore
#line 50 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor"
       //card------------------------------------------------- group

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<br><br> <hr>\n                                ");
            __builder.AddMarkupContent(10, "<h1>Top-Picks</h1>\n                                 ");
            __builder.OpenComponent<BlazingShop.Client.Shared.ProductList>(11);
            __builder.CloseComponent();
#nullable restore
#line 53 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor"
                                                               }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Index.razor"
  [Parameter]
    public string CategoryUrl { get; set; }

    private Category category = null;

    protected override async Task OnParametersSetAsync()
    {
        await ProductService.LoadProducts(CategoryUrl);

        if (CategoryUrl != null)
        {

            category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
        }
        else
        {
            category = null;
        }

        StateHasChanged();
        await StatsService.IncrementVisits();
        await StatsService.GetVisits();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStatsService StatsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
