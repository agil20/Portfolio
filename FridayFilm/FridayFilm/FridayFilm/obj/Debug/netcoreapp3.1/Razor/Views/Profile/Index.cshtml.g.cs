#pragma checksum "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ec7a9decac79332dace690aa871b605a36a8b0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ec7a9decac79332dace690aa871b605a36a8b0b", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01fef6b46a54d8b06f1c0eb862fa7be0c1c4026d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cardto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile__logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Profile\Index.cshtml"
  
	  string decimalString = "";
    decimalString = Model.AppUser.AbuneEnd.ToString("#.##");
    //string discountday="";
    //string discountmonth="";
    //string discountyear="";
    //string year="";
    //string discounthour="";
    //string hours="";
    ////if (Model.Product.DiscountUntil > DateTime.Now && Model.Product.DiscountUntil )
    ////{
    ////    discountday = Model.Product.DiscountUntil.ToString().Split('/')[1];
    ////    discountmonth = Model.Product.DiscountUntil.ToString().Split('/')[0];
    ////    discountyear = Model.Product.DiscountUntil.ToString();
    ////    year = discountyear.Substring(discountyear.LastIndexOf('/') + 1).Substring(0,4);

    ////    discounthour = Model.Product.DiscountUntil.ToString().Split(':')[0];
    ////    hours = discounthour.Substring(discounthour.Length - 2);    
    ////}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section section--first section--bg"" data-bg=""img/section/section.jpg"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-12"">
				<div class=""section__wrap"">
				
				</div>
			</div>
		</div>
	</div>
</section>

<div class=""content"">
	   
	<div class=""profile"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-12"">
					<div class=""profile__content"">
						<div class=""profile__user"">
							<div class=""profile__avatar"">
								<img src=""img/user.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1410, "\"", 1416, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"profile__meta\">\r\n\t\t\t\t\t\t\t\t<h2 class=\"username\">");
#nullable restore
#line 47 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Profile\Index.cshtml"
                                                Write(Model.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
							</div>
						</div>

					
						<ul class=""nav nav-tabs content__tabs content__tabs--profile"" id=""content__tabs"" role=""tablist"">
							<li class=""nav-item"" role=""presentation"">
								<a class=""nav-link active"" data-toggle=""tab"" href=""#tab-1"" role=""tab"" aria-controls=""tab-1"" aria-selected=""true"">Profile</a>
							</li>

								<li class=""nav-item"" role=""presentation"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ec7a9decac79332dace690aa871b605a36a8b0b8389", async() => {
                WriteLiteral("Card");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							</li>
						</ul>
		
						<div class=""content__mobile-tabs content__mobile-tabs--profile"" id=""content__mobile-tabs"">
							<div class=""content__mobile-tabs-btn dropdown-toggle"" role=""navigation"" id=""mobile-tabs"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
								<input type=""button"" value=""Profile"">
								<span></span>
							</div>

							<div class=""content__mobile-tabs-menu dropdown-menu"" aria-labelledby=""mobile-tabs"">
								<ul class=""nav nav-tabs"" role=""tablist"">
									<li class=""nav-item""><a class=""nav-link active"" id=""1-tab"" data-toggle=""tab"" href=""#tab-1"" role=""tab"" aria-controls=""tab-1"" aria-selected=""true"">Profile</a></li>
								</ul>
							</div>
						</div>

						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ec7a9decac79332dace690aa871b605a36a8b0b10537", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ec7a9decac79332dace690aa871b605a36a8b0b10812", async() => {
                    WriteLiteral(" <span>Logout</span>");
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
                WriteLiteral("\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n\t           <span class=\"timer\">");
#nullable restore
#line 84 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Profile\Index.cshtml"
                              Write(Model.AppUser.AbuneEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
			</div>

		</div>
	</div>

	<div class=""container"">
		<div class=""tab-content"" id=""myTabContent"">
			<div class=""tab-pane fade show active"" id=""tab-1"" role=""tabpanel"" aria-labelledby=""1-tab"">
				<div class=""row row--grid"">
					<div class=""col-12 col-sm-6 col-xl-3"">
						<div class=""stats"">
							<span>Premium plan</span>
							<a ><p>$");
#nullable restore
#line 97 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Profile\Index.cshtml"
                               Write(Model.AppUser.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>\r\n\t\t\t\t\t\t\t<img src=\"img/credit-card.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3511, "\"", 3517, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\r\n\t\t\t\t\t<div class=\"col-12 col-sm-6 col-xl-3\">\r\n\t\t\t\t\t\t<div class=\"stats\">\r\n\t\t\t\t\t\t\t<span>Your comments</span>\r\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 105 "C:\Users\asus\Desktop\portfolio\FridayFilm\FridayFilm\FridayFilm\Views\Profile\Index.cshtml"
                          Write(Model.Comments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<img src=\"img/comments.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3733, "\"", 3739, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\t\r\n\r\n\t\t\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591