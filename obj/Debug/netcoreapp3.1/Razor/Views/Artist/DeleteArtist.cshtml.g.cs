#pragma checksum "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f4a9085461ac407194fc5292bedfefd6fd2b18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artist_DeleteArtist), @"mvc.1.0.view", @"/Views/Artist/DeleteArtist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f4a9085461ac407194fc5292bedfefd6fd2b18", @"/Views/Artist/DeleteArtist.cshtml")]
    public class Views_Artist_DeleteArtist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetFostHer.Models.Artist>
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
#line 2 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f4a9085461ac407194fc5292bedfefd6fd2b184193", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>SupprimerLesDonnéesArtiste</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f4a9085461ac407194fc5292bedfefd6fd2b185273", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <section class=\"container container_label\">\r\n            <div class=\"label_title\">\r\n                <h2>Formulaire de suppréssion de compte artiste</h2>\r\n            </div>\r\n            <div class=\"label_content_info\">\r\n                <h3");
                BeginWriteAttribute("class", " class=\"", 513, "\"", 521, 0);
                EndWriteAttribute();
                WriteLiteral(">Mes coordonnées</h3>\r\n                <fieldset class=\"label_content\">\r\n                    <div class=\"label_block\">\r\n                        <div class=\"label_block_text\">\r\n                            ");
#nullable restore
#line 25 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 26 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.StageName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 28 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.Siret));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"label_block_form\">\r\n                            ");
#nullable restore
#line 34 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.LastName, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.FirstName, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.StageName, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.Category.CategoryName, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 38 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.Siret, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 39 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.Address, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                        <div class=\"label_block_warning\">\r\n                            ");
#nullable restore
#line 43 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 44 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 45 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.StageName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 46 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.Siret));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 48 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </fieldset>
            </div>
            <div class=""label_content_login"">
                <h3>Mes informations de connexion</h3>
                <fieldset class=""label_content"">
                    <div class=""label_block"">
                        <div class=""label_block_text"">
                            ");
#nullable restore
#line 58 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 59 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.LabelFor(m => Model.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"label_block_form\">\r\n                            ");
#nullable restore
#line 63 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.Email, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 64 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.TextBoxFor(m => Model.Password, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                        <div class=\"label_block_warning\">\r\n                            ");
#nullable restore
#line 68 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 69 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""button_orange"">
                        <input type=""submit"" value=""Supprimer"" />
                    </div>
                </fieldset>
            </div>
        </section>
");
#nullable restore
#line 79 "C:\Git_proj2\FostHerProject\Views\Artist\DeleteArtist.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f4a9085461ac407194fc5292bedfefd6fd2b1814619", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f4a9085461ac407194fc5292bedfefd6fd2b1815719", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f4a9085461ac407194fc5292bedfefd6fd2b1816819", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetFostHer.Models.Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
