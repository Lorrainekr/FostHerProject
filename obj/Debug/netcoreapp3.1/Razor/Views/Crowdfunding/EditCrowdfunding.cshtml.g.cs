#pragma checksum "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4215cee4e4f37ae6b7ae778fc7870223b1dc90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Crowdfunding_EditCrowdfunding), @"mvc.1.0.view", @"/Views/Crowdfunding/EditCrowdfunding.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4215cee4e4f37ae6b7ae778fc7870223b1dc90", @"/Views/Crowdfunding/EditCrowdfunding.cshtml")]
    public class Views_Crowdfunding_EditCrowdfunding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetFostHer.Models.Crowdfunding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate-vsdoc.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4215cee4e4f37ae6b7ae778fc7870223b1dc904259", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Editer les données du crowdfunding</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4215cee4e4f37ae6b7ae778fc7870223b1dc905347", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <section class=\"container container_label\">\r\n            <div class=\"label_title\">\r\n                <h2>Formulaire d\'édition du crowdfunding</h2>\r\n            </div>\r\n            <div class=\"label_content_info\">\r\n                <h3");
                BeginWriteAttribute("class", " class=\"", 520, "\"", 528, 0);
                EndWriteAttribute();
                WriteLiteral(">Informations</h3>\r\n                <fieldset class=\"label_content\">\r\n                    <div class=\"label_block\">\r\n                        <div class=\"label_block_text\">\r\n                            ");
#nullable restore
#line 25 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.LabelFor(m => Model.NameCrowdfunding));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 26 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.LabelFor(m => Model.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.LabelFor(m => Model.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 28 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.LabelFor(m => Model.MinDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.LabelFor(m => Model.MaxDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.LabelFor(m => Model.AmountMax));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                        <div class=\"label_block_form\">\r\n                            ");
#nullable restore
#line 35 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.TextBoxFor(m => Model.NameCrowdfunding ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.TextBoxFor(m => Model.StartDate ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.TextBoxFor(m => Model.EndDate ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 38 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.TextBoxFor(m => Model.MinDonation ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 39 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.TextBoxFor(m => Model.MaxDonation ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 40 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.TextBoxFor(m => Model.AmountMax ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                        <div class=\"label_block_warning\">\r\n                            ");
#nullable restore
#line 44 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.NameCrowdfunding));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 45 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 46 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.MinDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 48 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.MaxDonation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 49 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.AmountMax));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""button_orange"">
                        <input type=""submit"" value=""Modifier"" />
                    </div>
                </fieldset>
            </div>


        </section>
");
#nullable restore
#line 60 "C:\Git_proj2\FostHerProject\Views\Crowdfunding\EditCrowdfunding.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4215cee4e4f37ae6b7ae778fc7870223b1dc9012424", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4215cee4e4f37ae6b7ae778fc7870223b1dc9013524", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4215cee4e4f37ae6b7ae778fc7870223b1dc9014624", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
