#pragma checksum "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d89cae7d555f3f09e3d28e6a634154979a3795"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_Delete), @"mvc.1.0.view", @"/Views/Flight/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flight/Delete.cshtml", typeof(AspNetCore.Views_Flight_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d89cae7d555f3f09e3d28e6a634154979a3795", @"/Views/Flight/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f5d7e546c6ed48ae2c1c54b213cd78a51b2ddfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAirport.Models.CodeFirst.Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
  
    ViewBag.Title = "Удаление рейса";

#line default
#line hidden
            BeginContext(102, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(114, 42, false);
#line 6 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
Write(Html.ActionLink("Добавить рейс", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(156, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(163, 41, false);
#line 7 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
Write(Html.ActionLink("Список рейсов", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(204, 123, true);
            WriteLiteral("\r\n</div>\r\n\r\n<h2>Список связанных билетов с выбранным рейсом</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(327, 1277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ada803c6567441099db889cc6e06195f", async() => {
                BeginContext(347, 63, true);
                WriteLiteral("\r\n            <p>\r\n                Выбранный рейс на удаление: ");
                EndContext();
                BeginContext(411, 36, false);
#line 16 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                                       Write(ViewBag.currentFlight.DeparturePoint);

#line default
#line hidden
                EndContext();
                BeginContext(447, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(451, 33, false);
#line 16 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                                                                               Write(ViewBag.currentFlight.Destination);

#line default
#line hidden
                EndContext();
                BeginContext(484, 43, true);
                WriteLiteral("\r\n                <input type=\"text\" hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 527, "\"", 560, 1);
#line 17 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
WriteAttributeValue("", 535, ViewBag.currentFlight.Id, 535, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(561, 310, true);
                WriteLiteral(@" name=""currentId"" />
            </p>
            <table class=""table table-bordered table-hover"">
                <tr>
                    <th>Фамилия Имя Отчество</th>
                    <th>Место</th>
                    <th>Цена</th>
                    <th>Новый рейс</th>
                </tr>
");
                EndContext();
#line 26 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                 foreach (var ticket in Model)
                {

#line default
#line hidden
                BeginContext(938, 50, true);
                WriteLiteral("                    <tr>\r\n                        ");
                EndContext();
                BeginContext(989, 55, false);
#line 29 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                   Write(Html.HiddenFor(model => ticket.Id, new { Name = "Id" }));

#line default
#line hidden
                EndContext();
                BeginContext(1044, 30, true);
                WriteLiteral("\r\n                        <td>");
                EndContext();
                BeginContext(1075, 19, false);
#line 30 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                       Write(ticket.FIOPassenger);

#line default
#line hidden
                EndContext();
                BeginContext(1094, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1130, 11, false);
#line 31 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                       Write(ticket.Seat);

#line default
#line hidden
                EndContext();
                BeginContext(1141, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1177, 12, false);
#line 32 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                       Write(ticket.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1189, 65, true);
                WriteLiteral("</td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1255, 109, false);
#line 34 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                       Write(Html.DropDownList("FlightId", new SelectList(ViewBag.Flights, "Id", "Description", ViewBag.currentFlight.Id)));

#line default
#line hidden
                EndContext();
                BeginContext(1364, 60, true);
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 37 "D:\Project_C#\Web\WebAirport\WebAirport\Views\Flight\Delete.cshtml"
                }

#line default
#line hidden
                BeginContext(1443, 154, true);
                WriteLiteral("            </table>\r\n            <input type=\"submit\" value=\"Сохранить изменения\" onclick=\"return confirm(\'Сохранить изменения и удалить?\')\" />\r\n        ");
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
            BeginContext(1604, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAirport.Models.CodeFirst.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
