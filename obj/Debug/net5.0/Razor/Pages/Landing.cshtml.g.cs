#pragma checksum "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Landing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1d66626ea304edb6a2d11398a2d04184bc3658"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Landing), @"mvc.1.0.razor-page", @"/Pages/Landing.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/pages")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1d66626ea304edb6a2d11398a2d04184bc3658", @"/Pages/Landing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df6f293cb7f076d22b878a9c5d94cdf5a1f5f549", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Landing : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4 class=\"bg-info text-white text-center p-2\">Pages - Level 1 - Anyone</h4>\r\n\r\n<div class=\"text-center\">\r\n    <h6 class=\"p-2\">\r\n        The store contains ");
#nullable restore
#line 8 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Pages\Landing.cshtml"
                      Write(Model.DbContext.Products.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" products.\r\n    </h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityApp.Pages.LandingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.LandingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.LandingModel>)PageContext?.ViewData;
        public IdentityApp.Pages.LandingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591