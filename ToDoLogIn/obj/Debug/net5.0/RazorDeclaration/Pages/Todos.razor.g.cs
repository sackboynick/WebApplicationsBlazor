// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ToDoLogIn.Pages
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
#line 2 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/Pages/Todos.razor"
using ToDoLogIn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/Pages/Todos.razor"
using ToDoLogIn.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "/home/c/Desktop/RiderProjects/WebApplication/ToDoLogIn/Pages/Todos.razor"
       
    private IList<Todo> _todos,_todosToShow;
    private int? _filterById;
    private bool? _filterByStatus;

    protected override async Task OnInitializedAsync()
    {
        _todos = _todoData.GetTodos();
        _todosToShow = _todos;
    }

    private void RemoveTodo(int todoId)
    {
        Todo todoToRemove = _todos.First(t => t.TodoId == todoId);
        _todoData.RemoveTodo(todoId);
        _todos.Remove(todoToRemove);
        _todosToShow.Remove(todoToRemove);
    }

    private void CompletedChange(ChangeEventArgs changeEventArgs, Todo todo)
    {
        if (changeEventArgs.Value != null) todo.IsCompleted = (bool) changeEventArgs.Value;
        _todoData.Update(todo);
    }

    private void FilterById(ChangeEventArgs evt)
    {
        _filterById = null;
        if (evt.Value != null) 
            _filterById = int.Parse(evt.Value.ToString() ?? string.Empty);
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs evt)
    {
        _filterByStatus = null;
        try
        {
            _filterByStatus = bool.Parse(evt.Value.ToString());
        }
        catch (Exception)
        {
            // ignored
        }
        ExecuteFilter();

    }

    private void ExecuteFilter()
    {
        _todosToShow = _todos.Where(t =>
            (_filterById != null && t.UserId==_filterById || _filterById==null) && 
            (_filterByStatus!=null && t.IsCompleted==_filterByStatus || _filterByStatus==null)).ToList();
    }


    private void Edit(int id)
    {
        _navigationManager.NavigateTo($"Edit/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoData _todoData { get; set; }
    }
}
#pragma warning restore 1591
