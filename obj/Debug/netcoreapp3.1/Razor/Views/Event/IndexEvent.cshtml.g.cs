#pragma checksum "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ae2faafab803cbd463520a06cdd1030f2a8c523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_IndexEvent), @"mvc.1.0.view", @"/Views/Event/IndexEvent.cshtml")]
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
#line 4 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
using ProjetFostHer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ae2faafab803cbd463520a06cdd1030f2a8c523", @"/Views/Event/IndexEvent.cshtml")]
    public class Views_Event_IndexEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("evenement_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/visuel_evenement.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/visuel_crowdfunding.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
  
Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae2faafab803cbd463520a06cdd1030f2a8c5234627", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Evenements</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae2faafab803cbd463520a06cdd1030f2a8c5235695", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
     if (ViewBag.user == "A")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <section class=\"container\">\r\n            <h1>Tous les ??v??nements</h1>\r\n            <ul>\r\n                <li>");
#nullable restore
#line 20 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
               Write(Html.ActionLink("Cr??er un ??v??nement", "CreateEvent", "Event"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            </ul>\r\n        </section>\r\n");
#nullable restore
#line 23 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <!-- AJOUTER HOME LES EVENT (d??j?? dev en page d'accueil du site)-->

        <section class=""container evenements-container-items-home event_container_block"">

            <div class=""evenements-gallery-title-home"">
                <h2>??a se passe en ce moment sur Fosther !</h2>
            </div>
            <div class=""evenements-gallery-home"">
                <article class=""evenement-block-vertical"">
                    <div class=""evenement-image-home"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ae2faafab803cbd463520a06cdd1030f2a8c5237299", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"button_orange button_event_block\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1211, "\"", 1218, 0);
                EndWriteAttribute();
                WriteLiteral(@">Participer</a>
                        </div>
                    </div>

                    <div class=""evenement-nom-home"">
                        <h3>Art Paper Rosa</h3>
                        <p> Nov 18, 2021</p>
                        <p>
                            L???artiste fran??aise Rosa Loy pr??sentera douze
                            ??uvres typiques de son style po??tique et onirique. Ses compositions mettent en sc??ne des
                            personnages exclusivement f??minins...
                        </p>
                    </div>
                </article>
                <article class=""evenement-block-vertical"">
                    <div class=""evenement-image-home"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ae2faafab803cbd463520a06cdd1030f2a8c5239567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"button_orange button_event_block\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 2195, "\"", 2202, 0);
                EndWriteAttribute();
                WriteLiteral(@">Participer</a>
                        </div>
                    </div>

                    <div class=""evenement-nom-home"">
                        <h3>Artcurial</h3>
                        <p>Oct 24, 2021</p>
                        <p>
                            Artcurial offre un vaste panorama du dessin, en privil??giant les ??uvres contemporaines et
                            celles r??alis??es sur papier ou carton, et vise ?? revaloriser l???art essentiel du dessin...
                        </p>
                    </div>
                </article>
                <article class=""evenement-block-vertical"">
                    <div class=""evenement-image-home"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ae2faafab803cbd463520a06cdd1030f2a8c52311807", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"button_orange button_event_block\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3151, "\"", 3158, 0);
                EndWriteAttribute();
                WriteLiteral(@">Participer</a>
                        </div>
                    </div>
                    <div class=""evenement-nom-home"">
                        <h3> Marseau</h3>
                        <p> Sept 29, 2021</p>
                        <p>
                            La collaboration entre la peintre DanH??o et la musicienne Stephanie Grangier porte plus loin les
                            inspirations crois??es entre peinture et musique, fr??quentes dans l???histoire de l???art...
                        </p>
                    </div>
                </article>
            </div>
        </section>
        <section class=""separator_line""></section>
        <!-- ecran principal : barre de recherche lat??rale gauche et r??sultats de recherche -->
        <container class=""container_event_list"">
            <div class=""artist_search_block"">
                <div class=""button_orange"">
                    ");
#nullable restore
#line 96 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
               Write(Html.ActionLink("Cr??er votre ??v??nement", "CreateEvent", "Event"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <section class=""list_searchbar"">
                    <input type=""text"" class=""search_bar"" id=""search"" placeholder=""Rechercher..."">
                    <div class=""filter"">
                        <h4 class=""filter"">Ev??nements</h4>
                        <label class=""container_search"">
                            <input type=""radio"" class=""checkmark-radio"">Nouveaux
                        </label><br />
                        <label class=""container_search"">
                            <input type=""radio"" class=""checkmark-radio"">Populaires
                        </label><br />
                        <label class=""container_search"">
                            <input type=""radio"" class=""checkmark-radio"">S??lection de la r??daction
                        </label><br />
                    </div>

                    <div class=""filter-date"">
                        <!-- documentation date : https://developer.mozilla.org/en-US/docs/Web/HTML/Element/in");
                WriteLiteral(@"put/date -->
                        <h4 class=""filter"">Par date</h4>
                        <label for=""start"">D??but :</label>

                        <input type=""date""
                               id=""start""
                               name=""event-start""
                               value=""2021-09-23""
                               min=""2021-09-17""
                               max=""2022-01-01""><br /><br />

                        <label for=""start"">Fin :</label>
                        <input type=""date"" id=""end"" name=""event-end"" value=""2021-09-24"" min=""2021-09-17"" max=""2022-01-01"">
                    </div>

                    <div class=""filter-type"">
                        <h4 class=""filter"">Par type</h4>
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Exposition
                        </label><br />
                        <label class=""container_search"">
                            <input");
                WriteLiteral(@" type=""checkbox"" class=""checkmark"">Spectacle
                        </label><br />
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Rencontre
                        </label><br />
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Hors les murs
                        </label><br />
                    </div>

                    <div class=""filter"">
                        <h4 class=""filter"">Par th??matique</h4>
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Peinture
                        </label><br />
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Cin??ma
                        </label><br />
                        <label class=""container_search"">
                            <inp");
                WriteLiteral(@"ut type=""checkbox"" class=""checkmark"">Sculpture
                        </label><br />
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Street Art
                        </label><br />
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Musique
                        </label><br />
                        <label class=""container_search"">
                            <input type=""checkbox"" class=""checkmark"">Danse
                        </label><br />
                    </div>


                    <div class=""filter-prix"">
                        <h4 class=""filter"">Par budget</h4>
                        <label class=""container_search"">
                            <input type=""radio"" class=""checkmark-radio"">Gratuit
                        </label><br />
                    </div>
                </section>
            </div>
            <");
                WriteLiteral("section>\r\n                <!-- Liste des r??sultats - cartes event -->\r\n                <div class=\"evenements_list_title\">\r\n                    <h2>Tous les ??v??nements</h2>\r\n                </div>\r\n                <div class=\"event_list\">\r\n\r\n");
#nullable restore
#line 183 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                     foreach (Event e in ViewBag.listEvents)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"event_card\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0ae2faafab803cbd463520a06cdd1030f2a8c52319514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 8701, "image", 8701, 5, true);
                AddHtmlAttributeValue(" ", 8706, "de", 8707, 3, true);
                AddHtmlAttributeValue(" ", 8709, "l\'??v??nement", 8710, 12, true);
#nullable restore
#line 186 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
AddHtmlAttributeValue(" ", 8721, e.Designation, 8722, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <h5 class=\"event_artist\">");
#nullable restore
#line 187 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                                                Write(e.ArtistEvent.StageName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <div class=\"event_block_content\">\r\n                                <h3>");
#nullable restore
#line 189 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                               Write(e.Designation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                <div class=\"event_type_content\">\r\n                                    <div class=\"line-break-card\"></div>\r\n                                    <h4>");
#nullable restore
#line 192 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                                   Write(e.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 192 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                                                            Write(e.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                </div>\r\n\r\n                                <div class=\"event_KPI\">\r\n                                    <p><strong class=\"bold\">Infos</strong></p>\r\n                                    <p>Du ");
#nullable restore
#line 197 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                                     Write(e.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />au ");
#nullable restore
#line 197 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                                                           Write(e.EndDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 198 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                                  Write(e.Lieu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>Prix : ");
#nullable restore
#line 199 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                                         Write(e.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ???</p>\r\n                                </div>\r\n                                <div class=\"event_card_link_content\">\r\n                                    ");
#nullable restore
#line 202 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                               Write(Html.ActionLink("Voir l'??v??nement", "PageEvent", "Event", new { id = e.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 206 "C:\Git_proj2\FostHerProject\Views\Event\IndexEvent.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
            </section>
        </container>
        <!-- pagination bas de page -->
        <section class=""pagination_container"">
            <ul class=""pagination"">
                <li><a href=""#"" class=""p-button""><i class=""fas fa-chevron-left""></i></a></li>
                <li><a href=""#"" class=""p-button"">1</a></li>
                <li><a href=""#"" class=""p-button"">2</a></li>
                <li><a href=""#"" class=""p-button"">3</a></li>
                <li><a href=""#"" class=""p-button"">4</a></li>
                <li><a href=""#"" class=""p-button""><i class=""fas fa-chevron-right""></i></a></li>
            </ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
