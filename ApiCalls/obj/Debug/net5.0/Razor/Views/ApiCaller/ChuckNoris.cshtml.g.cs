#pragma checksum "C:\dev\Improving\Practice\ApiCalls\ApiCalls\Views\ApiCaller\ChuckNoris.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a18311c867249ee10acb414eb7b367713af2e0a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApiCaller_ChuckNoris), @"mvc.1.0.view", @"/Views/ApiCaller/ChuckNoris.cshtml")]
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
#line 1 "C:\dev\Improving\Practice\ApiCalls\ApiCalls\Views\_ViewImports.cshtml"
using ApiCalls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\Improving\Practice\ApiCalls\ApiCalls\Views\_ViewImports.cshtml"
using ApiCalls.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a18311c867249ee10acb414eb7b367713af2e0a8", @"/Views/ApiCaller/ChuckNoris.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0031ee6a68f683b663f0ff292cdcf72c795690d8", @"/Views/_ViewImports.cshtml")]
    public class Views_ApiCaller_ChuckNoris : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApiCalls.Models.ChuckNorisFact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nFACT: ");
#nullable restore
#line 3 "C:\dev\Improving\Practice\ApiCalls\ApiCalls\Views\ApiCaller\ChuckNoris.cshtml"
 Write(Model.Joke);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApiCalls.Models.ChuckNorisFact> Html { get; private set; }
    }
}
#pragma warning restore 1591