#pragma checksum "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54866fe7f1cebbed89146292c1bad85ade84e8f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Select_Product), @"mvc.1.0.view", @"/Views/Main/Select_Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54866fe7f1cebbed89146292c1bad85ade84e8f3", @"/Views/Main/Select_Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015cdd066bf994eb59190a9eaaf57dcdaf7514f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Select_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminkaMVC.Models.Tovar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h2>Список продуктов в для интернет-заказов</h2>
    Пока ты спишь, остальные делают
<div>
    <table>
        <tr>
            <th> Номер товара</th>
            <th> Фото</th>
            <th> Название  </th>
            <th> Описание </th>
            <th> Компания</th>
            <th> Цена </th>
            <th> Количество </th>
            <th> Заказ  </th>
        </tr>
");
#nullable restore
#line 16 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td> ");
#nullable restore
#line 19 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
        Write(item.ItemCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54866fe7f1cebbed89146292c1bad85ade84e8f34703", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 556, "~/Images/", 556, 9, true);
#nullable restore
#line 20 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
AddHtmlAttributeValue("", 565, item.Image, 565, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 21 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n        <td> ");
#nullable restore
#line 22 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 23 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
        Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 24 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
        Write(item.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 25 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td><a class=\"order-button\"");
            BeginWriteAttribute("href", " href=\"", 814, "\"", 881, 1);
#nullable restore
#line 26 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
WriteAttributeValue("", 821, Url.Action("Create_Order", "Main" , new {ID=item.ItemCode}), 821, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Заказать</a></td>\r\n        <td><a class=\"order-button\"");
            BeginWriteAttribute("href", " href=\"", 937, "\"", 997, 1);
#nullable restore
#line 27 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
WriteAttributeValue("", 944, Url.Action("Edit", "Main", new {id = item.ItemCode}), 944, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Изменить</a></td>\r\n        <td><a class=\"order-button\"");
            BeginWriteAttribute("href", " href=\"", 1053, "\"", 1115, 1);
#nullable restore
#line 28 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
WriteAttributeValue("", 1060, Url.Action("Delete", "Main", new {id = item.ItemCode}), 1060, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Удалить</a></td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 31 "D:\2Praktik\Proekti\AdminkaMVC\AdminkaMVC\Views\Main\Select_Product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminkaMVC.Models.Tovar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
