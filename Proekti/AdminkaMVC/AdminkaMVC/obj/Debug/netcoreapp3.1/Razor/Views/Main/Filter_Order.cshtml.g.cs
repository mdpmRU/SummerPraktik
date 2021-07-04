#pragma checksum "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d5bda5f47cb5ce09ddfb71d55f7e434c038a71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Filter_Order), @"mvc.1.0.view", @"/Views/Main/Filter_Order.cshtml")]
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
#line 1 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\_ViewImports.cshtml"
using AdminkaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\_ViewImports.cshtml"
using AdminkaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d5bda5f47cb5ce09ddfb71d55f7e434c038a71", @"/Views/Main/Filter_Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015cdd066bf994eb59190a9eaaf57dcdaf7514f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Filter_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminkaMVC.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Фильтрация заказов от Самойловой</h2>\r\n");
#nullable restore
#line 4 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
 using (Html.BeginForm("Filter_Order", "Main", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Продукт: ");
#nullable restore
#line 7 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
            Write(Html.DropDownList("Name_Product", "Все"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Фильтровать\" />\r\n    </p>    ");
#nullable restore
#line 9 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <tr>
        <th>
            Код товара
        </th>
        <th>
            Заказано
        </th>
        <th>
            Адрес
        </th>
        <th>
            Дата заказа
        </th>
        <th></th>
    </tr>
");
#nullable restore
#line 26 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 30 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
   Write(Html.DisplayFor(modelItem => item.ItemCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 33 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 36 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 39 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
   Write(Html.DisplayFor(modelItem => item.Order_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td><a class=\"order-button\"");
            BeginWriteAttribute("href", " href=\"", 989, "\"", 1056, 1);
#nullable restore
#line 41 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
WriteAttributeValue("", 996, Url.Action("Edit_Order", "Main", new {id = item.OrderCode}), 996, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Изменить</a></td>\r\n    <td><a class=\"order-button\"");
            BeginWriteAttribute("href", " href=\"", 1108, "\"", 1177, 1);
#nullable restore
#line 42 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
WriteAttributeValue("", 1115, Url.Action("Delete_Order", "Main", new {id = item.OrderCode}), 1115, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Удалить</a></td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 45 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Filter_Order.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminkaMVC.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591