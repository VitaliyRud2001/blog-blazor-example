#pragma checksum "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cadb360136fba41429e6d4736e8752baa8f33a59"
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
#nullable restore
#line 9 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
 if (_showProgressBar == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "\r\n            ");
            __Blazor.Blog_blazor.Pages.Add_post.TypeInference.CreateMatTextField_0(__builder, 6, 7, "Title of your post", 8, "Title", 9, 
#nullable restore
#line 13 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
                                                                                                                       true

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 13 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
                                        _postCreateDto.Title

#line default
#line hidden
#nullable disable
            , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _postCreateDto.Title = __value, _postCreateDto.Title)), 12, () => _postCreateDto.Title);
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "textarea");
            __builder.AddAttribute(18, "style", "width: 100%; max-width: 100%;");
            __builder.AddAttribute(19, "rows", "4");
            __builder.AddAttribute(20, "cols", "100");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
                                                                         _postCreateDto.Body

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _postCreateDto.Body = __value, _postCreateDto.Body));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n      \r\n        ");
            __builder.AddMarkupContent(25, "<p>\r\n\r\n        </p>\r\n\r\n        ");
            __builder.OpenElement(26, "p");
            __builder.OpenComponent<MatBlazor.MatButton>(27);
            __builder.AddAttribute(28, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
                                              HandleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Create post");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "p");
            __builder.OpenComponent<MatBlazor.MatButton>(34);
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
                                HandlePreviewButtonClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 26 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
             if (_showPreview==false)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(38, "                ");
                __builder2.AddMarkupContent(39, "<p>Show preview</p>\r\n");
#nullable restore
#line 29 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, "                ");
                __builder2.AddMarkupContent(41, "<p>Close preview</p>\r\n");
#nullable restore
#line 33 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(42, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
#nullable restore
#line 37 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
         if (_showPreview==true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.OpenElement(45, "p");
            __builder.AddContent(46, 
#nullable restore
#line 39 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
         (MarkupString)BodyMarkDown

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 40 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "    \r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 44 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.AddMarkupContent(51, "<h3 class=\"mat-subtitle1\">Creating post...</h3>\r\n    ");
            __builder.OpenComponent<MatBlazor.MatProgressBar>(52);
            __builder.AddAttribute(53, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 49 "D:\FastReports\Blog-Blazor-demo\Blog\Blog-blazor\Pages\Add-post.razor"
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.Blog_blazor.Pages.Add_post
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "HelperText", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "FullWidth", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
