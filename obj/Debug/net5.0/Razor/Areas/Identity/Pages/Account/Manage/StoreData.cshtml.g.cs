#pragma checksum "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\StoreData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efec18f13003e479beddfb5f6444abc1530013a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_StoreData), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/StoreData.cshtml")]
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
#line 1 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\_ViewImports.cshtml"
using IdentityApp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\_ViewImports.cshtml"
using IdentityApp.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using IdentityApp.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using IdentityApp.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efec18f13003e479beddfb5f6444abc1530013a0", @"/Areas/Identity/Pages/Account/Manage/StoreData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457115739e576cc5e4d96e842ae6ec86333ed1da", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ccee0d937a37f1edc2704a7e4de796654785dbd", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c0f5775a9785330713cc58839130eace5b004d0", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_StoreData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\StoreData.cshtml"
  
    ViewData["ActivePage"] = ManageNavPages.StoreData;
    ViewData["ParentLayout"] = "_InfoLayout";
    IdentityUser user = await UserManager.GetUserAsync(User);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Store Data</h4>

<table class=""table table-sm table-bordered table-striped"">
    <thead>
        <tr>
            <th>Property</th>
            <th>Value</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Id</td>
            <td>");
#nullable restore
#line 21 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\StoreData.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\StoreData.cshtml"
         foreach (var prop in typeof(IdentityUser).GetProperties())
        {
            if (prop.Name != "Id")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\StoreData.cshtml"
                   Write(prop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-truncate\" style=\"max-width:250px\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\StoreData.cshtml"
                   Write(prop.GetValue(user));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\serge.abazefils\Documents\Visual studio code\AspNetcoreAuth2\IdentityMsManagement\IdentityApp\Areas\Identity\Pages\Account\Manage\StoreData.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_Manage_StoreData> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Manage_StoreData> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Manage_StoreData>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_Manage_StoreData Model => ViewData.Model;
    }
}
#pragma warning restore 1591
