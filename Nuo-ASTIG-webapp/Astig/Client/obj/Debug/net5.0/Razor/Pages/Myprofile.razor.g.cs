#pragma checksum "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f350b7cc30c502401803b39a383342f2ca7df4e2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/myprofile")]
    public partial class Myprofile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container rounded bg-white mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4 border-right");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex flex-column align-items-center text-center p-3 py-5");
            __builder.AddMarkupContent(8, "<img class=\"rounded-circle mt-5\" src=\"img/user.jpg\" width=\"90\">");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "font-weight-bold");
#nullable restore
#line 9 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
__builder.AddContent(11, customers.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "text-black-50");
#nullable restore
#line 9 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
__builder.AddContent(14, customers.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(15, "span");
            __builder.AddContent(16, "LVL. ");
#nullable restore
#line 9 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
__builder.AddContent(17, customers.Lvl);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-8");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "p-3 py-5");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "d-flex justify-content-between align-items-center mb-3");
            __builder.AddMarkupContent(25, "<div class=\"d-flex flex-row align-items-center back\"><i class=\"fa fa-long-arrow-left mr-1 mb-1\"></i>\n                        <h6>My profile</h6></div>\n                    ");
            __builder.OpenElement(26, "h6");
            __builder.AddAttribute(27, "class", "text-right");
            __builder.AddMarkupContent(28, "• Date Joined: ");
#nullable restore
#line 18 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
__builder.AddContent(29, customers.DateCreated);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.AddMarkupContent(31, "<h6 class=\"text-left\">You can send a profile change request to the admins.</h6>\n                ");
            __builder.AddMarkupContent(32, "<p class=\"text-left fonts small\">Higher level = More Fun! Click <a href=\"https://astigph.netlify.app/membership\">here</a> for more info!</p>\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row mt-2");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-6");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "placeholder", "Municipality");
            __builder.AddAttribute(41, "value", 
#nullable restore
#line 23 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
                                                                                                                     customers.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-md-6");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", 
#nullable restore
#line 24 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
                                                                                          customers.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "placeholder", "Address");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row mt-3");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-md-6");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "text");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "placeholder", "ID");
            __builder.AddAttribute(59, "value", "ID:" + " " + (
#nullable restore
#line 27 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
                                                                                                               customers.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-md-6");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "class", "form-control");
            __builder.AddAttribute(66, "value", "PHONE:" + " " + (
#nullable restore
#line 28 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
                                                                                                 customers.Phone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "placeholder", "Phone number");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n                ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "mt-5 text-right");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-primary profile-button");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
                                                                                                      chatterx

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "type", "button");
            __builder.AddContent(75, "Contact Admin");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\VVS\Downloads\Compressed\ProductionAstig-master\BlazingShop\Client\Pages\Myprofile.razor"
       

    BlazingShop.Shared.Customer customers = new BlazingShop.Shared.Customer();
    protected override async Task OnInitializedAsync()
    {

        string pnp;
        pnp = await LocalStorage.GetItemAsync<string>("PNP");
        if (pnp != "C")
        {
            NavigationManager.NavigateTo("login");

        }
        Console.WriteLine("Profile");
        string e = await LocalStorage.GetItemAsync<string>("credem");
        string p = await LocalStorage.GetItemAsync<string>("credhash");
        customers = await CustomerService.LoginCustomer(e, p);



    }

    public async void chatterx()
    {

        await JSRuntime.InvokeVoidAsync("initalk");
        StateHasChanged();


    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService CustomerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
