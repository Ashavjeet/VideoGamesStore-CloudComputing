#pragma checksum "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28d386cf46e1989db7136fc0afdf6dbd23da35e73bab1427c6385d7cc1a2dbfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VidGs_SearchRec), @"mvc.1.0.view", @"/Views/VidGs/SearchRec.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"28d386cf46e1989db7136fc0afdf6dbd23da35e73bab1427c6385d7cc1a2dbfa", @"/Views/VidGs/SearchRec.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d869396c0e6eab180da28d3ce28ce795e0490b0afc944bc2c7bd04605fbdd1a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VidGs_SearchRec : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameStoreT2.Models.DB.VidG>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchRec", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
  
    ViewData["Title"] = "Search Record";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SearchRec</h1>\r\n");
            WriteLiteral("\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d386cf46e1989db7136fc0afdf6dbd23da35e73bab1427c6385d7cc1a2dbfa5641", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d386cf46e1989db7136fc0afdf6dbd23da35e73bab1427c6385d7cc1a2dbfa5935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 14 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d386cf46e1989db7136fc0afdf6dbd23da35e73bab1427c6385d7cc1a2dbfa7718", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 17 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VideoGameName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input name=\"Vidgame\" required=\"required\" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d386cf46e1989db7136fc0afdf6dbd23da35e73bab1427c6385d7cc1a2dbfa10852", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
 if (ViewBag.temp != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 38 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayNameFor(model => model.VidKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 41 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayFor(model => model.VidKey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 44 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayNameFor(model => model.VideoGameName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 47 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayFor(model => model.VideoGameName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 50 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayNameFor(model => model.Ratings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 53 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayFor(model => model.Ratings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 56 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayNameFor(model => model.Developer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 59 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayFor(model => model.Developer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 62 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 65 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 69 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"
}

else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5></h5>\r\n");
#nullable restore
#line 75 "C:\Users\ashus\Documents\StudyAssignmentMit\Team2\ProjectsSourceCode\GameStoreT2\Views\VidGs\SearchRec.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameStoreT2.Models.DB.VidG> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
