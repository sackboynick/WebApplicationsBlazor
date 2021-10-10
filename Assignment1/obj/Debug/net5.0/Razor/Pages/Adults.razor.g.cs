#pragma checksum "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8bf67e8d6ba36dea1a1b583bda25e56d6166c51"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
using Models;

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
#line 11 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
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
#line 16 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
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
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                  DeleteFilters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Delete all filters");
            __builder.CloseElement();
#nullable restore
#line 25 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
 if (_adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<p><em>Loading...</em></p>");
#nullable restore
#line 28 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
}
else if (!_adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<p><em>No Adults items exist. Please add some.</em></p>");
#nullable restore
#line 32 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table");
            __builder.AddMarkupContent(29, @"<thead><tr><th>Person ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Haircolor</th>
            <th>Eyecolor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>JobTitle</th>
            <th>Salary</th>
            <th>Edit</th>
            <th>Remove</th></tr></thead>
        ");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 54 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
         foreach (Adult item in _adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 57 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 58 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 59 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 60 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 61 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 62 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 63 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 64 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 65 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 66 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 67 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                     item.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n                ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                                        () => Edit(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n                ");
            __builder.OpenElement(70, "td");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
                                        () => Remove(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "<i class=\"oi oi-trash\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Adults.razor"
       
    private IList<Adult> _adults, _adultsToShow;
    private int? filterById;
    private string? filterBySex;

    protected override async Task OnInitializedAsync()
    {
        _adults = _data.GetAdults();
        _adultsToShow = _adults;
    }


    private void FilterById(ChangeEventArgs evt)
    {
        filterById = null;
        if (evt.Value != null)
            filterById = int.Parse(evt.Value.ToString() ?? string.Empty);
        ExecuteFilter();
    }

    private void DeleteFilters()
    {
        _adultsToShow = _adults;
        filterById = null;
        filterBySex = null;
    }
    private void FilterBySex(ChangeEventArgs evt)
    {
        filterBySex = null;
        try
        {
            if(evt.Value!=null && evt.Value.ToString()!=" ")
            filterBySex = evt.Value.ToString();
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
            (filterById != null && t.Id == filterById || filterById == null) &&
            (filterBySex != null && t.Sex == filterBySex || filterBySex == null)).ToList();
    }


    private void Edit(int id)
    {
        _navigationManager.NavigateTo($"EditAdult/{id}");
    }

    private void Remove(int itemId)
    {
        Adult adultToRemove = _adults.First((adult => adult.Id ==itemId));
        _data.RemoveAdult(adultToRemove);
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
