#pragma checksum "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea967f68b1b42400d8e575e0a7177d6f746678c2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_MSLearn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using BlazorApp_MSLearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/_Imports.razor"
using BlazorApp_MSLearn.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Todo ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
          todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "ul");
#nullable restore
#line 6 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "li");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "checkbox");
            __builder.AddAttribute(8, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
                                      todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
                      todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "placeholder", "Something todo");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
                                           newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Add todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/andyterbovich/VS Code Projects/BlazorApp_MSLearn/Pages/Todo.razor"
 
    private List<TodoItem> todos = new();
    private string newTodo;


    private void AddTodo()
    {
        if(!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem{ Title = newTodo});
            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
