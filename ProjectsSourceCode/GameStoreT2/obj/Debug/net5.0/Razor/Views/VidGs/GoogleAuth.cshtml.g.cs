#pragma checksum "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\GoogleAuth.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c0c52e62fed671879cf82e75ffbe6f73531356097f15f2fe7180942395c6c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VidGs_GoogleAuth), @"mvc.1.0.view", @"/Views/VidGs/GoogleAuth.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6c0c52e62fed671879cf82e75ffbe6f73531356097f15f2fe7180942395c6c26", @"/Views/VidGs/GoogleAuth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d869396c0e6eab180da28d3ce28ce795e0490b0afc944bc2c7bd04605fbdd1a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VidGs_GoogleAuth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h5> This admin feature is not fully implemented as we were focussed on accounts linked with the database but still few google authentication steps are working.</h5>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c0c52e62fed671879cf82e75ffbe6f73531356097f15f2fe7180942395c6c263578", async() => {
                WriteLiteral(@"
    <meta name=""google-signin-scope"" content=""profile email"">
    <meta name=""google-signin-client_id"" content=""572148227045-7tgqrl4v9kl6kl9g4347kg6tci9t6vl1.apps.googleusercontent.com"">
    <script src=""https://apis.google.com/js/platform.js"" async defer></script>
");
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
            WriteLiteral(@"

<div class=""g-signin2"" data-onsuccess=""onSignIn"" data-theme=""dark""></div>
<script>
        function onSignIn(googleUser) {
            var profile = googleUser.getBasicProfile();
            alert(""Successful"");
            console.log(""ID: "" + profile.getId());
            console.log('Full Name: ' + profile.getName());
            console.log('Given Name: ' + profile.getGivenName());
            console.log('Family Name: ' + profile.getFamilyName());
            console.log(""Image URL: "" + profile.getImageUrl());
            console.log(""Email: "" + profile.getEmail());
            var id_token = googleUser.getAuthResponse().id_token;
            console.log(""ID Token: "" + id_token);
        }
</script>




<div class=""text-center"">
    <marquee width=""900"">THIS IS A STUDENT PROJECT.</marquee>
</div>
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