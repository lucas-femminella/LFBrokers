#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717bb6ae3571dc5de00aeef01928eda71bf262fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EspecialidadPrimaPorSuma_Delete), @"mvc.1.0.view", @"/Views/EspecialidadPrimaPorSuma/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EspecialidadPrimaPorSuma/Delete.cshtml", typeof(AspNetCore.Views_EspecialidadPrimaPorSuma_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717bb6ae3571dc5de00aeef01928eda71bf262fe", @"/Views/EspecialidadPrimaPorSuma/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_EspecialidadPrimaPorSuma_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LFbrokersV2.Models.EspecialidadPrimaPorSuma>
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(96, 185, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>EspecialidadPrimaPorSuma</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(282, 45, false);
#line 15 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(371, 41, false);
#line 18 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(412, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(456, 49, false);
#line 21 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(549, 45, false);
#line 24 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(594, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(638, 61, false);
#line 27 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EspecialidadCodigoExterno));

#line default
#line hidden
            EndContext();
            BeginContext(699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(743, 57, false);
#line 30 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EspecialidadCodigoExterno));

#line default
#line hidden
            EndContext();
            BeginContext(800, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(844, 53, false);
#line 33 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaVigenteDesde));

#line default
#line hidden
            EndContext();
            BeginContext(897, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(941, 49, false);
#line 36 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimaVigenteDesde));

#line default
#line hidden
            EndContext();
            BeginContext(990, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1034, 58, false);
#line 39 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EspecialidadNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1136, 61, false);
#line 42 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EspecialidadNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1241, 65, false);
#line 45 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductoAseguradoraNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1350, 64, false);
#line 48 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductoAseguradoraNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1452, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35a412d90061423c988a66d81b8fa996", async() => {
                BeginContext(1478, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1488, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9dea7cae50845f099dfcdacf4343b67", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\EspecialidadPrimaPorSuma\Delete.cshtml"
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
                BeginContext(1524, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1608, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "553f09cdb9934a0286d0e37d2db4a84c", async() => {
                    BeginContext(1630, 12, true);
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
                BeginContext(1646, 6, true);
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
            BeginContext(1659, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LFbrokersV2.Models.EspecialidadPrimaPorSuma> Html { get; private set; }
    }
}
#pragma warning restore 1591
