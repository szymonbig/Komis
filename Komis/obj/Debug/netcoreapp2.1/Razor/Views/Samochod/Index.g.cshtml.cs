#pragma checksum "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "414330758d68ef7b8fe734997a7789868daf3b52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Samochod_Index), @"mvc.1.0.view", @"/Views/Samochod/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Samochod/Index.cshtml", typeof(AspNetCore.Views_Samochod_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414330758d68ef7b8fe734997a7789868daf3b52", @"/Views/Samochod/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87cf131c2f04e0d8aea6a8d321e7de7aa1d7937e", @"/Views/_ViewImports.cshtml")]
    public class Views_Samochod_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Komis.Models.Samochod>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(162, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f34caa12b4364f568f77a03c2fa5f873", async() => {
                BeginContext(185, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(292, 41, false);
#line 17 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(389, 41, false);
#line 20 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(430, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(486, 48, false);
#line 23 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RokProdukcji));

#line default
#line hidden
            EndContext();
            BeginContext(534, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(590, 44, false);
#line 26 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(634, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(690, 45, false);
#line 29 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pojemnosc));

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(791, 48, false);
#line 32 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RodzajPaliwa));

#line default
#line hidden
            EndContext();
            BeginContext(839, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(895, 39, false);
#line 35 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Moc));

#line default
#line hidden
            EndContext();
            BeginContext(934, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(990, 40, false);
#line 38 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1086, 40, false);
#line 41 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1182, 46, false);
#line 44 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ZdjecieUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1284, 49, false);
#line 47 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MiniaturkaUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1389, 58, false);
#line 50 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JestSamochodemTygodnia));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1503, 49, false);
#line 53 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JestWCentrali));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 59 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1670, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1719, 40, false);
#line 62 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1815, 40, false);
#line 65 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1911, 47, false);
#line 68 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RokProdukcji));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2014, 43, false);
#line 71 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Przebieg));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2113, 44, false);
#line 74 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pojemnosc));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2213, 47, false);
#line 77 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RodzajPaliwa));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2316, 38, false);
#line 80 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Moc));

#line default
#line hidden
            EndContext();
            BeginContext(2354, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2410, 39, false);
#line 83 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(2449, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2505, 39, false);
#line 86 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cena));

#line default
#line hidden
            EndContext();
            BeginContext(2544, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2600, 45, false);
#line 89 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZdjecieUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2701, 48, false);
#line 92 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiniaturkaUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2749, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2805, 57, false);
#line 95 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JestSamochodemTygodnia));

#line default
#line hidden
            EndContext();
            BeginContext(2862, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2918, 48, false);
#line 98 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JestWCentrali));

#line default
#line hidden
            EndContext();
            BeginContext(2966, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3021, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de7169daff114f589a2b021690df17d6", async() => {
                BeginContext(3066, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(3074, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3094, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b66394909844f449086d7299709ad29", async() => {
                BeginContext(3142, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(3153, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3173, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02dfc80b2a094e11b512c871638490c4", async() => {
                BeginContext(3220, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(3230, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 106 "C:\Users\Szymon\Documents\GIT\Komis\Komis\Views\Samochod\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3269, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Komis.Models.Samochod>> Html { get; private set; }
    }
}
#pragma warning restore 1591
