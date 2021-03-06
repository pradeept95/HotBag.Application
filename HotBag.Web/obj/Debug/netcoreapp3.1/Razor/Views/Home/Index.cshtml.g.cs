#pragma checksum "C:\Users\prade\source\repos\HotBag.Application\HotBag.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "976f1de60888ad862c5668565cafaa18adb99c5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\prade\source\repos\HotBag.Application\HotBag.Web\Views\_ViewImports.cshtml"
using HotBag.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prade\source\repos\HotBag.Application\HotBag.Web\Views\_ViewImports.cshtml"
using HotBag.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\prade\source\repos\HotBag.Application\HotBag.Web\Views\Home\Index.cshtml"
using HotBag.AspNetCore.AppSettings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"976f1de60888ad862c5668565cafaa18adb99c5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fee941812446b70577b84a591abd2e33cd30fc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-logo-c"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/app-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\prade\source\repos\HotBag.Application\HotBag.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body{
        height: 100%;
        width : 100%;
        overflow : hidden;
    }

    img.app-logo-c {
        display: block;
        margin-left: auto;
        margin-right: auto; 
    }

    .center {
        margin-left: auto;
        margin-right: auto;
        width: 50%;
    }
</style>

<!--   Big container   -->
<div class=""container"">
    <div class=""row"">
    <div class=""col-2""></div>
        <div class=""col-8 ""> 
            <!--      Wizard container        -->
            <div class=""wizard-container"">

                <!--You can switch "" data-color=""orange"" ""  
                    with one of the next bright
                    colors: ""blue"", ""green"", ""orange"", ""red"", ""azure""  -->
                <div class=""card wizard-card"" data-color=""green"" id=""wizardProfile"">
                    <div class=""wizard-header text-center"">
                        <h3 class=""wizard-title"">");
#nullable restore
#line 39 "C:\Users\prade\source\repos\HotBag.Application\HotBag.Web\Views\Home\Index.cshtml"
                                            Write(HotBagConfiguration.Configurations.ApplicationSettings.ApplicationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"category\">Version :- ");
#nullable restore
#line 40 "C:\Users\prade\source\repos\HotBag.Application\HotBag.Web\Views\Home\Index.cshtml"
                                                  Write(HotBagConfiguration.Configurations.ApplicationSettings.ApplicationVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div> 

                    <div class=""row center"">
                        <div class=""btn-group btn-group-toggle"">
                            <label class=""btn btn-secondary"">
                                <a href=""/Admin""  target=""_blank"">Go To Admin Page</a>
                            </label>
                            <label class=""btn btn-secondary"">
                                <a href=""/swagger""  target=""_blank"">Api Documents</a> 
                            </label>
                            <label class=""btn btn-secondary"">
                                <a href=""/"">Refresh Page</a> 
                            </label>
                        </div>
                    </div>

                    <div class=""row""> 
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "976f1de60888ad862c5668565cafaa18adb99c5f6740", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div> <!-- wizard container -->\r\n        </div>\r\n    </div><!-- end row -->\r\n</div>\r\n<!--  big container -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
