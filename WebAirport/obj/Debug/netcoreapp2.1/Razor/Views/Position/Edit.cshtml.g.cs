#pragma checksum "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386891f6e123334554c818921b01dd16a62dbb1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Position_Edit), @"mvc.1.0.view", @"/Views/Position/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Position/Edit.cshtml", typeof(AspNetCore.Views_Position_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386891f6e123334554c818921b01dd16a62dbb1d", @"/Views/Position/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5d7e546c6ed48ae2c1c54b213cd78a51b2ddfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Position_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAirport.Models.CodeFirst.Position>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
  
    ViewBag.Title = "Редактирование должности";

#line default
#line hidden
            BeginContext(103, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(117, 47, false);
#line 8 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
Write(Html.ActionLink("Добавить должность", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(164, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(171, 45, false);
#line 9 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
Write(Html.ActionLink("Список должностей", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(216, 80, true);
            WriteLiteral("\r\n</div>\r\n\r\n<h2>Редактирование выбранной должности</h2>\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(297, 28, false);
#line 14 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(325, 38, true);
            WriteLiteral("\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(363, 1413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b4e6b2328bb45fe89ccbadfe1343827", async() => {
                BeginContext(383, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(398, 33, false);
#line 17 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(431, 163, true);
                WriteLiteral("\r\n            <table class=\"table table-bordered\">\r\n                <tr>\r\n                    <th>Название</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(595, 39, false);
#line 22 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.EditorFor(model => model.JobTitle));

#line default
#line hidden
                EndContext();
                BeginContext(634, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(661, 50, false);
#line 23 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.JobTitle));

#line default
#line hidden
                EndContext();
                BeginContext(711, 160, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Оклад</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(872, 37, false);
#line 29 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(909, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(936, 48, false);
#line 30 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(984, 166, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Обязанности</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1151, 47, false);
#line 36 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Responsibilities));

#line default
#line hidden
                EndContext();
                BeginContext(1198, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1225, 58, false);
#line 37 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Responsibilities));

#line default
#line hidden
                EndContext();
                BeginContext(1283, 165, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Требования</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1449, 43, false);
#line 43 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Requirements));

#line default
#line hidden
                EndContext();
                BeginContext(1492, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1519, 54, false);
#line 44 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Position\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Requirements));

#line default
#line hidden
                EndContext();
                BeginContext(1573, 196, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n            <input type=\"submit\" value=\"Сохранить изменения\" onclick=\"return confirm(\'Сохранить изменения?\')\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1776, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1816, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1822, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec964a31b7e64354964c6ac26817ce5d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1897, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1903, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f4e90b764fe4461816f2a82df26104c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1997, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAirport.Models.CodeFirst.Position> Html { get; private set; }
    }
}
#pragma warning restore 1591