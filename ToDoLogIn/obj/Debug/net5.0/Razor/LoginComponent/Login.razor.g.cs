#pragma checksum "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "064d56bc0f97ff8494bf01fbb3c182ebc85fb220"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoLogIn.LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using ToDoLogIn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/_Imports.razor"
using ToDoLogIn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor"
using ToDoLogIn.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "form-group");
                __builder2.AddMarkupContent(4, "<label>Username:</label>\n            ");
                __builder2.OpenElement(5, "input");
                __builder2.AddAttribute(6, "type", "text");
                __builder2.AddAttribute(7, "placeholder", "username");
                __builder2.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor"
                                                                   _username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label>Password</label>\n            ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "password");
                __builder2.AddAttribute(16, "placeholder", "password");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor"
                                                                       _password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "style", "color:red");
                __builder2.AddContent(22, 
#nullable restore
#line 18 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor"
                                _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.OpenElement(24, "a");
                __builder2.AddAttribute(25, "href", "");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor"
                             PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(27, "\n            Login\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(28, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "href", "");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "\n            Log out\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/LoginComponent/Login.razor"
       
    private string _username;
    private string _password;
    private string _errorMessage;
    public async Task PerformLogin() {
        _errorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) _authenticationStateProvider).ValidateLogin(_username, _password);
            _username = "";
            _password = "";
            _navigationManager.NavigateTo("/");
        } catch (Exception e) {
            _errorMessage = e.Message;
        }
    }
    public async Task PerformLogout() {
        _errorMessage = "";
        _username = "";
        _password = "";
        try {
            ((CustomAuthenticationStateProvider) _authenticationStateProvider).Logout();
            _navigationManager.NavigateTo("/");
        }
        catch (Exception)
        {
            // ignored
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
