#pragma checksum "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1fa33fa07738d0e759d515ad576f6d2d1eae704cae965d2199c5f0169cca4cee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentListByBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentListByBlog/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1fa33fa07738d0e759d515ad576f6d2d1eae704cae965d2199c5f0169cca4cee", @"/Views/Shared/Components/CommentListByBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentListByBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Comment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/Web/images/t1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"comment-top\">\r\n\t<h4>Yorumlar</h4>\r\n");
#nullable restore
#line 6 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml"
  if (Model.Count()==0)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<h3 class=\"mt-0\">Daha önce yorum yapılmamış.</h3>\n");
#nullable restore
#line 9 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml"
	}
	else{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml"
   foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"media\">\r\n\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1fa33fa07738d0e759d515ad576f6d2d1eae704cae965d2199c5f0169cca4cee5349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t<h5 class=\"mt-0\">");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml"
                 Write(item.CommentUserNamer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t");
#nullable restore
#line 19 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml"
 Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</p>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n");
#nullable restore
#line 24 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\LENOVO\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CommentListByBlog\Default.cshtml"
   
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591