#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "175afedacd73d00d7edff476dad1077a64c48ef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpcionesCotizaciones_Delete), @"mvc.1.0.view", @"/Views/OpcionesCotizaciones/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OpcionesCotizaciones/Delete.cshtml", typeof(AspNetCore.Views_OpcionesCotizaciones_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"175afedacd73d00d7edff476dad1077a64c48ef2", @"/Views/OpcionesCotizaciones/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_OpcionesCotizaciones_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LFbrokersV2.Models.OpcionesCotizacion>
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 179, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>OpcionesCotizacion</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(270, 45, false);
#line 15 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(315, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(359, 41, false);
#line 18 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(400, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(444, 49, false);
#line 21 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(493, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(537, 45, false);
#line 24 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(582, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(626, 48, false);
#line 27 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(674, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(718, 44, false);
#line 30 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(762, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(806, 49, false);
#line 33 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(899, 45, false);
#line 36 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(944, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(988, 47, false);
#line 39 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1079, 43, false);
#line 42 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1166, 47, false);
#line 45 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1257, 43, false);
#line 48 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1344, 47, false);
#line 51 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1435, 43, false);
#line 54 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1522, 45, false);
#line 57 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Condicion));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1611, 41, false);
#line 60 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Condicion));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1696, 47, false);
#line 63 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Aseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1787, 43, false);
#line 66 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Aseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1874, 49, false);
#line 69 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OpcionElegida));

#line default
#line hidden
            EndContext();
            BeginContext(1923, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1967, 45, false);
#line 72 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OpcionElegida));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2056, 52, false);
#line 75 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PolizaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2152, 55, false);
#line 78 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PolizaNavigation.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2245, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d76cce6a204e3a99dee0b99b7de202", async() => {
                BeginContext(2271, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2281, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67343d45112144f89fdee9e1b9a555f2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 83 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Delete.cshtml"
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
                BeginContext(2317, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2401, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41dc039f34e84cbfb34b3b9114237df9", async() => {
                    BeginContext(2423, 12, true);
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
                BeginContext(2439, 6, true);
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
            BeginContext(2452, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LFbrokersV2.Models.OpcionesCotizacion> Html { get; private set; }
    }
}
#pragma warning restore 1591
