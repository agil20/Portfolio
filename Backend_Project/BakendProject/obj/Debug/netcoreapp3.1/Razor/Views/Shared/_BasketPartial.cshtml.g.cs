#pragma checksum "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde67d107acc5d03bf04b7d2e11a69e209ca0b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
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
#line 1 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dde67d107acc5d03bf04b7d2e11a69e209ca0b4e", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660a035cbfdd8bc190284b7642210544650f1481", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HeaderVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("      \r\n");
#nullable restore
#line 3 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_BasketPartial.cshtml"
                                   foreach (var item in @Model.BasketItems)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                              <li>
                                                <div class=""single-cart-item d-flex"">
                                                    <div class=""cart-item-thumb"">
                                                        <a href=""single-product.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dde67d107acc5d03bf04b7d2e11a69e209ca0b4e4258", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 457, "~/images/", 457, 9, true);
#nullable restore
#line 8 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_BasketPartial.cshtml"
AddHtmlAttributeValue("", 466, item.ImgUrl, 466, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                        <span class=\"product-quantity\">");
#nullable restore
#line 9 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_BasketPartial.cshtml"
                                                                                  Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </div>
                                                    <div class=""cart-item-content media-body"">
                                                        <h5 class=""product-name""><a href=""single-product.html"">");
#nullable restore
#line 12 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_BasketPartial.cshtml"
                                                                                                          Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                                        <span class=\"product-price\">€");
#nullable restore
#line 13 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_BasketPartial.cshtml"
                                                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                        <span class=""product-color""><strong>Color:</strong> White</span>
                                                        <a href=""#"" class=""product-close""><i class=""fal fa-times""></i></a>
                                                    </div>
                                                </div>             
                                             </li>
");
#nullable restore
#line 19 "C:\Users\asus\Desktop\BackentLayihesi_Proje\BakendProject\BakendProject\Views\Shared\_BasketPartial.cshtml"
                                                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HeaderVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
