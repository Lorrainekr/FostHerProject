#pragma checksum "C:\Git_proj2\FostHerProject\Views\Artist\PageArtist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fd9c798b33e48c2c0fcf2f17acfd3dd1dcaa69f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artist_PageArtist), @"mvc.1.0.view", @"/Views/Artist/PageArtist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd9c798b33e48c2c0fcf2f17acfd3dd1dcaa69f", @"/Views/Artist/PageArtist.cshtml")]
    public class Views_Artist_PageArtist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetFostHer.Models.Artist>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/artiste_4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Git_proj2\FostHerProject\Views\Artist\PageArtist.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fd9c798b33e48c2c0fcf2f17acfd3dd1dcaa69f3763", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 11 "C:\Git_proj2\FostHerProject\Views\Artist\PageArtist.cshtml"
      Write(Model.StageName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fd9c798b33e48c2c0fcf2f17acfd3dd1dcaa69f5023", async() => {
                WriteLiteral("\r\n    <!-- Page Artiste -->\r\n    <section class=\"page-artiste-container container\">\r\n        <div class=\"tilte-page-artiste\">\r\n            <h2>");
#nullable restore
#line 17 "C:\Git_proj2\FostHerProject\Views\Artist\PageArtist.cshtml"
           Write(Model.StageName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <div class=\"line-break-black\"></div>\r\n        </div>\r\n        <div class=\"page_artist_content\">\r\n            <div class=\"page-artiste-block-left\">\r\n                <div class=\"description-artiste\">\r\n                    <h3>");
#nullable restore
#line 23 "C:\Git_proj2\FostHerProject\Views\Artist\PageArtist.cshtml"
                   Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                    <p>Mendieta cr???? des objets d'art, y compris des dessins et des sculptures.</p>
                    <p>
                        Le travail de Mendieta est g??n??ralement autobiographique et porte sur des th??mes tels que le f??minisme,
                        la violence, la vie, la mort. Mendieta s???est souvent concentr??e sur un lien spirituel et physique avec la Terre.
                    <p>
                    <p>
                        Mendieta cr??e des silhouettes f??minines dans la nature, dans la boue, le sable et l'herbe avec des
                        mat??riaux naturels et fait des impressions de son corps ou de sa silhouette en les imprimant sur un mur,
                        d???o?? le nom ?? silhouette sur un mur??
                    </p>
                    <p>
                        Elle continue ?? utiliser des ??l??ments naturels dans son travail. Gr??ce ?? ces travaux, qui d??passent
                        les limites de la performance, le cin??ma et la photographi");
                WriteLiteral(@"e, Mendieta explore sa relation avec la Terre
                        m??re ou la ?? Grande D??esse ?? (Great Goddess).
                    </p>
                </div>
            </div>
            <div class=""page-artiste-block-right"">
                <div class=""image-artiste"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8fd9c798b33e48c2c0fcf2f17acfd3dd1dcaa69f7506", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"artist_link\">\r\n                    <div class=\"icons-social-media\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2189, "\"", 2196, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <i class=\"fab fa-facebook-square\"></i>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2324, "\"", 2331, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""fab fa-instagram""></i>
                        </a>
                    </div>
                    <div class=""button_orange"">
                        <a>Contacter</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetFostHer.Models.Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
