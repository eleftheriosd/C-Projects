#pragma checksum "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af45f9de0ac425edff8662cab1eddd7d659049c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummary_Default))]
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
#line 1 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\_ViewImports.cshtml"
using Eshop_11_4;

#line default
#line hidden
#line 2 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\_ViewImports.cshtml"
using Eshop_11_4.Models;

#line default
#line hidden
#line 3 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\_ViewImports.cshtml"
using Eshop_11_4.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af45f9de0ac425edff8662cab1eddd7d659049c1", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba47bfdb2765e25dc7a74f32d557e9f663ff75c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary navbar-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(13, 605, true);
            WriteLiteral(@"
<style>

    .grid-container {
        display: grid;
        grid-template-columns: auto auto;
        grid-template-rows: 20px 20px;
        
    }

        .grid-container > div:nth-child(2){
            grid-area: 1/1/2/2;
        }

        .grid-container > div:nth-child(3) {
            grid-area: 2/1/3/2;
        }

        .grid-container > div:nth-child(1){
            grid-area: 1/3/2/3;
            margin-left: 15px;
            position: relative;
            top: 50%;
        }
</style>











<div class=""grid-container"">

    <div>
        ");
            EndContext();
            BeginContext(618, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af45f9de0ac425edff8662cab1eddd7d659049c15114", async() => {
                BeginContext(788, 66, true);
                WriteLiteral("\r\n\r\n            <i class=\"fas fa-shopping-basket\"></i>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
                    WriteLiteral(ViewContext.HttpContext.Request.PathAndQuery());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(858, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
            EndContext();
#line 49 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
     if (Model.Lines.Count() > 0)
    {

#line default
#line hidden
            BeginContext(916, 71, true);
            WriteLiteral("        <div>\r\n            <small class=\"navbar-text text-light\">\r\n\r\n\r\n");
            EndContext();
#line 55 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
                 if (Model.Lines.Sum(x => x.Quantity) == 1)
                {

#line default
#line hidden
            BeginContext(1067, 28, true);
            WriteLiteral("                    <span>  ");
            EndContext();
            BeginContext(1096, 32, false);
#line 57 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
                       Write(Model.Lines.Sum(x => x.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 15, true);
            WriteLiteral(" προϊόν</span> ");
            EndContext();
#line 57 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                            }
                else
                {

#line default
#line hidden
            BeginContext(1185, 8, true);
            WriteLiteral(" <span> ");
            EndContext();
            BeginContext(1194, 32, false);
#line 59 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
                    Write(Model.Lines.Sum(x => x.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 18, true);
            WriteLiteral("   προϊόντα</span>");
            EndContext();
#line 59 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                            }

#line default
#line hidden
            BeginContext(1247, 38, true);
            WriteLiteral("            </small>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1287, 83, true);
            WriteLiteral("        <div>\r\n            <small class=\"navbar-text text-light\">\r\n                ");
            EndContext();
            BeginContext(1371, 48, false);
#line 65 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
           Write(Model.ComputeTotalValue().ToString("0.00\u20AC"));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 40, true);
            WriteLiteral("\r\n            </small>\r\n        </div>\r\n");
            EndContext();
#line 68 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Shared\Components\CartSummary\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(1466, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1521, 28, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
