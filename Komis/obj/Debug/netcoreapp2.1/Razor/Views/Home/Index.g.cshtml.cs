#pragma checksum "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd4f2f2bd7820d025d0017b320c6739be8763c8"
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
#line 1 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\_ViewImports.cshtml"
using Komis.Models;

#line default
#line hidden
#line 2 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\_ViewImports.cshtml"
using Komis.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd4f2f2bd7820d025d0017b320c6739be8763c8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87cf131c2f04e0d8aea6a8d321e7de7aa1d7937e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Szczegoly", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(118, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(125, 11, false);
#line 6 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
Write(Model.Tytul);

#line default
#line hidden
            EndContext();
            BeginContext(136, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
 foreach (var samochod in Model.Samochody)
{   

#line default
#line hidden
            BeginContext(197, 95, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 292, "\"", 321, 1);
#line 13 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
WriteAttributeValue("", 298, samochod.MiniaturkaUrl, 298, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 84, true);
            WriteLiteral(" alt=\"\">\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(407, 27, false);
#line 15 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                                  Write(samochod.Cena.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(434, 49, true);
            WriteLiteral("</h3>\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(483, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea484867f9bc4e7b9a19becb481cf596", async() => {
                BeginContext(560, 14, false);
#line 17 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                                                                                           Write(samochod.Marka);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                                                                      WriteLiteral(samochod.Id);

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
            BeginContext(578, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(582, 14, false);
#line 17 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                                                                                                                 Write(samochod.Model);

#line default
#line hidden
            EndContext();
            BeginContext(596, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(600, 21, false);
#line 17 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                                                                                                                                   Write(samochod.RokProdukcji);

#line default
#line hidden
            EndContext();
            BeginContext(621, 78, true);
            WriteLiteral("\r\n                </h3>\r\n                <h4>\r\n                    Przebieg : ");
            EndContext();
            BeginContext(700, 17, false);
#line 20 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                          Write(samochod.Przebieg);

#line default
#line hidden
            EndContext();
            BeginContext(717, 79, true);
            WriteLiteral("\r\n                </h4>\r\n                <h4>\r\n                    Pojemność : ");
            EndContext();
            BeginContext(797, 18, false);
#line 23 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                           Write(samochod.Pojemnosc);

#line default
#line hidden
            EndContext();
            BeginContext(815, 73, true);
            WriteLiteral("\r\n                </h4>\r\n                <h4>\r\n                    Moc : ");
            EndContext();
            BeginContext(889, 12, false);
#line 26 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
                     Write(samochod.Moc);

#line default
#line hidden
            EndContext();
            BeginContext(901, 44, true);
            WriteLiteral("\r\n                </h4>\r\n                <p>");
            EndContext();
            BeginContext(946, 13, false);
#line 28 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
              Write(samochod.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(959, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1016, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
