#pragma checksum "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf3fb8a8bd9de2f07f00692f1588fcce1c2892b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListarDepoimentos), @"mvc.1.0.view", @"/Views/Home/ListarDepoimentos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListarDepoimentos.cshtml", typeof(AspNetCore.Views_Home_ListarDepoimentos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf3fb8a8bd9de2f07f00692f1588fcce1c2892b", @"/Views/Home/ListarDepoimentos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b910b3ba7e7adee03aca8981fb32aa0bb2060f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListarDepoimentos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
#line 5 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
  
    var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(126, 15, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d60eca82c9d46db9b5b458aa82f22a8", async() => {
                BeginContext(132, 2, true);
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
            BeginContext(141, 196, true);
            WriteLiteral("\r\n<header>\r\n        <header class=\"topo container\">\r\n        <div class=\"conteudo_topo content\">\r\n            <nav class=\"menu\" id=\"menu_principal\">\r\n                <ul>\r\n                    <li>");
            EndContext();
            BeginContext(337, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0841dad45e74267b5fb18bd10649e49", async() => {
                BeginContext(396, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(404, 33, true);
            WriteLiteral("</li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 437, "\'", 478, 2);
#line 16 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
WriteAttributeValue("", 444, Url.Action("Index", "Home"), 444, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 472, "#sobre", 472, 6, true);
            EndWriteAttribute();
            BeginContext(479, 43, true);
            WriteLiteral(">Sobre</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 522, "\'", 564, 2);
#line 17 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
WriteAttributeValue("", 529, Url.Action("Index", "Home"), 529, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 557, "#Planos", 557, 7, true);
            EndWriteAttribute();
            BeginContext(565, 44, true);
            WriteLiteral(">Planos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 609, "\'", 653, 2);
#line 18 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
WriteAttributeValue("", 616, Url.Action("Index", "Home"), 616, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 644, "#Produtos", 644, 9, true);
            EndWriteAttribute();
            BeginContext(654, 46, true);
            WriteLiteral(">Produtos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 700, "\'", 747, 2);
#line 19 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
WriteAttributeValue("", 707, Url.Action("Index", "Home"), 707, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 735, "#Localização", 735, 12, true);
            EndWriteAttribute();
            BeginContext(748, 49, true);
            WriteLiteral(">Localização</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 797, "\'", 844, 2);
#line 20 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
WriteAttributeValue("", 804, Url.Action("Index", "Home"), 804, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 832, "#Depoimentos", 832, 12, true);
            EndWriteAttribute();
            BeginContext(845, 49, true);
            WriteLiteral(">Depoimentos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 894, "\'", 938, 2);
#line 21 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
WriteAttributeValue("", 901, Url.Action("Index", "Home"), 901, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 929, "#contatos", 929, 9, true);
            EndWriteAttribute();
            BeginContext(939, 20, true);
            WriteLiteral(">Contatos</a></li>\r\n");
            EndContext();
#line 22 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
                     if(string.IsNullOrEmpty(user)){

#line default
#line hidden
            BeginContext(1013, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1037, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57dd7b356f264a7395f553c4b5391c96", async() => {
                BeginContext(1098, 14, true);
                WriteLiteral("Login/Cadastro");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1116, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
                    }else{

#line default
#line hidden
            BeginContext(1151, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1175, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bae8d3d8f28f4ccd99dace82699d5a7d", async() => {
                BeginContext(1238, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1248, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 26 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
                    }

#line default
#line hidden
            BeginContext(1278, 367, true);
            WriteLiteral(@"                </ul>
            </nav>    
        </div>
    </header>

<h2>Lista de depoimentos</h2>


<table class=""table-form"">
    <thead>
        <tr>
            <th>Nome</th>
            <th>Sobrenome</th>
            <th>Email</th>
            <th>Mensagem</th>
            <th>Data e Horário</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 46 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
         foreach(var item in Model.Depoimentos){
            

#line default
#line hidden
#line 47 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
             if(item == null){
                continue;
            }

#line default
#line hidden
            BeginContext(1769, 49, true);
            WriteLiteral("        <tr class=\"tbody-form\">\r\n            <td>");
            EndContext();
            BeginContext(1819, 9, false);
#line 51 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1852, 14, false);
#line 52 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
           Write(item.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(1866, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1890, 10, false);
#line 53 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1900, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1924, 13, false);
#line 54 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
           Write(item.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(1937, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1961, 16, false);
#line 55 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
           Write(item.DataEntrada);

#line default
#line hidden
            EndContext();
            BeginContext(1977, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "D:\PontoDigital\Views\Home\ListarDepoimentos.cshtml"
        }

#line default
#line hidden
            BeginContext(2010, 22, true);
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
