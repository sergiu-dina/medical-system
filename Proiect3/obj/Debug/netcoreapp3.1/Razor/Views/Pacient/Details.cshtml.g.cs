#pragma checksum "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0d4d92bd60414b8d68b1472bbcd62e16e526ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacient_Details), @"mvc.1.0.view", @"/Views/Pacient/Details.cshtml")]
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
#line 1 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\_ViewImports.cshtml"
using Proiect3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\_ViewImports.cshtml"
using Proiect3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0d4d92bd60414b8d68b1472bbcd62e16e526ce", @"/Views/Pacient/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572268bc7f83fa4e07530a6ca89218d5e1370a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacient_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proiect3.ViewModel.PacientMedicMedicineViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pacient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details for ");
#nullable restore
#line 7 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pacient.NumePacient));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Pacient.PrenumePacient));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

<div class=""card"">
    <div class=""card-header"">
        <h4>Pacient</h4>
    </div>
    <div class=""card-body"">
        <dl class=""dl-horizontal"">
            <dt>
                Pacient Name
            </dt>
            <dd>
                ");
#nullable restore
#line 19 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pacient.NumePacient));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Pacient.PrenumePacient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                CNP\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 26 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pacient.CNP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                Adress\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 33 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pacient.Adresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                Insurance\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 40 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pacient.Asigurare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n");
#nullable restore
#line 44 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
         if (Model.Consultatii.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h5>Consultations</h5>
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Medicine Name</th>
                        <th scope=""col"">Quantity</th>
                        <th scope=""col"">Diagnostic</th>
                        <th scope=""col"">Date</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 57 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                     foreach (var item in Model.Consultatii)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 60 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(item.NumeMedicament);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 61 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(item.DozaMedicament);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 62 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(item.Diagnostic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 65 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 68 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
         if (Model.Medici.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h5>Medics</h5>
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Last Name</th>
                        <th scope=""col"">First Name</th>
                        <th scope=""col"">Specialization</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 82 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                     foreach (var item in Model.Medici)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 85 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(item.NumeMedic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 86 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(item.PrenumeMedic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 87 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(item.Specializare);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 89 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                           Write(Html.ActionLink("Details", "Details", "Medic", new { id = item.MedicId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 92 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 95 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0d4d92bd60414b8d68b1472bbcd62e16e526ce12530", async() => {
                WriteLiteral("\r\n                Edit\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "E:\Facultate\An4\Proiect 3\Proiect3\Proiect3\Views\Pacient\Details.cshtml"
                                                            WriteLiteral(Model.Pacient.PacientId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd0d4d92bd60414b8d68b1472bbcd62e16e526ce15047", async() => {
                WriteLiteral("\r\n                Back to List\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proiect3.ViewModel.PacientMedicMedicineViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591