#pragma checksum "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\Home\Information.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9c90ae565eb17e0840ea305c36f46eeaf4bbe0c0b31881925d0d0a3ca64fbc7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Information), @"mvc.1.0.view", @"/Views/Home/Information.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\_ViewImports.cshtml"
using GameStoreT2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\_ViewImports.cshtml"
using GameStoreT2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9c90ae565eb17e0840ea305c36f46eeaf4bbe0c0b31881925d0d0a3ca64fbc7b", @"/Views/Home/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d869396c0e6eab180da28d3ce28ce795e0490b0afc944bc2c7bd04605fbdd1a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\Home\Information.cshtml"
  
    ViewData["Title"] = "Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\Home\Information.cshtml"
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591