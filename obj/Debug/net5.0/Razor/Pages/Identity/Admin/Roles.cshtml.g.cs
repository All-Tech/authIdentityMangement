#pragma checksum "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6277817d830dd30286f741fd2f12d7801bd408d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Identity_Admin_Roles), @"mvc.1.0.razor-page", @"/Pages/Identity/Admin/Roles.cshtml")]
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
#line 2 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\_ViewImports.cshtml"
using IdentityApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\_ViewImports.cshtml"
using IdentityApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6277817d830dd30286f741fd2f12d7801bd408d3", @"/Pages/Identity/Admin/Roles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df6f293cb7f076d22b878a9c5d94cdf5a1f5f549", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Identity_Admin_Roles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "deleteFromList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "addToList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addToListForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
  
    ViewBag.Workflow = "Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6277817d830dd30286f741fd2f12d7801bd408d37809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 7 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

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
            WriteLiteral("\r\n\r\n<table class=\"table table-sm table-striped table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th colspan=\"2\" class=\"text-center\">Master Role List</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
         foreach (IdentityRole role in Model.RoleManager.Roles)
        {
            int userCount =
            (await Model.UserManager.GetUsersInRoleAsync(role.Name)).Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
               Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 23 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                     if (userCount == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6277817d830dd30286f741fd2f12d7801bd408d310816", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 842, "\"", 860, 1);
#nullable restore
#line 26 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
WriteAttributeValue("", 850, role.Name, 850, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                                Delete\r\n                            </button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                      Write(userCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" users in role\r\n");
#nullable restore
#line 35 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6277817d830dd30286f741fd2f12d7801bd408d314462", async() => {
                WriteLiteral("\r\n                    <input class=\"form-control\" name=\"role\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </td>
            <td>
                <button type=""submit"" class=""btn btn-sm btn-success"" form=""addToListForm"">
                    Add
                </button>
            </td>
        </tr>
    </tbody>
</table>


<table class=""table table-sm table-striped table-bordered"">
    <thead>
        <tr>
            <th colspan=""2"" class=""text-center"">User's Roles</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 62 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
         if (Model.RoleManager.Roles.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"2\" class=\"text-center py-2\">\r\n                    No roles have been defined\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
             if (Model.CurrentRoles.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\" class=\"text-center py-2\">\r\n                        User has no roles\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 79 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                 foreach (string role in Model.CurrentRoles)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 85 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                       Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6277817d830dd30286f741fd2f12d7801bd408d319012", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6277817d830dd30286f741fd2f12d7801bd408d319303", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 88 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 2853, "\"", 2866, 1);
#nullable restore
#line 89 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
WriteAttributeValue("", 2861, role, 2861, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\"");
                BeginWriteAttribute("disabled", " disabled=\"", 2925, "\"", 2965, 1);
#nullable restore
#line 90 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
WriteAttributeValue("", 2936, role== Model.DashboardRole, 2936, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                                    Delete\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 96 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
             if (Model.AvailableRoles.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\" class=\"text-center py-2\">\r\n                        User is in all roles\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 105 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <select class=\"form-control\" name=\"role\" form=\"addForm\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6277817d830dd30286f741fd2f12d7801bd408d325132", async() => {
                WriteLiteral("Choose Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                             foreach (string role in Model.AvailableRoles)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6277817d830dd30286f741fd2f12d7801bd408d327107", async() => {
#nullable restore
#line 114 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                                   Write(role);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6277817d830dd30286f741fd2f12d7801bd408d328692", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6277817d830dd30286f741fd2f12d7801bd408d328979", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 120 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-sm btn-success\">\r\n                                Add\r\n                            </button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 127 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Identity\Admin\Roles.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityApp.Pages.Identity.Admin.RolesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.Identity.Admin.RolesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.Identity.Admin.RolesModel>)PageContext?.ViewData;
        public IdentityApp.Pages.Identity.Admin.RolesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
