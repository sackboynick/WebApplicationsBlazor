#pragma checksum "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99fb0815cbea240b2bd854487734810aebc09a1f"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment3_Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/_Imports.razor"
using Assignment3_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Shared/MainLayout.razor"
using Assignment3_Client.LoginComponent;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-um1j728o01");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-um1j728o01");
            __builder.OpenElement(6, "NavMenu");
            __builder.AddAttribute(7, "b-um1j728o01");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-um1j728o01");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "top-row px-4");
            __builder.AddAttribute(14, "b-um1j728o01");
            __builder.AddMarkupContent(15, "<br b-um1j728o01><br b-um1j728o01>\n            ");
            __builder.OpenComponent<Assignment3_Client.LoginComponent.Login>(16);
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.AddMarkupContent(18, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-um1j728o01>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "content px-4");
            __builder.AddAttribute(22, "b-um1j728o01");
            __builder.AddContent(23, 
#nullable restore
#line 18 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591