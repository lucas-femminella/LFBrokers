#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6aa771a172eee073948ef7b8cddea6d2bbee5fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personas_Index), @"mvc.1.0.view", @"/Views/Personas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personas/Index.cshtml", typeof(AspNetCore.Views_Personas_Index))]
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
#line 1 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\_ViewImports.cshtml"
using LFbrokersV2;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\_ViewImports.cshtml"
using LFbrokersV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6aa771a172eee073948ef7b8cddea6d2bbee5fe", @"/Views/Personas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Personas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LFbrokersV2.Models.Persona>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(120, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb5af85babb42e1aee8ea460f660688", async() => {
                BeginContext(143, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(250, 49, false);
#line 16 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 48, false);
#line 19 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NroDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(403, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(459, 43, false);
#line 22 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 45, false);
#line 25 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(603, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 41, false);
#line 28 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(700, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(756, 42, false);
#line 31 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Altura));

#line default
#line hidden
            EndContext();
            BeginContext(798, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(854, 40, false);
#line 34 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Piso));

#line default
#line hidden
            EndContext();
            BeginContext(894, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(950, 48, false);
#line 37 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(998, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1054, 48, false);
#line 40 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Obervaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1158, 51, false);
#line 43 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1265, 44, false);
#line 46 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1365, 43, false);
#line 49 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1464, 41, false);
#line 52 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1561, 40, false);
#line 55 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1657, 58, false);
#line 58 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodigoPostalNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1833, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1882, 48, false);
#line 67 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1986, 47, false);
#line 70 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NroDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(2033, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2089, 42, false);
#line 73 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2187, 44, false);
#line 76 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2287, 40, false);
#line 79 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2383, 41, false);
#line 82 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Altura));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2480, 39, false);
#line 85 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Piso));

#line default
#line hidden
            EndContext();
            BeginContext(2519, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2575, 47, false);
#line 88 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(2622, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2678, 47, false);
#line 91 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Obervaciones));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2781, 50, false);
#line 94 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2887, 43, false);
#line 97 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(2930, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2986, 42, false);
#line 100 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(3028, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3084, 40, false);
#line 103 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3180, 39, false);
#line 106 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(3219, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3275, 71, false);
#line 109 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodigoPostalNavigation.CodigoPostal1));

#line default
#line hidden
            EndContext();
            BeginContext(3346, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3401, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f9593f50edc4d41b782e581a238f246", async() => {
                BeginContext(3446, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3454, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3474, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1023af59098941d0b7eb0965f5db8760", async() => {
                BeginContext(3522, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3533, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3553, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40c62327f71e4056ac4e00964f787bdf", async() => {
                BeginContext(3600, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3610, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 117 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3649, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LFbrokersV2.Models.Persona>> Html { get; private set; }
    }
}
#pragma warning restore 1591
