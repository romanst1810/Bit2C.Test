#pragma checksum "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f074dc0d727f669bbfce4459194d38c1921865cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_ShowOrders), @"mvc.1.0.view", @"/Views/Orders/ShowOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f074dc0d727f669bbfce4459194d38c1921865cd", @"/Views/Orders/ShowOrders.cshtml")]
    public class Views_Orders_ShowOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bit2C.Test.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Show Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Show Orders</h1>\r\n\r\n");
#nullable restore
#line 10 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
 if (!Model.Any() || Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <H2>No orders</H2>\r\n");
#nullable restore
#line 13 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("        </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 36 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 57 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 61 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\ShowOrders.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bit2C.Test.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
