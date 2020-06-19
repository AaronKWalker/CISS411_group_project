#pragma checksum "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d932c06defa2298191f8959f94ab78f40a82522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coach_SessionByCoach), @"mvc.1.0.view", @"/Views/Coach/SessionByCoach.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Coach/SessionByCoach.cshtml", typeof(AspNetCore.Views_Coach_SessionByCoach))]
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
#line 1 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\_ViewImports.cshtml"
using GroupProjectCISS411;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d932c06defa2298191f8959f94ab78f40a82522", @"/Views/Coach/SessionByCoach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0e8f6a2837cc44143e1c7e72b5f9cade80b441", @"/Views/_ViewImports.cshtml")]
    public class Views_Coach_SessionByCoach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GroupProjectCISS411.Models.Session>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Coach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 97, true);
            WriteLiteral("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n<h2 id=\"coachName\">");
            EndContext();
            BeginContext(154, 38, false);
#line 3 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
              Write(Model.FirstOrDefault().Coach.CoachName);

#line default
#line hidden
            EndContext();
            BeginContext(192, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
  
    if (Model.Count() < 1)
    {

#line default
#line hidden
            BeginContext(238, 88, true);
            WriteLiteral("        <p>You don\'t have a session yet. <a asp-for=\"AddSession\">Add a session</a></p>\r\n");
            EndContext();
#line 8 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(350, 385, true);
            WriteLiteral(@"        <h3 class=""pageHeader"">All Sessions</h3>
        <table border=""1"">
            <tr>
                <th>Session ID</th>
                <th>Session Title</th>
                <th>Start Date</th>
                <th>End Date</th>
                <th>Daily Start Time</th>
                <th>Seat Capacity</th>
                <th>Post Report</th>
            </tr>
");
            EndContext();
#line 22 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
             foreach (var session in Model)
            {

#line default
#line hidden
            BeginContext(795, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(842, 17, false);
#line 25 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
                   Write(session.SessionId);

#line default
#line hidden
            EndContext();
            BeginContext(859, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(891, 20, false);
#line 26 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
                   Write(session.SessionTitle);

#line default
#line hidden
            EndContext();
            BeginContext(911, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(943, 17, false);
#line 27 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
                   Write(session.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(960, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(992, 15, false);
#line 28 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
                   Write(session.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1039, 22, false);
#line 29 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
                   Write(session.DailyStartTime);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1093, 20, false);
#line 30 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
                   Write(session.SeatCapacity);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1170, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2befd87bba544d02a85c06245294174c", async() => {
                BeginContext(1310, 11, true);
                WriteLiteral("Post report");
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
#line 34 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
                             WriteLiteral(session.SessionId);

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
            BeginContext(1325, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
            }

#line default
#line hidden
            BeginContext(1392, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
#line 39 "C:\Users\Administrator\source\repos\ASP\CISS411_group_project\GroupProjectCISS411\Views\Coach\SessionByCoach.cshtml"
    }

#line default
#line hidden
            BeginContext(1420, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1423, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35f6b6fa45114552b1a7ef0e3d63d359", async() => {
                BeginContext(1445, 18, true);
                WriteLiteral("Back to coach home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1467, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GroupProjectCISS411.Models.Session>> Html { get; private set; }
    }
}
#pragma warning restore 1591
