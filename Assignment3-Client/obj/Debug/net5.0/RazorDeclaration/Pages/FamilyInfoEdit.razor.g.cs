// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/FamilyInfoEdit.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/FamilyInfoEdit.razor"
using Assignment3_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/FamilyInfoEdit.razor"
using Assignment3_Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FamilyInfoEdit/{AdultId:int}")]
    public partial class FamilyInfoEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 127 "/home/c/Desktop/RiderProjects/WebApplication/Assignment3-Client/Pages/FamilyInfoEdit.razor"
       
    [Parameter]
    public int AdultId { get; set; }

    private string _streetName;
    private int _houseNumber;

    private bool _addAdult, _addChild, _addPet;

    private Family _familyToEdit;
    private IList<Adult> _adults;
    private IList<Child> _children;
    private IList<Pet> _pets;

    protected override async Task OnInitializedAsync()
    {
        _familyToEdit = _data.GetFamilyFromAdult(AdultId).Result;
        _streetName = _familyToEdit.StreetName;
        _houseNumber = _familyToEdit.HouseNumber;

        _adults = _familyToEdit.Adults.ToList();
        _children = _familyToEdit.Children.ToList();
        _pets = _familyToEdit.Pets.ToList();

        _addAdult = _adults.Count == 2;
        _addChild = _children.Count == 7;
        _addPet = _pets.Count == 3;
    }

    private string ListToString<T>(List<T> list)
    {
        string result = "";
        foreach (T x in list)
        {
            result += x+"\n----------\n\n";
        }
        return result;
    }

    private void OpenAddAdultPage()
    {
        _navigationManager.NavigateTo($"AddAdultToFamily/{AdultId}");
    }
    private void OpenAddChildPage()
    {
        _navigationManager.NavigateTo($"AddChildToFamily/{AdultId}");
    }
    private void OpenAddPetPage()
    {
        _navigationManager.NavigateTo($"AddPetToFamily/{AdultId}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IData _data { get; set; }
    }
}
#pragma warning restore 1591
