#pragma checksum "C:\Udemy\Projetos_CSHARP\VendasWebMVC_3\VendasWebMVC_3\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f13e1e10b93b6317d39628bd8b13c78ee938bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Udemy\Projetos_CSHARP\VendasWebMVC_3\VendasWebMVC_3\Views\_ViewImports.cshtml"
using VendasWebMVC_3;

#line default
#line hidden
#line 2 "C:\Udemy\Projetos_CSHARP\VendasWebMVC_3\VendasWebMVC_3\Views\_ViewImports.cshtml"
using VendasWebMVC_3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f13e1e10b93b6317d39628bd8b13c78ee938bc", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5816569282247902dfd127dcc7d5d1bdc6db080e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Udemy\Projetos_CSHARP\VendasWebMVC_3\VendasWebMVC_3\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 31, true);
            WriteLiteral("\r\n<h1><strong>Grupo: </strong> ");
            EndContext();
            BeginContext(73, 17, false);
#line 5 "C:\Udemy\Projetos_CSHARP\VendasWebMVC_3\VendasWebMVC_3\Views\Home\About.cshtml"
                        Write(ViewData["Grupo"]);

#line default
#line hidden
            EndContext();
            BeginContext(90, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(102, 19, false);
#line 6 "C:\Udemy\Projetos_CSHARP\VendasWebMVC_3\VendasWebMVC_3\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(121, 189, true);
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n\r\n<address>\r\n    <strong>Mais informações: </strong> <a href=\"https://publicitariopobre.files.wordpress.com/2013/03/pegadinha.jpg\">sapoboi-lavarapido.com.br</a>\r\n</address>\r\n\r\n");
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
