#pragma checksum "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3c5c2f9cbf2b1ce6856e6c9ed8af934d8aa9b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Areas_AdminPanel_Views_Pricing_Index), @"mvc.1.0.view", @"/Controllers/Areas/AdminPanel/Views/Pricing/Index.cshtml")]
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
#line 1 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FridayFilm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\_ViewImports.cshtml"
using FridayFilm.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3c5c2f9cbf2b1ce6856e6c9ed8af934d8aa9b1", @"/Controllers/Areas/AdminPanel/Views/Pricing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01fef6b46a54d8b06f1c0eb862fa7be0c1c4026d", @"/Controllers/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Controllers_Areas_AdminPanel_Views_Pricing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pricing>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/AdminPanel/Views/Shared/_Layout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
       <div class=""col-12 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body"">
                  <h4 class=""card-title"">Basic Table</h4>
                  <p class=""card-description"">
                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f3c5c2f9cbf2b1ce6856e6c9ed8af934d8aa9b15979", async() => {
                WriteLiteral(" Add Card");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                  </p>
                  <div class=""table-responsive"">
                    <table class=""table"">
                      <thead>
                        <tr>
                          <th>No</th>
                          <th>Price</th>
                          <th>Name</th>
                          <th>Date</th>  
                        


                    <th>Genre</th>
                          <th>Settings</th>
                        </tr>
                      </thead>
                      <tbody>
");
#nullable restore
#line 31 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
                    foreach (var item in Model)
                            {
                                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                          <td>");
#nullable restore
#line 35 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
                         Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        \r\n                        \r\n                                                       \r\n                                            <td>");
#nullable restore
#line 39 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                        \r\n                   \r\n                          <td>");
#nullable restore
#line 43 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                          \r\n                          <td>\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f3c5c2f9cbf2b1ce6856e6c9ed8af934d8aa9b19720", async() => {
                WriteLiteral(" Update ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f3c5c2f9cbf2b1ce6856e6c9ed8af934d8aa9b112059", async() => {
                WriteLiteral("<i class=\"remove ti-close\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
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
            WriteLiteral("\r\n                          </td>\r\n                        </tr>  \r\n");
#nullable restore
#line 51 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Controllers\Areas\AdminPanel\Views\Pricing\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      
                      </tbody>
                    </table>
                  </div>
                </div>
              </div>
            </div>


             <div class=""col-12 d-flex justify-content-center "" >


 </div>

</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pricing>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
