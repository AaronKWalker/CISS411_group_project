#pragma checksum "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\Role\AllRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "956bacd2dbd639f919c8a31a7443cc91ceb9b0d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_AllRole), @"mvc.1.0.view", @"/Views/Role/AllRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/AllRole.cshtml", typeof(AspNetCore.Views_Role_AllRole))]
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
#line 1 "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\_ViewImports.cshtml"
using GroupProjectCISS411;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"956bacd2dbd639f919c8a31a7443cc91ceb9b0d8", @"/Views/Role/AllRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0e8f6a2837cc44143e1c7e72b5f9cade80b441", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_AllRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(67, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb7105ebed934bbe83407ca56fda2d5f", async() => {
                BeginContext(91, 10, true);
                WriteLiteral("Add a role");
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
            BeginContext(105, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 3 "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\Role\AllRole.cshtml"
  
    if (Model.Count() < 1)
    {

#line default
#line hidden
            BeginContext(150, 41, true);
            WriteLiteral("        <p>No role in database yet.</p>\r\n");
            EndContext();
#line 7 "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\Role\AllRole.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(215, 129, true);
            WriteLiteral("        <h3>All Roles</h3>\r\n        <table border=\"1\">\r\n            <tr>\r\n                <th>Role Name</th>\r\n            </tr>\r\n");
            EndContext();
#line 15 "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\Role\AllRole.cshtml"
             foreach (var role in Model)
            {

#line default
#line hidden
            BeginContext(401, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(448, 9, false);
#line 18 "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\Role\AllRole.cshtml"
                   Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(457, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 20 "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\Role\AllRole.cshtml"
            }

#line default
#line hidden
            BeginContext(502, 74, true);
            WriteLiteral("        </table>\r\n        <br />\r\n        <p>©2020 - Columbia Coders</p>\r\n");
            EndContext();
#line 24 "C:\Users\veron\Desktop\ASP\GroupProjectCISS411\Views\Role\AllRole.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
