#pragma checksum "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c789b64ad8e6b8ff3251be36014d2c12f64945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Szczegoly), @"mvc.1.0.view", @"/Views/Home/Szczegoly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Szczegoly.cshtml", typeof(AspNetCore.Views_Home_Szczegoly))]
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
#line 1 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\_ViewImports.cshtml"
using Komis.Models;

#line default
#line hidden
#line 2 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\_ViewImports.cshtml"
using Komis.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c789b64ad8e6b8ff3251be36014d2c12f64945", @"/Views/Home/Szczegoly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87cf131c2f04e0d8aea6a8d321e7de7aa1d7937e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Szczegoly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Samochod>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 9, true);
            WriteLiteral("\r\n\r\n<h2> ");
            EndContext();
            BeginContext(27, 11, false);
#line 4 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
Write(Model.Marka);

#line default
#line hidden
            EndContext();
            BeginContext(38, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(42, 11, false);
#line 4 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
               Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(53, 42, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 95, "\"", 113, 1);
#line 7 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
WriteAttributeValue("", 101, Model.Marka, 101, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 114, "\"", 137, 1);
#line 7 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
WriteAttributeValue("", 120, Model.ZdjecieUrl, 120, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(138, 68, true);
            WriteLiteral("/> \r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(207, 10, false);
#line 9 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
                          Write(Model.Cena);

#line default
#line hidden
            EndContext();
            BeginContext(217, 19, true);
            WriteLiteral("</h3>\r\n        <h4>");
            EndContext();
            BeginContext(237, 18, false);
#line 10 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
       Write(Model.RokProdukcji);

#line default
#line hidden
            EndContext();
            BeginContext(255, 19, true);
            WriteLiteral("</h4>\r\n        <h4>");
            EndContext();
            BeginContext(275, 14, false);
#line 11 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
       Write(Model.Przebieg);

#line default
#line hidden
            EndContext();
            BeginContext(289, 19, true);
            WriteLiteral("</h4>\r\n        <h4>");
            EndContext();
            BeginContext(309, 9, false);
#line 12 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
       Write(Model.Moc);

#line default
#line hidden
            EndContext();
            BeginContext(318, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(337, 10, false);
#line 13 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Szczegoly.cshtml"
      Write(Model.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(347, 26, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Samochod> Html { get; private set; }
    }
}
#pragma warning restore 1591