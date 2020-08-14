#pragma checksum "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cadb360136fba41429e6d4736e8752baa8f33a59"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
using Application.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
using Markdig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
using Blog_blazor.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Add-post")]
    public partial class Add_post : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
       
    private bool _showProgressBar = false;
    private bool _showPreview = false;
    private PostCreateDto _postCreateDto = new PostCreateDto();

    private string BodyMarkDown
    {
        get
        {
            if(!String.IsNullOrEmpty(_postCreateDto.Body))
            return Markdown.ToHtml(_postCreateDto.Body);
            return String.Empty;
        }
    }

    async Task HandleClick()
    {
        _showProgressBar = true;

        _postCreateDto.BodyMarkDown = BodyMarkDown;
        _postCreateDto.UserId = 1;

        await PostService.CreatePostAsync(_postCreateDto);
        _showProgressBar = false;
    }

    void HandlePreviewButtonClick()
    {
        _showPreview = !_showPreview;
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostService PostService { get; set; }
    }
}
#pragma warning restore 1591
