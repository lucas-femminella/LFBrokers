#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179b538059e16e55f26943e1f364ec3f29ec6853"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Polizas_Delete), @"mvc.1.0.view", @"/Views/Polizas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Polizas/Delete.cshtml", typeof(AspNetCore.Views_Polizas_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179b538059e16e55f26943e1f364ec3f29ec6853", @"/Views/Polizas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Polizas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LFbrokersV2.Models.Poliza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 167, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Poliza</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 42, false);
#line 15 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(332, 38, false);
#line 18 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(370, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(414, 50, false);
#line 21 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CantidadCuotas));

#line default
#line hidden
            EndContext();
            BeginContext(464, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(508, 46, false);
#line 24 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CantidadCuotas));

#line default
#line hidden
            EndContext();
            BeginContext(554, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(598, 55, false);
#line 27 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductoAseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(653, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(697, 51, false);
#line 30 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductoAseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(748, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(792, 55, false);
#line 33 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RecargosFinancieros));

#line default
#line hidden
            EndContext();
            BeginContext(847, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(891, 51, false);
#line 36 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RecargosFinancieros));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(986, 45, false);
#line 39 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Impuestos));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1075, 41, false);
#line 42 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Impuestos));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1160, 49, false);
#line 45 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1253, 45, false);
#line 48 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1342, 45, false);
#line 51 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1431, 41, false);
#line 54 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1516, 48, false);
#line 57 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1608, 44, false);
#line 60 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1696, 49, false);
#line 63 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1789, 45, false);
#line 66 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1878, 47, false);
#line 69 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1969, 43, false);
#line 72 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2056, 47, false);
#line 75 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2103, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2147, 43, false);
#line 78 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2190, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2234, 47, false);
#line 81 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2325, 43, false);
#line 84 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2412, 49, false);
#line 87 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VigenciaDesde));

#line default
#line hidden
            EndContext();
            BeginContext(2461, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2505, 45, false);
#line 90 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VigenciaDesde));

#line default
#line hidden
            EndContext();
            BeginContext(2550, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2594, 49, false);
#line 93 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VigenciaHasta));

#line default
#line hidden
            EndContext();
            BeginContext(2643, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2687, 45, false);
#line 96 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VigenciaHasta));

#line default
#line hidden
            EndContext();
            BeginContext(2732, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2776, 45, false);
#line 99 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2865, 41, false);
#line 102 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2950, 48, false);
#line 105 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(2998, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3042, 44, false);
#line 108 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumeroPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(3086, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3130, 54, false);
#line 111 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MotivoRecotizacion));

#line default
#line hidden
            EndContext();
            BeginContext(3184, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3228, 50, false);
#line 114 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MotivoRecotizacion));

#line default
#line hidden
            EndContext();
            BeginContext(3278, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3322, 52, false);
#line 117 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AgenteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3374, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3418, 58, false);
#line 120 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AgenteNavigation.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(3476, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3520, 53, false);
#line 123 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ClienteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(3573, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3617, 59, false);
#line 126 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ClienteNavigation.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(3676, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3714, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb7d8e4c057453887ea3e14fe2a6a7d", async() => {
                BeginContext(3740, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3750, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5588799c208b4a5cbc6fcef993a95919", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 131 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Polizas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3786, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3870, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "398506cd930f47cb83cec538ef82b316", async() => {
                    BeginContext(3892, 12, true);
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
                BeginContext(3908, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3921, 10, true);
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
