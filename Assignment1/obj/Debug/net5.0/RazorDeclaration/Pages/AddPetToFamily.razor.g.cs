// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/AddPetToFamily.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/AddPetToFamily.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPetToFamily/{AdultId:int}")]
    public partial class AddPetToFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/home/c/Desktop/RiderProjects/WebApplication/Assignment1/Pages/AddPetToFamily.razor"
       
    
    [Parameter]
    public int AdultId { get; set; }
    
    private string _petName, _petSpecie;
    private int _petAge;
    
    private Family _familyToEdit;

    private Pet newPet;

    protected override async Task OnInitializedAsync()
    {
        _familyToEdit = _data.GetFamilyFromAdult(AdultId);
        newPet= new Pet();
    }


    private void AddNewPet()
    {
        newPet.Id = _familyToEdit.Pets.Count;
        _familyToEdit.Pets.Add(newPet);
        _navigationManager.NavigateTo($"FamilyInfoEdit/{AdultId}");
        _data.UpdateFamily(_familyToEdit);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IData _data { get; set; }
    }
}
#pragma warning restore 1591