#pragma checksum "D:\PontoDigital\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0138201ed241d607f6ae52c0e04cc991065fd527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "D:\PontoDigital\Views\_ViewImports.cshtml"
using PontoDigital;

#line default
#line hidden
#line 2 "D:\PontoDigital\Views\_ViewImports.cshtml"
using PontoDigital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0138201ed241d607f6ae52c0e04cc991065fd527", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b910b3ba7e7adee03aca8981fb32aa0bb2060f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-navbar-flex.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
#line 5 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
  
    var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(126, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec36fb2297a4423a430c3645c837783", async() => {
                BeginContext(132, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(138, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "55b87727946e4f2b8e867473ac442dee", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(212, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(221, 196, true);
            WriteLiteral("\r\n<header>\r\n        <header class=\"topo container\">\r\n        <div class=\"conteudo_topo content\">\r\n            <nav class=\"menu\" id=\"menu_principal\">\r\n                <ul>\r\n                    <li>");
            EndContext();
            BeginContext(417, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3fe9bd22c694a109c64eb184adae7e1", async() => {
                BeginContext(476, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(484, 33, true);
            WriteLiteral("</li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 517, "\'", 558, 2);
#line 17 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 524, Url.Action("Index", "Home"), 524, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 552, "#sobre", 552, 6, true);
            EndWriteAttribute();
            BeginContext(559, 43, true);
            WriteLiteral(">Sobre</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 602, "\'", 644, 2);
#line 18 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 609, Url.Action("Index", "Home"), 609, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 637, "#Planos", 637, 7, true);
            EndWriteAttribute();
            BeginContext(645, 44, true);
            WriteLiteral(">Planos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 689, "\'", 733, 2);
#line 19 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 696, Url.Action("Index", "Home"), 696, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 724, "#Produtos", 724, 9, true);
            EndWriteAttribute();
            BeginContext(734, 46, true);
            WriteLiteral(">Produtos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 780, "\'", 827, 2);
#line 20 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 787, Url.Action("Index", "Home"), 787, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 815, "#Localização", 815, 12, true);
            EndWriteAttribute();
            BeginContext(828, 49, true);
            WriteLiteral(">Localização</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 877, "\'", 924, 2);
#line 21 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 884, Url.Action("Index", "Home"), 884, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 912, "#Depoimentos", 912, 12, true);
            EndWriteAttribute();
            BeginContext(925, 49, true);
            WriteLiteral(">Depoimentos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 974, "\'", 1018, 2);
#line 22 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 981, Url.Action("Index", "Home"), 981, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1009, "#contatos", 1009, 9, true);
            EndWriteAttribute();
            BeginContext(1019, 20, true);
            WriteLiteral(">Contatos</a></li>\r\n");
            EndContext();
#line 23 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
                     if(string.IsNullOrEmpty(user))
                    {

#line default
#line hidden
            BeginContext(1115, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1139, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1413a5690da94bb489c9c309859a4383", async() => {
                BeginContext(1200, 14, true);
                WriteLiteral("Login/Cadastro");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1218, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 26 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1297, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1321, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cddbec41f7742a09f442abfae5a657c", async() => {
                BeginContext(1384, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1394, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 30 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1424, 116, true);
            WriteLiteral("                </ul>\r\n            </nav>    \r\n        </div>\r\n    </header>\r\n\r\n<h2>Registro de Depoimentos</h2>\r\n\r\n");
            EndContext();
            BeginContext(1540, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76cdb9dda422443cb34027679d4b5471", async() => {
                BeginContext(1602, 121, true);
                WriteLiteral("\r\n    <label for=\"data\">Data:</label>\r\n    <input type=\"date\" name=\"data\">\r\n\r\n    <input type=\"submit\" value=\"Filtrar\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 38 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
AddHtmlAttributeValue("", 1554, Url.Action("Index","Dashboard"), 1554, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1730, 308, true);
            WriteLiteral(@"


<table class=""table-form"">
    <thead>
        <tr>
            <th>Nome</th>
            <th>Sobrenome</th>
            <th>Email</th>
            <th>Mensagem</th>
            <th>Data e Horário</th>
            <th>Aprovamento ou Reprovamento</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 58 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
         foreach(var item in Model.Depoimentos)
        {
            

#line default
#line hidden
#line 60 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
             if(item == null)
            {
                continue;
            }

#line default
#line hidden
            BeginContext(2186, 49, true);
            WriteLiteral("        <tr class=\"tbody-form\">\r\n            <td>");
            EndContext();
            BeginContext(2236, 9, false);
#line 65 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2245, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2269, 14, false);
#line 66 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
           Write(item.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(2283, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2307, 10, false);
#line 67 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2317, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2341, 13, false);
#line 68 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
           Write(item.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(2354, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2378, 16, false);
#line 69 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
           Write(item.DataEntrada);

#line default
#line hidden
            EndContext();
            BeginContext(2394, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2418, 10, false);
#line 70 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
           Write(item.Botao);

#line default
#line hidden
            EndContext();
            BeginContext(2428, 26, true);
            WriteLiteral("</td>    \r\n        </tr>\r\n");
            EndContext();
#line 72 "D:\PontoDigital\Views\Dashboard\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2465, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigital.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
