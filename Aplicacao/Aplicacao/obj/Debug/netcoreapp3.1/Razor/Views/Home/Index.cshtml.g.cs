#pragma checksum "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4165234b0f606a034190a6a45666afbb72f86f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\_ViewImports.cshtml"
using Aplicacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\_ViewImports.cshtml"
using Aplicacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4165234b0f606a034190a6a45666afbb72f86f5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79324916cd296a0c3dbdbf7040eea0f65351f369", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsuariosModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4165234b0f606a034190a6a45666afbb72f86f5f3876", async() => {
                WriteLiteral(@"

    <button name=""metodo"" value=""carregar"" class=""btn btn-outline-success"">
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-box-arrow-in-down"" viewBox=""0 0 16 16"">
            <path fill-rule=""evenodd"" d=""M3.5 6a.5.5 0 0 0-.5.5v8a.5.5 0 0 0 .5.5h9a.5.5 0 0 0 .5-.5v-8a.5.5 0 0 0-.5-.5h-2a.5.5 0 0 1 0-1h2A1.5 1.5 0 0 1 14 6.5v8a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 14.5v-8A1.5 1.5 0 0 1 3.5 5h2a.5.5 0 0 1 0 1h-2z"" />
            <path fill-rule=""evenodd"" d=""M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"" />
        </svg>
        Baixar Dados em tabela
    </button>
    <button name=""metodo"" value=""visualizarJSON"" class=""btn btn-outline-dark"">
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-box-arrow-in-down"" viewBox=""0 0 16 16"">
            <path fill-rule=""evenodd"" d=""M3.5 6a.5.5 0 0 0-.5.5v8a.5.5 0 0 ");
                WriteLiteral(@"0 .5.5h9a.5.5 0 0 0 .5-.5v-8a.5.5 0 0 0-.5-.5h-2a.5.5 0 0 1 0-1h2A1.5 1.5 0 0 1 14 6.5v8a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 14.5v-8A1.5 1.5 0 0 1 3.5 5h2a.5.5 0 0 1 0 1h-2z"" />
            <path fill-rule=""evenodd"" d=""M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"" />
        </svg>
        Baixar Dados em JSON
    </button>
    <button name=""metodo"" value=""logs"" class=""btn btn-outline-danger"">
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-box-arrow-in-down"" viewBox=""0 0 16 16"">
            <path fill-rule=""evenodd"" d=""M3.5 6a.5.5 0 0 0-.5.5v8a.5.5 0 0 0 .5.5h9a.5.5 0 0 0 .5-.5v-8a.5.5 0 0 0-.5-.5h-2a.5.5 0 0 1 0-1h2A1.5 1.5 0 0 1 14 6.5v8a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 14.5v-8A1.5 1.5 0 0 1 3.5 5h2a.5.5 0 0 1 0 1h-2z"" />
            <path fill-rule=""evenodd"" d=""M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0");
                WriteLiteral(@"v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"" />
        </svg>
        Baixar Logs
    </button>
    <button name=""metodo"" value=""salvar"" class=""btn btn-outline-primary"" onclick=""salvar()"">
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-hdd"" viewBox=""0 0 16 16"">
            <path d=""M4.5 11a.5.5 0 1 0 0-1 .5.5 0 0 0 0 1zM3 10.5a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0z"" />
            <path d=""M16 11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V9.51c0-.418.105-.83.305-1.197l2.472-4.531A1.5 1.5 0 0 1 4.094 3h7.812a1.5 1.5 0 0 1 1.317.782l2.472 4.53c.2.368.305.78.305 1.198V11zM3.655 4.26L1.592 8.043C1.724 8.014 1.86 8 2 8h12c.14 0 .276.014.408.042L12.345 4.26a.5.5 0 0 0-.439-.26H4.094a.5.5 0 0 0-.44.26zM1 10v1a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1v-1a1 1 0 0 0-1-1H2a1 1 0 0 0-1 1z"" />
        </svg>
        Salvar Dados no DB
    </button>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n\r\n\r\n<div class=\"container\">\r\n    ");
#nullable restore
#line 45 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
Write(ViewBag.ExibirJSON);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 48 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
 if(@ViewBag.DesabilitarTabela == "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-hover\"");
            BeginWriteAttribute("style", " style=\"", 3178, "\"", 3220, 2);
            WriteAttributeValue("", 3186, "display:", 3186, 8, true);
#nullable restore
#line 50 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
WriteAttributeValue("", 3194, ViewBag.DesabilitarTabela, 3194, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    <thead>
        <tr style=""text-align:center;  font-size: 12px; background-color:darkslategray; color:white"">
            <td><strong>ID</strong></td>
            <td><strong>NAME</strong> </td>
            <td><strong>USERNAME</strong></td>
            <td><strong>EMAIL</strong></td>
            <td><strong>ADRESS</strong></td>
            <td><strong>PHONE</strong></td>
            <td><strong>WEBSITE</strong></td>
            <td><strong>COMPANY</strong></td>

        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 67 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
         foreach (var item in (List<UsuariosModel>)ViewBag.ListaClientes)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"font-size: 11px\">\r\n                <td>");
#nullable restore
#line 71 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.id.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 72 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.name.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 73 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.username.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 74 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.email.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.address.street.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" -\r\n                    ");
#nullable restore
#line 77 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.address.suite.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    ");
#nullable restore
#line 78 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.address.city.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" -\r\n                    ");
#nullable restore
#line 79 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.address.zipcode.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <br />\r\n                    Lat: ");
#nullable restore
#line 80 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
                    Write(item.address.geo.lat.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    Lnt: ");
#nullable restore
#line 81 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
                    Write(item.address.geo.lng.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>");
#nullable restore
#line 84 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.phone.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 85 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.website.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.company.name.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    ");
#nullable restore
#line 88 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.company.catchPhrase.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    ");
#nullable restore
#line 89 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item.company.bs.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 92 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 99 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 102 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
 if(ViewBag.DesabilitarTabelaLog == "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-hover"" >
    <thead>
        <tr style=""text-align:center;  font-size: 12px; background-color:darkslategray; color:white"">
            <td><strong>DATA</strong></td>
            <td><strong>DESCRICAO</strong> </td>


        </tr>
    </thead>

    <tbody>



");
#nullable restore
#line 118 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
         foreach (var item2 in (List<UsuariosModel>)ViewBag.ListaClientes)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"font-size: 11px\">\r\n                <td style=\"text-align:center\">");
#nullable restore
#line 122 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
                                         Write(item2.data.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 123 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
               Write(item2.descricao.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 126 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 130 "C:\Curso\Solucao-Senior-Mutant\Aplicacao\Aplicacao\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script>
    function salvar() {
        Swal.fire({
            position: 'top-end',
            icon: 'success',
            title: 'Dados salvos com sucesso',
            showConfirmButton: false,
            timer: 15000
        })
    }


</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsuariosModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
