#pragma checksum "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ddb81d40f444f290233efa7dd17bd25a35e202a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Store), @"mvc.1.0.razor-page", @"/Pages/Store.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/pages/store")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ddb81d40f444f290233efa7dd17bd25a35e202a", @"/Pages/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df6f293cb7f076d22b878a9c5d94cdf5a1f5f549", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Store : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h4 class=""bg-info text-white text-center p-2"">Pages - Level 2 - Signed In Users</h4>

<div class=""p-2"">
    <table class=""table table-sm table-striped table-bordered"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Category</th>
                <th class=""text-right"">Price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Store.cshtml"
             foreach (Product p in Model.DbContext.Products.OrderBy(p => p.Id))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Store.cshtml"
                   Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Store.cshtml"
                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Store.cshtml"
                   Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">$");
#nullable restore
#line 23 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Store.cshtml"
                                       Write(p.Price.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Store.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityApp.Pages.StoreModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.StoreModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.StoreModel>)PageContext?.ViewData;
        public IdentityApp.Pages.StoreModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
