#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e277927628441b133c300dcfe6ac975b48f340"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpcionesCotizaciones_Index), @"mvc.1.0.view", @"/Views/OpcionesCotizaciones/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OpcionesCotizaciones/Index.cshtml", typeof(AspNetCore.Views_OpcionesCotizaciones_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e277927628441b133c300dcfe6ac975b48f340", @"/Views/OpcionesCotizaciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_OpcionesCotizaciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LFbrokersV2.Models.OpcionesCotizacion>>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50cff3e488ef417c99a2bbe36ffeaf5c", async() => {
                BeginContext(154, 10, true);
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
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 45, false);
#line 16 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(306, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 49, false);
#line 19 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 48, false);
#line 22 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(515, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(571, 49, false);
#line 25 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(620, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(676, 47, false);
#line 28 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(723, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(779, 47, false);
#line 31 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(826, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(882, 47, false);
#line 34 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(929, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(985, 45, false);
#line 37 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Condicion));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1086, 47, false);
#line 40 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Aseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1189, 49, false);
#line 43 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OpcionElegida));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1294, 52, false);
#line 46 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PolizaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1464, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1513, 44, false);
#line 55 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1613, 48, false);
#line 58 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1717, 47, false);
#line 61 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1820, 48, false);
#line 64 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1924, 46, false);
#line 67 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2026, 46, false);
#line 70 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2128, 46, false);
#line 73 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(2174, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2230, 44, false);
#line 76 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Condicion));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2330, 46, false);
#line 79 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Aseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2432, 48, false);
#line 82 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OpcionElegida));

#line default
#line hidden
            EndContext();
            BeginContext(2480, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2536, 58, false);
#line 85 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PolizaNavigation.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2594, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2649, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a45998441504b8b8b36928327cad97d", async() => {
                BeginContext(2694, 4, true);
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
#line 88 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
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
            BeginContext(2702, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2722, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3979fa7d02434844977541ba4df861d2", async() => {
                BeginContext(2770, 7, true);
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
#line 89 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
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
            BeginContext(2781, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2801, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ba05c227e2c491c921518c8d13d6ba1", async() => {
                BeginContext(2848, 6, true);
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
#line 90 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
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
            BeginContext(2858, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2897, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LFbrokersV2.Models.OpcionesCotizacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
