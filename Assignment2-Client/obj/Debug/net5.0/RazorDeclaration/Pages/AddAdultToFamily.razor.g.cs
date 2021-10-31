// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment2_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Assignment2_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/_Imports.razor"
using Assignment2_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/Pages/AddAdultToFamily.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/Pages/AddAdultToFamily.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/Pages/AddAdultToFamily.razor"
           [Authorize(Policy = "RequireAdmin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdultToFamily/{AdultId:int}")]
    public partial class AddAdultToFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/home/c/Desktop/RiderProjects/WebApplication/Assignment2-Client/Pages/AddAdultToFamily.razor"
       
    [Parameter]
    public int AdultId { get; set; }

    private IList<Adult> _adults;
    private Family _familyToEdit;
    private int _adult;

    private bool _error;
    
    protected async override Task OnInitializedAsync()
    {
        _familyToEdit = _data.GetFamilyFromAdult(AdultId).Result;
        _adults = _data.GetAdults().Result;
        _error=true;
    }

    private void AddAdult()
    {
        bool adultAlreadyFamily = false;
        Adult adultToAdd = _data.GetAdult(_adult).Result;
        foreach (Family family in _data.GetFamilies().Result)
        {
            foreach (Adult xAdult in family.Adults)
            {
                if (xAdult.Equals(adultToAdd))
                    adultAlreadyFamily = true;
            }
        }
        if (adultAlreadyFamily)
            _error = false;
        else
        {
            _familyToEdit.Adults.Add(adultToAdd);
            _data.UpdateFamily(_familyToEdit);
            _navigationManager.NavigateTo($"FamilyInfoEdit/{AdultId}");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IData _data { get; set; }
    }
}
#pragma warning restore 1591
