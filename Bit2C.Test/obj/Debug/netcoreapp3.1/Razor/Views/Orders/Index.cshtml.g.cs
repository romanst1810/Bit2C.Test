#pragma checksum "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838330bb1edd9e86639ff65598f4e77005ecc777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838330bb1edd9e86639ff65598f4e77005ecc777", @"/Views/Orders/Index.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bit2C.Test.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-controller=\"Orders\" asp-action=\"Create\">Create New</a>\r\n</p>\r\n");
#nullable restore
#line 13 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
 if (!Model.Any() || Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <H2>No orders</H2>\r\n");
#nullable restore
#line 16 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 39 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1385, "\"", 1408, 1);
#nullable restore
#line 55 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1400, item.Id, 1400, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                    <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1465, "\"", 1488, 1);
#nullable restore
#line 56 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1480, item.Id, 1480, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                    <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1547, "\"", 1570, 1);
#nullable restore
#line 57 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1562, item.Id, 1562, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 64 "D:\_00 RONAN1810@GMAIL GOOGLE DRIVE BACKUP 100GB\28 Job Interview Works\Bit2C.Test\Bit2C.Test\Views\Orders\Index.cshtml"
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
