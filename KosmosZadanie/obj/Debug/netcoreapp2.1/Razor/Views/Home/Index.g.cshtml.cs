#pragma checksum "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24278cdb4b5a4baef57608e82d9935ada971d1f6"
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
#line 1 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\_ViewImports.cshtml"
using KosmosZadanie;

#line default
#line hidden
#line 2 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\_ViewImports.cshtml"
using KosmosZadanie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24278cdb4b5a4baef57608e82d9935ada971d1f6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863185b71d15faeff4f94ceef2dd10fc886db3df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KosmosZadanie.Data.Wszechswiat>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 45, true);
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(84, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66004dce0cf84f16b0a73c85faf4081b", async() => {
                BeginContext(90, 23, true);
                WriteLiteral("\r\n    <title></title>\r\n");
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
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 1161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ffbbbc1a3cf44c49b94d6a85d88746c", async() => {
                BeginContext(128, 232, true);
                WriteLiteral("\r\n    <h1> Galaktyki </h1>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Nazwa</th>\r\n                <th>Typ</th>\r\n                <th>liczba gwiazd</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 17 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
             foreach (var galaxy in Model.Galaktyki)
            {

#line default
#line hidden
                BeginContext(429, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(476, 12, false);
#line 20 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                   Write(galaxy.Nazwa);

#line default
#line hidden
                EndContext();
                BeginContext(488, 32, true);
                WriteLiteral("</td>\r\n                    <td> ");
                EndContext();
                BeginContext(521, 10, false);
#line 21 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                    Write(galaxy.Typ);

#line default
#line hidden
                EndContext();
                BeginContext(531, 33, true);
                WriteLiteral(" </td>\r\n                    <td> ");
                EndContext();
                BeginContext(565, 22, false);
#line 22 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                    Write(galaxy.Gwiazdy.Count());

#line default
#line hidden
                EndContext();
                BeginContext(587, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 24 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(632, 223, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <h1> Gwiazdy </h1>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Nazwa</th>\r\n\r\n                <th>Wiek</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 37 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
             foreach (var galaxy in Model.Galaktyki)
            {
                

#line default
#line hidden
#line 39 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                 foreach (var star in galaxy.Gwiazdy.OrderByDescending(x => x.Wiek).ToList())
                {

#line default
#line hidden
                BeginContext(1038, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(1093, 10, false);
#line 42 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                       Write(star.Nazwa);

#line default
#line hidden
                EndContext();
                BeginContext(1103, 36, true);
                WriteLiteral("</td>\r\n                        <td> ");
                EndContext();
                BeginContext(1140, 9, false);
#line 43 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                        Write(star.Wiek);

#line default
#line hidden
                EndContext();
                BeginContext(1149, 59, true);
                WriteLiteral(" </td>\r\n                      \r\n                    </tr>\r\n");
                EndContext();
#line 46 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#line 46 "C:\Users\Kamil\source\repos\KosmosZadanie\KosmosZadanie\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
                BeginContext(1242, 34, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
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
            BeginContext(1283, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KosmosZadanie.Data.Wszechswiat> Html { get; private set; }
    }
}
#pragma warning restore 1591
