#pragma checksum "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36eb050c1e00d6e5986360c90ab95f4775f6afbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ShowMorePartial), @"mvc.1.0.view", @"/Views/Shared/ShowMorePartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\_ViewImports.cshtml"
using FridayFilm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\_ViewImports.cshtml"
using FridayFilm.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36eb050c1e00d6e5986360c90ab95f4775f6afbe", @"/Views/Shared/ShowMorePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01fef6b46a54d8b06f1c0eb862fa7be0c1c4026d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_ShowMorePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Film>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card__cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
     foreach (var item in Model)
			   {
				if (!item.IsDelete)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("   \t<div class=\"col-6 col-sm-12 col-lg-6\">\r\n\t\t\t\t\t\t<div class=\"card card--list\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36eb050c1e00d6e5986360c90ab95f4775f6afbe4465", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 285, "\"", 309, 2);
                WriteAttributeValue("", 291, "img/", 291, 4, true);
#nullable restore
#line 12 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
WriteAttributeValue("", 295, item.ImageUrl, 295, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 310, "\"", 316, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<span class=\"card__play\">\r\n\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t<div class=\"card__content\">\r\n\t\t\t\t\t\t\t\t<h3 class=\"card__title\"><a href=\"#\">");
#nullable restore
#line 18 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n\t\t\t\t\t\t\t\t<span class=\"card__category\">\r\n");
#nullable restore
#line 20 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                 foreach (var genre in item.FilmGenre)
							   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t   \t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36eb050c1e00d6e5986360c90ab95f4775f6afbe8202", async() => {
#nullable restore
#line 22 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                                                                   Write(genre.Genre.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
							   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t<div class=\"card__wrap\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"card__rate\"> ");
#nullable restore
#line 28 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                                         Write(item.IMDB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n\t\t\t\t\t\t\t\t\t<ul class=\"card__list\">\r\n\t\t\t\t\t\t\t\t\t\t<li>HD</li>\r\n\t\t\t\t\t\t\t\t\t\t<li>");
#nullable restore
#line 32 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                       Write(item.AgeLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t<div class=\"card__description\">\r\n\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 37 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
                                  Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 42 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\ShowMorePartial.cshtml"
		
	}
			   }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Film>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
