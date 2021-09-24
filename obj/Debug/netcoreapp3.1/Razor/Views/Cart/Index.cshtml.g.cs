#pragma checksum "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d927d624dca461acacd580ff5ed12a95517dee66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d927d624dca461acacd580ff5ed12a95517dee66", @"/Views/Cart/Index.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetFostHer.Models.Cart>
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
#nullable restore
#line 2 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d927d624dca461acacd580ff5ed12a95517dee662858", async() => {
                WriteLiteral("\r\n    <title>Index</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d927d624dca461acacd580ff5ed12a95517dee663852", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""page-panier-container"">
            <div class=""page-panier-title"">
                <h3>Mon Panier</h3>
                <a class=""fas fa-shopping-cart""></a>
            </div>
            <div class=""panier-block-center"">
                <table class=""panier-table"">
                    <thead>
                        <tr>
                            <th>Produit</th>
                            <th>Prix (EUR)</th>
                            <th>Quantité <input type=""submit"" value=""Update"" /></th>
                            <th>Supprimer</th>
                            <th>Modifier</th>
                            <th>Sous-total</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 31 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                         for (int i = 0; i < Model.Items.Count; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 34 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                               Write(Model.Items[i].Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                               Write(Model.Items[i].Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 36 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                                Write(Html.TextBoxFor(m => Model.Items[i].Quantity, new { @type = "number", min = "1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                               Write(Html.ActionLink("Remove", "Remove", "Cart", new { id = @Model.Items[i].Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                               Write(Html.ActionLink("Modifier", "OnPostUpdate", "Cart", new { id = @Model.Items[i].Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                                Write(Model.Items[i].Product.Price * Model.Items[i].Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                ");
#nullable restore
#line 40 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                           Write(Html.HiddenFor(m => @Model.Items[i].Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 41 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                           Write(Html.HiddenFor(m => @Model.Items[i].Product.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </tr>\r\n");
#nullable restore
#line 43 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"panier-total-paiement\">\r\n                <div class=\"total-paiement-somme\">\r\n                    <h3>Total</h3>\r\n                    <p>");
#nullable restore
#line 50 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                   Write(Model.Items.Sum(item => item.Product.Price * item.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <button class=\"button_orange\">");
#nullable restore
#line 52 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
                                         Write(Html.ActionLink("Paiement", "PaymentEvent", "Payment", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</button>
                <p>Nous acceptons</p>
                <a class=""fab fa-cc-visa""></a>
                <a class=""fab fa-cc-mastercard""></a>
                <a class=""fab fa-cc-amex""></a>
                <a class=""fab fa-cc-paypal""></a>
            </div>
        </div>
");
#nullable restore
#line 60 "C:\Git_proj2\FostHerProject\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>4\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetFostHer.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
