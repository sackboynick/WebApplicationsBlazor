#pragma checksum "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eb5cd0596f4a2e6c9edb7e95db1b287bd520f7b"
// <auto-generated/>
#pragma warning disable 1591
namespace Bakery.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Bakery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/_Imports.razor"
using Bakery.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
using Bakery.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
using Bakery.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to Fourth Coffee!</h1>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "featuredProduct");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-8");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "alt", "Featured Product");
            __builder.AddAttribute(8, "src", "/Images/Products/" + (
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                                           FeaturedProduct.ImageName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "img-fluid rounded");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "id", "featuredProductInfo");
            __builder.AddAttribute(13, "class", "col-sm-4");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "productInfo");
            __builder.OpenElement(16, "h2");
            __builder.AddAttribute(17, "class", "m-2");
            __builder.AddContent(18, 
#nullable restore
#line 15 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                             FeaturedProduct.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "price");
            __builder.AddContent(22, "$");
            __builder.AddContent(23, 
#nullable restore
#line 16 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                               string.Format("{0:f}", @FeaturedProduct.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "description");
            __builder.AddContent(27, 
#nullable restore
#line 17 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                    FeaturedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "id", "callToAction");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "order/" + (
#nullable restore
#line 20 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                            FeaturedProduct.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "<button class=\"btn btn-sm btn-dark order-button float-right\">Order Now</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "id", "productsWrapper");
            __builder.AddAttribute(37, "class", "row");
#nullable restore
#line 27 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
     foreach (var product in Products) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-sm-3");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "asp-page", "/order");
            __builder.AddAttribute(42, "asp-route-id", 
#nullable restore
#line 29 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                                product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "title", "Order" + " " + (
#nullable restore
#line 29 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                                                          product.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "productInfo");
            __builder.OpenElement(46, "h3");
            __builder.AddContent(47, 
#nullable restore
#line 31 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                    ");
            __builder.OpenElement(49, "img");
            __builder.AddAttribute(50, "class", "product-image img-fluid img-thumbnail");
            __builder.AddAttribute(51, "src", "Images/Products/Thumbnails/" + (
#nullable restore
#line 32 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                                                                                        product.ImageName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "alt", "Image" + " of" + " " + (
#nullable restore
#line 32 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                                                                                                                          product.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n                    ");
            __builder.OpenElement(54, "p");
            __builder.AddAttribute(55, "class", "description");
            __builder.AddContent(56, 
#nullable restore
#line 33 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                            product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.OpenElement(58, "div");
            __builder.OpenElement(59, "p");
            __builder.AddAttribute(60, "class", "price float-left m-1");
            __builder.AddContent(61, "$");
            __builder.AddContent(62, 
#nullable restore
#line 37 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                                  string.Format("{0:f}", product.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n                ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-sm btn-dark order-button float-right");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
                                                                                         () => NavigateToComponent(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "\n                    Order Now\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/home/c/Desktop/RiderProjects/WebApplication/Bakery/Pages/Index.razor"
       

    public IList<Product> Products { get; set; }
    public Product FeaturedProduct { get; set; }

    protected override async Task OnInitializedAsync() {
        Products = ProductsService.Products;
        FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
    }

    private void NavigateToComponent(Product p) {
        NavigationManager.NavigateTo("order/" + p.Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
    }
}
#pragma warning restore 1591
