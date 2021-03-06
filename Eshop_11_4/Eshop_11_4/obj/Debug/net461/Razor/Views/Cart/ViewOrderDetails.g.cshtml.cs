#pragma checksum "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e199d72b841cf192e3973b0dbdf374d077ad3c9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ViewOrderDetails), @"mvc.1.0.view", @"/Views/Cart/ViewOrderDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/ViewOrderDetails.cshtml", typeof(AspNetCore.Views_Cart_ViewOrderDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e199d72b841cf192e3973b0dbdf374d077ad3c9b", @"/Views/Cart/ViewOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba47bfdb2765e25dc7a74f32d557e9f663ff75c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ViewOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eshop_11_4.Models.CartLine>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
  
    ViewData["Title"] = "ViewOrderDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 414, true);
            WriteLiteral(@"
<h1>Λεπτομέρειες Παραγγελίας</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
               Προιόν
            </th>
            <th>
                Ποσότητα
            </th>
            <th>
               Τιμή
            </th>
            <th>
                Ημερομηνία Παραγγελίας
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
          
            float sum = 0;
        

#line default
#line hidden
            BeginContext(614, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 33 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
         foreach (var item in Model)
        {
            sum = sum + item.Product.Price*item.Quantity;

#line default
#line hidden
            BeginContext(722, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(771, 47, false);
#line 38 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(818, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(874, 43, false);
#line 41 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(917, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(973, 48, false);
#line 44 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1077, 52, false);
#line 47 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 50 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(1176, 56, true);
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n<h2>\r\n    Συνολικό κόστος : ");
            EndContext();
            BeginContext(1233, 3, false);
#line 56 "C:\Users\Lefteris\source\repos\eshop\Eshop_11_4\Eshop_11_4\Views\Cart\ViewOrderDetails.cshtml"
                 Write(sum);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 13, true);
            WriteLiteral("\r\n</h2>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eshop_11_4.Models.CartLine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
