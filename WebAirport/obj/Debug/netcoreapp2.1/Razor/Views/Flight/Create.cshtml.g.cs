#pragma checksum "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "704e8c9641372894b85e3dab83027002b66481b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_Create), @"mvc.1.0.view", @"/Views/Flight/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flight/Create.cshtml", typeof(AspNetCore.Views_Flight_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704e8c9641372894b85e3dab83027002b66481b6", @"/Views/Flight/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5d7e546c6ed48ae2c1c54b213cd78a51b2ddfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAirport.Models.CodeFirst.Flight>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
  
    ViewBag.Title = "Добавление рейса";

#line default
#line hidden
            BeginContext(91, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(105, 41, false);
#line 7 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
Write(Html.ActionLink("Список рейсов", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(146, 64, true);
            WriteLiteral("\r\n</div>\r\n\r\n<h2>Добавление рейса</h2>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(211, 28, false);
#line 13 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(239, 38, true);
            WriteLiteral("\r\n    <div class=\"col-md-8\">\r\n        ");
            EndContext();
            BeginContext(277, 2343, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dda98da7aac74569b1142450b0867202", async() => {
                BeginContext(297, 173, true);
                WriteLiteral("\r\n            <table class=\"table table-bordered\">\r\n                <tr>\r\n                    <th>Дата и время рейса</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(471, 88, false);
#line 20 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.Editor("DateTimeFlight", new { htmlAttributes = new { @type = "datetime-local" } }));

#line default
#line hidden
                EndContext();
                BeginContext(559, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(586, 56, false);
#line 21 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.DateTimeFlight));

#line default
#line hidden
                EndContext();
                BeginContext(642, 167, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Пункт вылета</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(810, 45, false);
#line 27 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.EditorFor(model => model.DeparturePoint));

#line default
#line hidden
                EndContext();
                BeginContext(855, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(882, 56, false);
#line 28 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.DeparturePoint));

#line default
#line hidden
                EndContext();
                BeginContext(938, 171, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Пункт назначения</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1110, 42, false);
#line 34 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.EditorFor(model => model.Destination));

#line default
#line hidden
                EndContext();
                BeginContext(1152, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1179, 53, false);
#line 35 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Destination));

#line default
#line hidden
                EndContext();
                BeginContext(1232, 169, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Время в полете</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1402, 76, false);
#line 41 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.Editor("TimeInFlight", new { htmlAttributes = new { @type = "time" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1478, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1505, 54, false);
#line 42 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.TimeInFlight));

#line default
#line hidden
                EndContext();
                BeginContext(1559, 167, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Тип самолета</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1727, 71, false);
#line 48 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.DropDownList("TypeAirplaneId", ViewBag.TypeAirplane as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1798, 162, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Самолет</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1961, 91, false);
#line 54 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.DropDownListFor(model => model.JobAirplane.AirplaneId, ViewBag.Airplane as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2052, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2079, 64, false);
#line 55 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.JobAirplane.AirplaneId));

#line default
#line hidden
                EndContext();
                BeginContext(2143, 160, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Пилот</th>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2304, 85, false);
#line 61 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.DropDownListFor(model => model.JobAirplane.StaffId, ViewBag.Staff as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2389, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2416, 61, false);
#line 62 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.JobAirplane.StaffId));

#line default
#line hidden
                EndContext();
                BeginContext(2477, 136, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n            <input type=\"submit\" value=\"Добавить\" />\r\n        ");
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
            BeginContext(2620, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2662, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2668, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f1d8bafbb414de0bde578fc9373b9bd", async() => {
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
                BeginContext(2743, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2749, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95221be8daee4575b16e6311871e541b", async() => {
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
                BeginContext(2843, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2849, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df76aa2c3dd041fcb7a725e11cefb1a5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2900, 223, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    $(function() {\r\n        $(\'#TypeAirplaneId\').change(function () {\r\n            var id = $(this).val();\r\n            $.ajax({\r\n                type: \'GET\',\r\n                url: \'");
                EndContext();
                BeginContext(3124, 29, false);
#line 82 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Create.cshtml"
                 Write(Url.Action("getAirplaneType"));

#line default
#line hidden
                EndContext();
                BeginContext(3153, 195, true);
                WriteLiteral("/\' + id,\r\n                success: function (data) {\r\n                    $(\'#JobAirplane_AirplaneId\').replaceWith(data);\r\n                }\r\n            });\r\n        });\r\n    })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAirport.Models.CodeFirst.Flight> Html { get; private set; }
    }
}
#pragma warning restore 1591
