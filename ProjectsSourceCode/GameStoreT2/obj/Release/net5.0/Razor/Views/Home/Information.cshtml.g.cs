#pragma checksum "D:\TESTS\g\GameStoreT2\Views\Home\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf10d83b39371f6f70d408ea61f9d0a46cb4ea88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Information), @"mvc.1.0.view", @"/Views/Home/Information.cshtml")]
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
#line 1 "D:\TESTS\g\GameStoreT2\Views\_ViewImports.cshtml"
using GameStoreT2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TESTS\g\GameStoreT2\Views\_ViewImports.cshtml"
using GameStoreT2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf10d83b39371f6f70d408ea61f9d0a46cb4ea88", @"/Views/Home/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8efb6865b307b32ea8f7cdb44f67d69cc9c346e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TESTS\g\GameStoreT2\Views\Home\Information.cshtml"
  
    ViewData["Title"] = "Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\TESTS\g\GameStoreT2\Views\Home\Information.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>This ia student project by Cloud Computing Team 2 Ashavjeet and Ishana</p>
<br /><p>Although the original idea involved a chatbox but it proved to be too complex and we might try to do it in the future courses. But still all the features pitched to the lecturer regarding the chatbox have been implemented in this project such as asking for a game, searching for one, checking if a new one has been uploaded.</p>
<br /><p>The site is linked to sql database and performs various related functions.</p>
<br /><p>Google authentication method is not fully functional but we tried to implement as much as we could.</p>
<br /><p>The check for a new game feature is linked to azure function (http trigger) that helps to get the information whether a new game has been added or not.</p>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
