#pragma checksum "C:\Users\agilakh\Source\Repos\FrontToBack6\FrontToBack\FrontToBack\Areas\AdminPanel\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b26d61c3a140e6b643f5f3914f973687472f5eba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\agilakh\Source\Repos\FrontToBack6\FrontToBack\FrontToBack\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agilakh\Source\Repos\FrontToBack6\FrontToBack\FrontToBack\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26d61c3a140e6b643f5f3914f973687472f5eba", @"/Areas/AdminPanel/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d802302333453ead15e350611ef87235e768071", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\agilakh\Source\Repos\FrontToBack6\FrontToBack\FrontToBack\Areas\AdminPanel\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/AdminPanel/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
         <div class=""col-md-6 d-flex align-items-stretch"">
              <div class=""row"">
                <div class=""col-md-12 grid-margin stretch-card"">
                  <div class=""card"">
                    <div class=""card-body"">
                      <h4 class=""card-title"">");
#nullable restore
#line 12 "C:\Users\agilakh\Source\Repos\FrontToBack6\FrontToBack\FrontToBack\Areas\AdminPanel\Views\Product\Detail.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    \r\n                      <p>\r\n                 ");
#nullable restore
#line 15 "C:\Users\agilakh\Source\Repos\FrontToBack6\FrontToBack\FrontToBack\Areas\AdminPanel\Views\Product\Detail.cshtml"
            Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      </p>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n            \r\n              </div>\r\n            </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
