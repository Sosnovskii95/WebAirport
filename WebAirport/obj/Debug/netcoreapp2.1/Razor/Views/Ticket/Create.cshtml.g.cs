#pragma checksum "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1471195e990f03b9845d2ccaf2fec33dd63eea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Create), @"mvc.1.0.view", @"/Views/Ticket/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Create.cshtml", typeof(AspNetCore.Views_Ticket_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1471195e990f03b9845d2ccaf2fec33dd63eea4", @"/Views/Ticket/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5d7e546c6ed48ae2c1c54b213cd78a51b2ddfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAirport.Models.CodeFirst.Ticket>
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
#line 2 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
  
    ViewBag.Title = "Добавить билет";

#line default
#line hidden
            BeginContext(89, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(101, 42, false);
#line 6 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
Write(Html.ActionLink("Список билетов", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(143, 66, true);
            WriteLiteral("\r\n</div>\r\n<h2>Добавить новый билет</h2>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(210, 28, false);
#line 11 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(238, 38, true);
            WriteLiteral("\r\n    <div class=\"col-md-8\">\r\n        ");
            EndContext();
            BeginContext(276, 1964, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b778fe771ed448a991a7b0abefba08a", async() => {
                BeginContext(296, 175, true);
                WriteLiteral("\r\n            <table class=\"table table-bordered\">\r\n                <tr>\r\n                    <th>Фамилия Имя Отчество</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(472, 43, false);
#line 18 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.EditorFor(model => model.FIOPassenger));

#line default
#line hidden
                EndContext();
                BeginContext(515, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(542, 54, false);
#line 19 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.FIOPassenger));

#line default
#line hidden
                EndContext();
                BeginContext(596, 182, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Паспортные данные пассажира</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(779, 39, false);
#line 25 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.EditorFor(model => model.Passport));

#line default
#line hidden
                EndContext();
                BeginContext(818, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(845, 50, false);
#line 26 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Passport));

#line default
#line hidden
                EndContext();
                BeginContext(895, 174, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Должность пассажира</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1070, 48, false);
#line 32 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.EditorFor(model => model.PositionPassenger));

#line default
#line hidden
                EndContext();
                BeginContext(1118, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1145, 59, false);
#line 33 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.PositionPassenger));

#line default
#line hidden
                EndContext();
                BeginContext(1204, 171, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Место в самолете</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1376, 35, false);
#line 39 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.EditorFor(model => model.Seat));

#line default
#line hidden
                EndContext();
                BeginContext(1411, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1438, 46, false);
#line 40 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Seat));

#line default
#line hidden
                EndContext();
                BeginContext(1484, 173, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Стоимость перелета</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1658, 36, false);
#line 46 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.EditorFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1694, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1721, 47, false);
#line 47 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1768, 169, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Выбранный рейс</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1938, 76, false);
#line 53 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.DropDownListFor(model => model.FlightId, ViewBag.Flights as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2014, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2041, 50, false);
#line 54 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Ticket\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.FlightId));

#line default
#line hidden
                EndContext();
                BeginContext(2091, 142, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n            <input type=\"submit\" value=\"Добавить билет\" />\r\n        ");
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
            BeginContext(2240, 59, true);
            WriteLiteral("\r\n    </div>\r\n    <div id=\"selectFlight\"></div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2317, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2323, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c454fd8b9f44f0a7654e8af8ebfc6e", async() => {
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
                BeginContext(2398, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2404, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44d033a100444207a27379db7b61d653", async() => {
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
                BeginContext(2498, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAirport.Models.CodeFirst.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
