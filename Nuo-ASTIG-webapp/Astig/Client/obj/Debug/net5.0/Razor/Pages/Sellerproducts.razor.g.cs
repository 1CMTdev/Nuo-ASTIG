#pragma checksum "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631c32e7157498536a779cad102347f221806100"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/productmanagement")]
    public partial class Sellerproducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-lg-center\">PRODUCT MANAGEMENT</h3>\n\n");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "list-unstyled");
#nullable restore
#line 12 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
     foreach (var t in xprod)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", "media my-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "media-img-wrapper mr-2");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "media-img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 16 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
                                         t.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt", 
#nullable restore
#line 16 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
                                                        t.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "media-body");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "/product/" + (
#nullable restore
#line 19 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
                               t.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(16, "h4");
            __builder.AddAttribute(17, "class", "mb-0");
#nullable restore
#line 20 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
__builder.AddContent(18, t.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-outline-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
                                                               () => DeleteItem(t)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 22 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
__builder.AddContent(23, tester(t.IsPublic));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Created: ");
#nullable restore
#line 23 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
__builder.AddContent(27, t.DateCreated);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, "Sold: ");
#nullable restore
#line 24 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
__builder.AddContent(31, t.Sad);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, "Stock: ");
#nullable restore
#line 25 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
__builder.AddContent(35, t.Stock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "input-group mb-3");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "input-group-prepend");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
                                                                              () => stockmane(t)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Update Stock Count:");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "number");
            __builder.AddAttribute(49, "placeholder", "Product count");
            __builder.AddAttribute(50, "aria-label", "");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "aria-describedby", "basic-addon1");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
                                             x

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => x = __value, x, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n            <hr>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Sellerproducts.razor"
       
    int x;
    public string tester(bool x)
    {
        if (x == true){
            return "Unlist";
        }
        else
            return "Relist";
    }



    List<Product> xprod = new List<Product>();
    string shopname;
    protected override async Task OnInitializedAsync()
    {

        string pnp;
        pnp = await LocalStorage.GetItemAsync<string>("PNP");
        if (pnp != "S")
        {
            NavigationManager.NavigateTo("login");
        }
        shopname = await LocalStorage.GetItemAsync<string>("credname");
        xprod = await ProductService.GetProductSell(shopname);




    }


    private async Task stockmane(Product item)
    {
        try
        {
            await ProductService.Stockupdater(item.Id, x);
            NavigationManager.NavigateTo("productmanagement", forceLoad: true);
        }
        catch
        {
            ToastService.ShowError("Check your input", "ERROR");
        }
    }



    private async Task DeleteItem(Product item)
    {
        if (item.IsPublic == true)
        {
            await ProductService.Listingupdater(item.Id, false);
            ToastService.ShowError(item.Title, "Product Unlisted!");
            StateHasChanged();
        }
        else
        {
            await ProductService.Listingupdater(item.Id, true);
            ToastService.ShowSuccess(item.Title, "Product Relisted!");
            StateHasChanged();
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISellerService SellerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591