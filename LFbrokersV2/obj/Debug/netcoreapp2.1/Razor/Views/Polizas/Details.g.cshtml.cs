#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a142d1affa85c1d1650b853ae086c9c4deab66a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Polizas_Details), @"mvc.1.0.view", @"/Views/Polizas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Polizas/Details.cshtml", typeof(AspNetCore.Views_Polizas_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a142d1affa85c1d1650b853ae086c9c4deab66a4", @"/Views/Polizas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Polizas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LFbrokersV2.Models.Poliza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Poliza</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 42, false);
#line 14 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 38, false);
#line 17 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(324, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(368, 50, false);
#line 20 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CantidadCuotas));

#line default
#line hidden
            EndContext();
            BeginContext(418, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(462, 46, false);
#line 23 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CantidadCuotas));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(552, 55, false);
#line 26 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductoAseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(607, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(651, 51, false);
#line 29 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductoAseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(702, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(746, 55, false);
#line 32 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecargosFinancieros));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(845, 51, false);
#line 35 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecargosFinancieros));

#line default
#line hidden
            EndContext();
            BeginContext(896, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(940, 45, false);
#line 38 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Impuestos));

#line default
#line hidden
            EndContext();
            BeginContext(985, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1029, 41, false);
#line 41 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Impuestos));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1114, 49, false);
#line 44 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1207, 45, false);
#line 47 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1296, 45, false);
#line 50 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1385, 41, false);
#line 53 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1470, 48, false);
#line 56 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1562, 44, false);
#line 59 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1606, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1650, 49, false);
#line 62 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1743, 45, false);
#line 65 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1832, 47, false);
#line 68 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1923, 43, false);
#line 71 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2010, 47, false);
#line 74 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2101, 43, false);
#line 77 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2188, 47, false);
#line 80 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(2235, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2279, 43, false);
#line 83 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2366, 49, false);
#line 86 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VigenciaDesde));

#line default
#line hidden
            EndContext();
            BeginContext(2415, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2459, 45, false);
#line 89 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.VigenciaDesde));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2548, 49, false);
#line 92 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VigenciaHasta));

#line default
#line hidden
            EndContext();
            BeginContext(2597, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2641, 45, false);
#line 95 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.VigenciaHasta));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2730, 45, false);
#line 98 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(2775, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2819, 41, false);
#line 101 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(2860, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2904, 48, false);
#line 104 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(2952, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2996, 44, false);
#line 107 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(3040, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3084, 54, false);
#line 110 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MotivoRecotizacion));

#line default
#line hidden
            EndContext();
            BeginContext(3138, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3182, 50, false);
#line 113 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.MotivoRecotizacion));

#line default
#line hidden
            EndContext();
            BeginContext(3232, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3276, 52, false);
#line 116 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AgenteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3328, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3372, 58, false);
#line 119 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.AgenteNavigation.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(3430, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3474, 53, false);
#line 122 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClienteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3527, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3571, 59, false);
#line 125 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClienteNavigation.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(3630, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3677, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0972d128dac841daad4fc7391f343e65", async() => {
                BeginContext(3723, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 130 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(3731, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3739, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cfa571dfd5a4bdea7560c5bc01a45e5", async() => {
                BeginContext(3761, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3777, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LFbrokersV2.Models.Poliza> Html { get; private set; }
    }
}
#pragma warning restore 1591
