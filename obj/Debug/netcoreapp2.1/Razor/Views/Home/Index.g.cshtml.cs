#pragma checksum "D:\PontoDigital\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85884365f22425147ffe52ebbb59d5f5ad2558d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85884365f22425147ffe52ebbb59d5f5ad2558d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b910b3ba7e7adee03aca8981fb32aa0bb2060f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/RegistrarDepoimentos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\'");
            EndContext();
#line 1 "D:\PontoDigital\Views\Home\Index.cshtml"
   
    var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(51, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(80, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d2ec596a6de492f9ccf33ee34805bf1", async() => {
                BeginContext(86, 77, true);
                WriteLiteral("\r\n        <meta charset=\"utf-8\"/>\r\n        <title>Ponto Digital</title>\r\n    ");
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
            BeginContext(170, 182, true);
            WriteLiteral("\r\n    <header class=\"topo container\">\r\n        <div class=\"conteudo_topo content\">\r\n            <nav class=\"menu\" id=\"menu_principal\">\r\n                <ul>\r\n                    <li>");
            EndContext();
            BeginContext(352, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7be90d39f1142f5aeb8a9dbb14972ad", async() => {
                BeginContext(411, 4, true);
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
            BeginContext(419, 33, true);
            WriteLiteral("</li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 452, "\'", 493, 2);
#line 15 "D:\PontoDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 459, Url.Action("Index", "Home"), 459, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 487, "#sobre", 487, 6, true);
            EndWriteAttribute();
            BeginContext(494, 43, true);
            WriteLiteral(">Sobre</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 537, "\'", 579, 2);
#line 16 "D:\PontoDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 544, Url.Action("Index", "Home"), 544, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 572, "#Planos", 572, 7, true);
            EndWriteAttribute();
            BeginContext(580, 44, true);
            WriteLiteral(">Planos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 624, "\'", 668, 2);
#line 17 "D:\PontoDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 631, Url.Action("Index", "Home"), 631, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 659, "#Produtos", 659, 9, true);
            EndWriteAttribute();
            BeginContext(669, 46, true);
            WriteLiteral(">Produtos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 715, "\'", 762, 2);
#line 18 "D:\PontoDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 722, Url.Action("Index", "Home"), 722, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 750, "#Localização", 750, 12, true);
            EndWriteAttribute();
            BeginContext(763, 49, true);
            WriteLiteral(">Localização</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 812, "\'", 859, 2);
#line 19 "D:\PontoDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 819, Url.Action("Index", "Home"), 819, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 847, "#Depoimentos", 847, 12, true);
            EndWriteAttribute();
            BeginContext(860, 49, true);
            WriteLiteral(">Depoimentos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 909, "\'", 953, 2);
#line 20 "D:\PontoDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 916, Url.Action("Index", "Home"), 916, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 944, "#Contatos", 944, 9, true);
            EndWriteAttribute();
            BeginContext(954, 20, true);
            WriteLiteral(">Contatos</a></li>\r\n");
            EndContext();
#line 21 "D:\PontoDigital\Views\Home\Index.cshtml"
                     if(string.IsNullOrEmpty(user))
                    {

#line default
#line hidden
            BeginContext(1050, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1074, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a933f882a081416f9589329637cf602b", async() => {
                BeginContext(1135, 14, true);
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
            BeginContext(1153, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "D:\PontoDigital\Views\Home\Index.cshtml"
                    }else{

#line default
#line hidden
            BeginContext(1188, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1212, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a41559bcea64d0896f5356b65ac8fe5", async() => {
                BeginContext(1275, 6, true);
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
            BeginContext(1285, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 26 "D:\PontoDigital\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1315, 107, true);
            WriteLiteral("                </ul>\r\n            </nav>    \r\n        </div>\r\n    </header>\r\n\r\n        </header>\r\n        ");
            EndContext();
            BeginContext(1422, 10079, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94667166dab7448e90c93c7624df89ae", async() => {
                BeginContext(1428, 2678, true);
                WriteLiteral(@"    
        <section id=""sobre"">
            <h2>Sobre</h2>
                <div id=""conteudo_sobre"">
                       <div class=""texto_sobre"">
                          <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus
                            >Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                  ");
                WriteLiteral(@"          reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ip");
                WriteLiteral(@"sam sit voluptatum voluptatibus>Lorem ipsum dolor sit amet consectetur adipisicing elit. Id ut, deleniti minus in, error,
                            reprehenderit incidunt quibusdam placeat amet assumenda dolores odit beatae rem ipsam sit voluptatum voluptatibus
                            </div>
                        </section>
        <section id=""Planos"">
            <h2>Planos</h2>
            <div class=""conteudo_planos content"">
                    <article class=""box"">
                        <h3>1ºPlano</h3>
                        <h2>R$29,90</h2>
                        
                            ");
                EndContext();
                BeginContext(4106, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a70bd8989214b4384115e3618e9a45b", async() => {
                    BeginContext(4112, 122, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Adquirir\" class=\"btn btn-primary\">\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4241, 238, true);
                WriteLiteral("\r\n                    </article>\r\n                    <article class=\"box\">                      \r\n                        <h3>2ºPlano</h3>\r\n                        <h2>R$149,90</h2>\r\n                        \r\n                            ");
                EndContext();
                BeginContext(4479, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c8bcf8c9e045978174570c044a120f", async() => {
                    BeginContext(4485, 122, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Adquirir\" class=\"btn btn-primary\">\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4614, 185, true);
                WriteLiteral("\r\n                    </article>\r\n                    <article class=\"box\">\r\n                        <h3>3ºPlano</h3>\r\n                        <H2>R$299,90</H2>\r\n                       ");
                EndContext();
                BeginContext(4799, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "492aa1e27f1a46acbfba2db4f21e9556", async() => {
                    BeginContext(4805, 122, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Adquirir\" class=\"btn btn-primary\">\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4934, 189, true);
                WriteLiteral("\r\n                    </article>\r\n                    <article class=\"box\">\r\n                        <h3>4ºPlano</h3>\r\n                        <H2>A Definir!</H2>\r\n                         ");
                EndContext();
                BeginContext(5123, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d4f7b229ca249f7a768c036ab41110e", async() => {
                    BeginContext(5129, 122, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Adquirir\" class=\"btn btn-primary\">\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5258, 4856, true);
                WriteLiteral(@"
                    </article>
                    </div>
        </section>
        <section id=""Produtos"">
            <h2>Produtos</h2>
            <article class=""box_1"">
            </article>
            <article class=""text_box"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                            earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                            Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                                    earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                                    Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. ");
                WriteLiteral(@"Voluptas explicabo nostrum
                                            earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                                            Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                                                    earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                                                    Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                                                            earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                                                            P");
                WriteLiteral(@"erferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
            </article>
            <article class=""text_box"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                            earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                            Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                                    earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                                    Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                                            earum repellendus, distinctio es");
                WriteLiteral(@"se nihil suscipit illo eveniet molestias dolorem!
                                            Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                                                    earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                                                    Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
                                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas explicabo nostrum
                                                            earum repellendus, distinctio esse nihil suscipit illo eveniet molestias dolorem!
                                                            Perferendis natus architecto tenetur eveniet magnam soluta sint explicabo?</p>
            </article>
 ");
                WriteLiteral(@"           <article class=""box_1"">
            </article>
        </section>
        <section id=""Localização"">
            <h2>Localização</h2>
            <div class=""conteudo_local"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.889023842493!2d-46.648335684407286!3d-23.536493566560996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deb99025%3A0xb23619858bc7e63e!2sEscola+SENAI+de+Inform%C3%A1tica!5e0!3m2!1spt-BR!2sbr!4v1552582398503"" width=""600"" height=""450"" frameborder=""0"" auto style=""border:0"" allowfullscreen></iframe>
            </section>
        </div>
        <section id=""Depoimentos"">
            <h2>Depoimentos</h2>
            <div class=""conteudo_Depor_container"">
            ");
                EndContext();
                BeginContext(10114, 922, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d6baada700f47b9ac996cde2d7ebf84", async() => {
                    BeginContext(10169, 860, true);
                    WriteLiteral(@"
                <label for=""nome"">Nome:</label>
                <br />
                <input name=""nome"" id=""nome"" type=""name"" maxlength=""50"" minlength=""1"" required/>
                <br />

                <label for=""sobrenome"">Sobrenome:</label>
                <br />
                <input name=""sobrenome"" id=""sobrenome"" type=""text"" maxlength=""50"" minlength=""1"" required/>
                <br />

                <label for=""email"">Email:</label>
                <br />
                <input name=""email"" id=""email"" type=""email"" required/>
                <br />

                <label for=""mensagem"">Mensagem:</label>  
                <br />
                <textarea name=""mensagem"" id=""Mensagem"" cols=""100"" rows=""15""></textarea>
                <br />
                    <input type=""submit"" value=""Enviar"">
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11036, 458, true);
                WriteLiteral(@"
                
            </div>        
        </section>
            <script>
                function botao_menu() {
                    var m = document.getElementById(""menu_principal"");
                    if (m.style.display == ""none"") {
                        m.style.display = ""block"";
                    } else {
                        m.style.display = ""none"";
                    }
                }   
            </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11501, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591