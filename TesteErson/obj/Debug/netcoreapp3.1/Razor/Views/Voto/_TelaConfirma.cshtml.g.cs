#pragma checksum "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb7ffdd9387036b08af42b7e5a809205a707d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Voto__TelaConfirma), @"mvc.1.0.view", @"/Views/Voto/_TelaConfirma.cshtml")]
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
#line 1 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\_ViewImports.cshtml"
using TesteErson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\_ViewImports.cshtml"
using TesteErson.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb7ffdd9387036b08af42b7e5a809205a707d10", @"/Views/Voto/_TelaConfirma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89ea5cd3fef11aa1e39de6ea9af298915bb949ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Voto__TelaConfirma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/logo2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
  
    Layout = "_Layout";
    var votoBranco = ((int)ViewBag.Legenda == 000);
    var css = "";
    if (!votoBranco) { css = "etapa1"; }

    string txtLegenda = ViewBag.Legenda.ToString();
    if(txtLegenda.Length == 1) { txtLegenda = "0" + txtLegenda; }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"conteudo titulo\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbb7ffdd9387036b08af42b7e5a809205a707d104308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h3>Confirme o seu Voto</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
  
    if (!votoBranco)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"conteudo candidato\">\r\n            <div class=\"candidato nome\">Candidato: <strong>");
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
                                                      Write(ViewBag.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n            <div class=\"candidato vice\">Vice: <strong>");
#nullable restore
#line 22 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
                                                 Write(ViewBag.Vice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"conteudo legenda etapa1\">\r\n");
#nullable restore
#line 28 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
      
        if (votoBranco) // Maneira para entender se é branco ou não
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"numero\">B</div>\r\n            <div class=\"numero\">R</div>\r\n            <div class=\"numero\">A</div>\r\n            <div class=\"numero\">N</div>\r\n            <div class=\"numero\">C</div>\r\n            <div class=\"numero\">O</div>\r\n");
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"numero\">");
#nullable restore
#line 41 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
                           Write(txtLegenda.Substring(0, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"numero\">");
#nullable restore
#line 42 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
                           Write(txtLegenda.Substring(1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 43 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1244, "\"", 1272, 3);
            WriteAttributeValue("", 1252, "conteudo", 1252, 8, true);
            WriteAttributeValue(" ", 1260, "rodape", 1261, 7, true);
#nullable restore
#line 47 "C:\Users\ADMIN\source\repos\TesteErson\TesteErson\Views\Voto\_TelaConfirma.cshtml"
WriteAttributeValue(" ", 1267, css, 1268, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p>Verifique os dados do seu candidato antes de continuar</p>\r\n        <p>Caso tenha certeza, clique em <font style=\"color: green;\">CONFIRMA</font> para o próximo passo.</p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
