#pragma checksum "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\PaginationComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0f8b79040fa79a8ef677794a4f6e75098e0be0"
// <auto-generated/>
#pragma warning disable 1591
namespace Blog_blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Blog_blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Blog_blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\_Imports.razor"
using Markdig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\PaginationComponent.razor"
using Blog_blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/paging")]
    public partial class PaginationComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .center {
        text-align: center;
    }

    .pagination {
        display: inline-block;
    }

    .pagination a {
        color: black;
        float: left;
        padding: 8px 16px;
        text-decoration: none;
        transition: background-color .3s;
        border: 1px solid #ddd;
        margin: 0 4px;
    }

    .pagination a.active {
        background-color: #4CAF50;
        color: white;
        border: 1px solid #4CAF50;
    }

    .pagination a:hover:not(.active) {background-color: #ddd;}
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "center");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "pagination");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 35 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\PaginationComponent.razor"
         for (int i = 0; i < (int) Math.Ceiling((decimal) TotalCount / PageSize); i++)
        {
            int temp = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\PaginationComponent.razor"
                           e=>Change(temp+1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, 
#nullable restore
#line 38 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\PaginationComponent.razor"
                                                 i+1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 39 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\PaginationComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\PaginationComponent.razor"
       
    [Parameter]
    public int Page { get; set; }

    [Parameter]
    public EventCallback<int> PageChanged { get; set; }

    [Parameter]
    public int PageSize { get; set; }

    [Parameter]
    public int? TotalCount { get; set; }

    public Task Change(int a)
    {
        return PageChanged.InvokeAsync(a);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
