#pragma checksum "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16bedf2b0322c9f92b99091ae7352ed27d20ce0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Position_Index), @"mvc.1.0.view", @"/Views/Position/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Position/Index.cshtml", typeof(AspNetCore.Views_Position_Index))]
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
#line 1 "D:\Project_C#\Web\WebAirport\WebAirport\Views\_ViewImports.cshtml"
using WebAirport;

#line default
#line hidden
#line 2 "D:\Project_C#\Web\WebAirport\WebAirport\Views\_ViewImports.cshtml"
using WebAirport.Models;

#line default
#line hidden
#line 1 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16bedf2b0322c9f92b99091ae7352ed27d20ce0e", @"/Views/Position/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5d7e546c6ed48ae2c1c54b213cd78a51b2ddfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Position_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<WebAirport.Models.CodeFirst.Position>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
  
    ViewBag.Title = "Список должностей";

#line default
#line hidden
            BeginContext(159, 169, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-offset-4\">\r\n        <h2>Список должностей</h2>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(329, 47, false);
#line 17 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
   Write(Html.ActionLink("Добавить должность", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(376, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(387, 45, false);
#line 18 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
   Write(Html.ActionLink("Список должностей", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(432, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(482, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c81bcd3dcac146c1a63a759f118e9762", async() => {
                BeginContext(488, 95, true);
                WriteLiteral("\r\n            <label>Название должности</label>\r\n            <input type=\"text\" name=\"JobTitle\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 583, "\"", 608, 1);
#line 23 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
WriteAttributeValue("", 591, ViewBag.JobTitle, 591, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(609, 70, true);
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Фильтровать\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(686, 355, true);
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-bordered table-hover"">
            <tr>
                <th>Название</th>
                <th>Оклад</th>
                <th>Обязанности</th>
                <th>Требования</th>
                <th colspan=""2"">Функции</th>
            </tr>
");
            EndContext();
#line 39 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
            BeginContext(1095, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1142, 10, false);
#line 42 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
                   Write(p.JobTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1184, 8, false);
#line 43 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
                   Write(p.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1224, 18, false);
#line 44 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
                   Write(p.Responsibilities);

#line default
#line hidden
            EndContext();
            BeginContext(1242, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1274, 14, false);
#line 45 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
                   Write(p.Requirements);

#line default
#line hidden
            EndContext();
            BeginContext(1288, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1320, 54, false);
#line 46 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
                   Write(Html.ActionLink("Редактировать", "Edit", new { p.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1406, 98, false);
#line 47 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
                   Write(Html.ActionLink("Удалить", "Delete", new { p.Id }, new { onclick = "return confirm('Удалить?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1549, 59, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n<br />\r\n    Страница ");
            EndContext();
            BeginContext(1610, 57, false);
#line 54 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
         Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1668, 4, true);
            WriteLiteral(" из ");
            EndContext();
            BeginContext(1673, 15, false);
#line 54 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
                                                                        Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(1697, 87, false);
#line 56 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page, ViewBag.JobTitle })));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<WebAirport.Models.CodeFirst.Position>> Html { get; private set; }
    }
}
#pragma warning restore 1591
