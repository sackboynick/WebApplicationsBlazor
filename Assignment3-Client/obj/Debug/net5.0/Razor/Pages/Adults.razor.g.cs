#pragma checksum "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d680b5eb0e28456263fc03aa78d3b2d6a79b5e40"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment3_Client.Pages
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
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
using Assignment3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
using Assignment3_Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n    Filter by Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                                                    arg => FilterById(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\n    Filter by sex:\n    ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control selectpicker");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                                                           arg => FilterBySex(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width: 100px");
            __builder.OpenElement(14, "option");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "F");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n\n");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, 
#nullable restore
#line 23 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
    _errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                  DeleteFilters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Delete all filters");
            __builder.CloseElement();
#nullable restore
#line 26 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
 if (_adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<p><em>Loading...</em></p>");
#nullable restore
#line 29 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
}
else if (!_adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<p><em>No Adults items exist. Please add some.</em></p>");
#nullable restore
#line 33 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "table");
            __builder.OpenElement(32, "thead");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "<th>Person ID</th>\n            ");
            __builder.AddMarkupContent(35, "<th>First Name</th>\n            ");
            __builder.AddMarkupContent(36, "<th>Last Name</th>\n            ");
            __builder.AddMarkupContent(37, "<th>Haircolor</th>\n            ");
            __builder.AddMarkupContent(38, "<th>Eyecolor</th>\n            ");
            __builder.AddMarkupContent(39, "<th>Age</th>\n            ");
            __builder.AddMarkupContent(40, "<th>Weight</th>\n            ");
            __builder.AddMarkupContent(41, "<th>Height</th>\n            ");
            __builder.AddMarkupContent(42, "<th>Sex</th>\n            ");
            __builder.AddMarkupContent(43, "<th>JobTitle</th>\n            ");
            __builder.AddMarkupContent(44, "<th>Salary</th>\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(45);
            __builder.AddAttribute(46, "Policy", "RequireAdmin");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(48, "<th>Edit</th>\n            ");
                __builder2.AddMarkupContent(49, "<th>Remove</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n        ");
            __builder.OpenElement(51, "tbody");
#nullable restore
#line 57 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
         foreach (Adult item in _adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "tr");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 60 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 61 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 62 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 63 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 64 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 65 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n                ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 66 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 67 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n                ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 68 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n                ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 69 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n                ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 70 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                     item.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(86);
            __builder.AddAttribute(87, "Policy", "RequireAdmin");
            __builder.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(89, "td");
                __builder2.OpenElement(90, "button");
                __builder2.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                                        () => Edit(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(92, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\n                ");
                __builder2.OpenElement(94, "td");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
                                        () => Remove(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(97, "<i class=\"oi oi-trash\" style=\"color:#1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 85 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/Adults.razor"
       
    private IList<Adult> _adults, _adultsToShow;
    private int? _filterById;
    private string _filterBySex;
    private string _errorMessage;

    protected override async Task OnInitializedAsync()
    {
        _adults = _data.GetAdults().Result;
        _adultsToShow = _adults;
        _errorMessage = "";
    }


    private void FilterById(ChangeEventArgs evt)
    {
        _filterById = null;
        try
        {
            if (evt.Value != null)
                _filterById = int.Parse(evt.Value.ToString() ?? string.Empty);
            ExecuteFilter();
            _errorMessage = "";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _errorMessage = "Please insert only legal values";
        }
        
    }

    private void DeleteFilters()
    {
        _adultsToShow = _adults;
        _filterById = null;
        _filterBySex = null;
    }
    private void FilterBySex(ChangeEventArgs evt)
    {
        _filterBySex = null;
        try
        {
            if(evt.Value!=null && evt.Value.ToString()!=" ")
            _filterBySex = evt.Value.ToString();
        }
        catch (Exception)
        {
    // ignored
        }
        ExecuteFilter();

    }

    private void ExecuteFilter()
    {
        _adultsToShow = _adults.Where(t =>
            (_filterById != null && t.Id == _filterById || _filterById == null) &&
            (_filterBySex != null && t.Sex == _filterBySex || _filterBySex == null)).ToList();
    }


    private void Edit(int id)
    {
        _navigationManager.NavigateTo($"EditAdult/{id}");
    }

    private void Remove(int itemId)
    {
        Adult adultToRemove = _adults.First((adult => adult.Id ==itemId));
        _data.RemoveAdult(itemId);
        _adults.Remove(adultToRemove);
        _adultsToShow.Remove(adultToRemove);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IData _data { get; set; }
    }
}
#pragma warning restore 1591
