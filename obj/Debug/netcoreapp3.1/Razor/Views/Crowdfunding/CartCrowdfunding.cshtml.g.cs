#pragma checksum "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6a23b7b91308833c59fb196e08236bad4db26c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Crowdfunding_CartCrowdfunding), @"mvc.1.0.view", @"/Views/Crowdfunding/CartCrowdfunding.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6a23b7b91308833c59fb196e08236bad4db26c", @"/Views/Crowdfunding/CartCrowdfunding.cshtml")]
    public class Views_Crowdfunding_CartCrowdfunding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetFostHer.Models.Crowdfunding>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
  
//Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb6a23b7b91308833c59fb196e08236bad4db26c3056", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Ajouter au panier</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb6a23b7b91308833c59fb196e08236bad4db26c4127", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <fieldset>\r\n            <legend>Ajouter au panier : </legend>\r\n            <br />\r\n            ");
#nullable restore
#line 21 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.LabelFor(m => Model.NameCrowdfunding));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.TextBoxFor(m => Model.NameCrowdfunding, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.ValidationMessageFor(m => Model.NameCrowdfunding));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n\r\n         \r\n            ");
#nullable restore
#line 27 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.LabelFor(m => Model.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.TextBoxFor(m => Model.StartDate, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.ValidationMessageFor(m => Model.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 31 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.LabelFor(m => Model.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.TextBoxFor(m => Model.EndDate, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.ValidationMessageFor(m => Model.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 35 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.LabelFor(m => Model.MinDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 36 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.TextBoxFor(m => Model.MinDonation, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.ValidationMessageFor(m => Model.MinDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 39 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.LabelFor(m => Model.MaxDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 40 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.TextBoxFor(m => Model.MaxDonation, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.ValidationMessageFor(m => Model.MaxDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n           \r\n            ");
#nullable restore
#line 44 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.LabelFor(m => Model.AmountMax));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 45 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.TextBoxFor(m => Model.AmountMax, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 46 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.ValidationMessageFor(m => Model.AmountMax));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 48 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.LabelFor(m => Model.Donation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 49 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.EditorFor(m => Model.Donation, new {htmlAttributes = new {type="number", min = Model.MinDonation, max = Model.MaxDonation } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 50 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
       Write(Html.ValidationMessageFor(m => Model.Donation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n            <br />\r\n\r\n            <br />\r\n            <input type=\"submit\" value=\"Confirmer\" />\r\n\r\n\r\n        </fieldset>\r\n");
#nullable restore
#line 62 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h1 align=\"center\">");
#nullable restore
#line 63 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\CartCrowdfunding.cshtml"
                  Write(Html.ActionLink("Afficher mon panier", "IndexCart", "Cart", new { id = Model.user.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetFostHer.Models.Crowdfunding> Html { get; private set; }
    }
}
#pragma warning restore 1591
