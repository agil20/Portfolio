#pragma checksum "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a71be379db0af6a65b60284c48c68d28e709074c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a71be379db0af6a65b60284c48c68d28e709074c", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01fef6b46a54d8b06f1c0eb862fa7be0c1c4026d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Bio>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<footer class=\"footer\">\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row myFooter\" >\r\n\t\t\t\r\n\t\t\t<div class=\"col-6 col-sm-4 col-md-3\">\r\n\t\t\t\t<h6 class=\"footer__title\">Resources</h6>\r\n\t\t\t\t<ul class=\"footer__list\">\r\n\t\t\t\t\t<li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a71be379db0af6a65b60284c48c68d28e709074c4954", async() => {
                WriteLiteral("Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\t\t\t\t\t<li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a71be379db0af6a65b60284c48c68d28e709074c6335", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\t\t\t\t\t<li><a href=\"faq.html\">Pricing </a></li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t\r\n\t\t\t<div class=\"col-12 col-sm-4 col-md-3\">\r\n\t\t\t\t<h6 class=\"footer__title\">Contact us </h6>\r\n\t\t\t\t<ul class=\"footer__list\">\r\n\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 608, "\"", 706, 1);
            WriteAttributeValue("", 615, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 22 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                  foreach (var item in Model)
												  {
													  

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                 Write(item.Number);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                                  
												  }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 615, 91, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 26 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                   foreach (var item in Model)
												  {
													  

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                 Write(item.Number);

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                                  
												  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t<li><a href=\"mailto:support@flixgo.com\">");
#nullable restore
#line 30 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                             foreach (var item in Model)
												  {
													  

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                 Write(item.AvtorEmail);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                                      
												  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t</ul>\r\n\t\t\t\t<ul class=\"footer__social\">\r\n\t\t\t\t\t<li class=\"facebook\"><a");
            BeginWriteAttribute("href", " href=\"", 1049, "\"", 1149, 1);
            WriteAttributeValue("", 1056, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 36 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                   foreach (var item in Model)
												  {
													  

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                 Write(item.Facebook);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                                    
												  }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1056, 93, false);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M20.9,2H3.1A1.1,1.1,0,0,0,2,3.1V20.9A1.1,1.1,0,0,0,3.1,22h9.58V14.25h-2.6v-3h2.6V9a3.64,3.64,0,0,1,3.88-4,20.26,20.26,0,0,1,2.33.12v2.7H17.3c-1.26,0-1.5.6-1.5,1.47v1.93h3l-.39,3H15.8V22h5.1A1.1,1.1,0,0,0,22,20.9V3.1A1.1,1.1,0,0,0,20.9,2Z""/></svg></a></li>
					<li class=""instagram""><a");
            BeginWriteAttribute("href", " href=\"", 1506, "\"", 1607, 1);
            WriteAttributeValue("", 1513, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 40 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                    foreach (var item in Model)
												  {
													  

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                 Write(item.Instagram);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                                     
												  }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1513, 94, false);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M17.34,5.46h0a1.2,1.2,0,1,0,1.2,1.2A1.2,1.2,0,0,0,17.34,5.46Zm4.6,2.42a7.59,7.59,0,0,0-.46-2.43,4.94,4.94,0,0,0-1.16-1.77,4.7,4.7,0,0,0-1.77-1.15,7.3,7.3,0,0,0-2.43-.47C15.06,2,14.72,2,12,2s-3.06,0-4.12.06a7.3,7.3,0,0,0-2.43.47A4.78,4.78,0,0,0,3.68,3.68,4.7,4.7,0,0,0,2.53,5.45a7.3,7.3,0,0,0-.47,2.43C2,8.94,2,9.28,2,12s0,3.06.06,4.12a7.3,7.3,0,0,0,.47,2.43,4.7,4.7,0,0,0,1.15,1.77,4.78,4.78,0,0,0,1.77,1.15,7.3,7.3,0,0,0,2.43.47C8.94,22,9.28,22,12,22s3.06,0,4.12-.06a7.3,7.3,0,0,0,2.43-.47,4.7,4.7,0,0,0,1.77-1.15,4.85,4.85,0,0,0,1.16-1.77,7.59,7.59,0,0,0,.46-2.43c0-1.06.06-1.4.06-4.12S22,8.94,21.94,7.88ZM20.14,16a5.61,5.61,0,0,1-.34,1.86,3.06,3.06,0,0,1-.75,1.15,3.19,3.19,0,0,1-1.15.75,5.61,5.61,0,0,1-1.86.34c-1,.05-1.37.06-4,.06s-3,0-4-.06A5.73,5.73,0,0,1,6.1,19.8,3.27,3.27,0,0,1,5,19.05a3,3,0,0,1-.74-1.15A5.54,5.54,0,0,1,3.86,16c0-1-.06-1.37-.06-4s0-3,.06-4A5.54,5.54,0,0,1,4.21,6.1,3,3,0,0,1,5,5,3.14,3.14,0,0,1,6.1,4.2,5.73,5.73,0,0,1,8,3.86c");
            WriteLiteral(@"1,0,1.37-.06,4-.06s3,0,4,.06a5.61,5.61,0,0,1,1.86.34A3.06,3.06,0,0,1,19.05,5,3.06,3.06,0,0,1,19.8,6.1,5.61,5.61,0,0,1,20.14,8c.05,1,.06,1.37.06,4S20.19,15,20.14,16ZM12,6.87A5.13,5.13,0,1,0,17.14,12,5.12,5.12,0,0,0,12,6.87Zm0,8.46A3.33,3.33,0,1,1,15.33,12,3.33,3.33,0,0,1,12,15.33Z""/></svg></a></li>
					<li class=""twitter""><a");
            BeginWriteAttribute("href", " href=\"", 2959, "\"", 3058, 1);
            WriteAttributeValue("", 2966, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 44 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                  foreach (var item in Model)
												  {
													  

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                 Write(item.Twitter);

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Shared\Components\Footer\Default.cshtml"
                                                                   
												  }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 2966, 92, false);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24""><path d=""M22,5.8a8.49,8.49,0,0,1-2.36.64,4.13,4.13,0,0,0,1.81-2.27,8.21,8.21,0,0,1-2.61,1,4.1,4.1,0,0,0-7,3.74A11.64,11.64,0,0,1,3.39,4.62a4.16,4.16,0,0,0-.55,2.07A4.09,4.09,0,0,0,4.66,10.1,4.05,4.05,0,0,1,2.8,9.59v.05a4.1,4.1,0,0,0,3.3,4A3.93,3.93,0,0,1,5,13.81a4.9,4.9,0,0,1-.77-.07,4.11,4.11,0,0,0,3.83,2.84A8.22,8.22,0,0,1,3,18.34a7.93,7.93,0,0,1-1-.06,11.57,11.57,0,0,0,6.29,1.85A11.59,11.59,0,0,0,20,8.45c0-.17,0-.35,0-.53A8.43,8.43,0,0,0,22,5.8Z""/></svg></a></li>
				</ul>
			</div>
		
		</div>
	</div>
</footer>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Bio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591