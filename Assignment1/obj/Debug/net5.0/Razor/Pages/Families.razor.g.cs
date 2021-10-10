#pragma checksum "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3bcdd346e528cc4ae6047af4fccee45dfd8c8bf"
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
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Families</h3>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n    Filter by Street Name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                                                           arg => FilterByStreetName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                  DeleteFilters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Delete all filters");
            __builder.CloseElement();
#nullable restore
#line 17 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
 if (_familiesToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
}
else if (!_familiesToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<p><em>No Families items exist. Please add some.</em></p>");
#nullable restore
#line 24 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "<thead><tr><th>StreetName</th>\n            <th>HouseNumber</th>\n            <th>Adults N</th>\n            <th>Children N</th>\n            <th>Pets N</th>\n            <th>Total salary</th>\n            <th>Info and edit</th></tr></thead>\n        ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 40 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
         foreach (Family item in _familiesToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 43 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                     item.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 44 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                     item.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 45 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                     item.Adults.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 46 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                     item.Children.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 47 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                     item.Pets.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 48 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                     TotalSalary(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
                                        () => Info(item.StreetName,item.HouseNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "<i class=\"oi oi-info\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/Families.razor"
       
    private IList<Family> _families, _familiesToShow;
    private string? _filterByStreetName;

    protected override async Task OnInitializedAsync()
    {
        _families = _data.GetFamilies();
        _familiesToShow = _families;
    }

    private double TotalSalary(Family family)
    {
        Adult[] earners = family.Adults.ToArray();
        double salary = 0;
        for (int i = 0; i < family.Adults.Count;i++)
            salary+=earners[i].JobTitle.Salary;
        return salary;
    }
    

    private void FilterByStreetName(ChangeEventArgs evt)
    {
        _filterByStreetName = null;
        try
        {
            if (evt.Value != null) _filterByStreetName = evt.Value.ToString();
        }
        catch (Exception)
        {
    // ignored
        }
        ExecuteFilter();

    }

    private void ExecuteFilter()
    {
        _familiesToShow = _families.Where(t => _filterByStreetName != null && t.StreetName == _filterByStreetName || _filterByStreetName == null).ToList();
    }


    private void Info(string streetName,int houseNumber)
    {
        Adult[] adults = _data.GetFamily(streetName, houseNumber).Adults.ToArray();
        int adultId = adults[0].Id;
        _navigationManager.NavigateTo($"FamilyInfoEdit/{adultId}");
    }

    private void DeleteFilters()
    {
        _familiesToShow = _families;
        _filterByStreetName = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IData _data { get; set; }
    }
}
#pragma warning restore 1591
