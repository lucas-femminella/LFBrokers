#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbba15591db305ac6bfaa119cc13bfce915fabb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personas_Details), @"mvc.1.0.view", @"/Views/Personas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personas/Details.cshtml", typeof(AspNetCore.Views_Personas_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbba15591db305ac6bfaa119cc13bfce915fabb4", @"/Views/Personas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Personas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LFbrokersV2.Models.Persona>
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Persona</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 49, false);
#line 14 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(251, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(295, 45, false);
#line 17 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 48, false);
#line 20 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NroDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(476, 44, false);
#line 23 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.NroDocumento));

#line default
#line hidden
            EndContext();
            BeginContext(520, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(564, 43, false);
#line 26 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(607, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(651, 39, false);
#line 29 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(690, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(734, 45, false);
#line 32 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(823, 41, false);
#line 35 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(864, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(908, 41, false);
#line 38 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(949, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(993, 37, false);
#line 41 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1074, 42, false);
#line 44 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Altura));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1160, 38, false);
#line 47 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Altura));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1242, 40, false);
#line 50 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Piso));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1326, 36, false);
#line 53 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Piso));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1406, 48, false);
#line 56 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1498, 44, false);
#line 59 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1586, 48, false);
#line 62 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Obervaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1678, 44, false);
#line 65 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Obervaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1766, 51, false);
#line 68 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1861, 47, false);
#line 71 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1952, 44, false);
#line 74 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1996, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2040, 40, false);
#line 77 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2124, 43, false);
#line 80 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2211, 39, false);
#line 83 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2250, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2294, 41, false);
#line 86 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2379, 37, false);
#line 89 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2460, 40, false);
#line 92 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2544, 36, false);
#line 95 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2624, 58, false);
#line 98 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodigoPostalNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2682, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2726, 68, false);
#line 101 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodigoPostalNavigation.CodigoPostal1));

#line default
#line hidden
            EndContext();
            BeginContext(2794, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2841, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f9aadff1184914a62efa0a2f081ffb", async() => {
                BeginContext(2887, 4, true);
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
#line 106 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\Personas\Details.cshtml"
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
            BeginContext(2895, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2903, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a31db6d3f9824591ae40a0a1ce0a8a1f", async() => {
                BeginContext(2925, 12, true);
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
            BeginContext(2941, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LFbrokersV2.Models.Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591
