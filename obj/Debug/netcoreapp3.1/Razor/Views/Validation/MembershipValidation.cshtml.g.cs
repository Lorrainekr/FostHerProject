#pragma checksum "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80cedcc2a2418a21eaf87035197500a9259aa35c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Validation_MembershipValidation), @"mvc.1.0.view", @"/Views/Validation/MembershipValidation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80cedcc2a2418a21eaf87035197500a9259aa35c", @"/Views/Validation/MembershipValidation.cshtml")]
    public class Views_Validation_MembershipValidation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetFostHer.Models.Artist>
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
#nullable restore
#line 3 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
  
//ViewBag.Title = "Membership Artist";
Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80cedcc2a2418a21eaf87035197500a9259aa35c3065", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Demande d\'adh??sion</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80cedcc2a2418a21eaf87035197500a9259aa35c4138", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <section class=\"container container_label\">\r\n            <div class=\"label_title\">\r\n                <h2>Formulaire d\'adh??sion ?? une association\'</h2>\r\n            </div>\r\n            <div class=\"label_content_info\">\r\n                <h3");
                BeginWriteAttribute("class", " class=\"", 540, "\"", 548, 0);
                EndWriteAttribute();
                WriteLiteral(">Mes coordonn??es</h3>\r\n                <fieldset class=\"label_content\">\r\n                    <div class=\"label_block\">\r\n                        <div class=\"label_block_text\">\r\n                            ");
#nullable restore
#line 27 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.LabelFor(m => Model.StageName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 28 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.LabelFor(m => Model.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.LabelFor(m => Model.Siret));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.LabelFor(m => Model.association.AssoName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"label_block_form\">\r\n                            ");
#nullable restore
#line 34 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.TextBoxFor(m => Model.StageName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.TextBoxFor(m => Model.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.TextBoxFor(m => Model.Siret));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"dropdownlist\">\r\n                                ");
#nullable restore
#line 38 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                           Write(Html.DropDownListFor(modelItem => modelItem.association.AssoName, new[] { new SelectListItem { Text = "La Fabrique de la Danse", Value = "La Fabrique de la Danse" }, new SelectListItem { Text = "Femmes artistes ici et l??-bas", Value = "Femmes artistes ici et l??-bas" }, new SelectListItem { Text = "Sortir les femmes de l'ombre", Value = "Sortir les femmes de l'ombre" }, new SelectListItem { Text = "AWARE", Value = "AWARE" }, new SelectListItem { Text = "Astrea", Value = "Astrea" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n\r\n");
                WriteLiteral("                        </div>\r\n                        <div class=\"label_block_warning\">\r\n                            ");
#nullable restore
#line 44 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.StageName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 45 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 46 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
                       Write(Html.ValidationMessageFor(m => Model.Siret));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>

                    </div>
                    
                    <div class=""button_orange"">
                        <input type=""submit"" value=""Ajouter"" />
                    </div>
                </fieldset>
            </div>
        </section>
");
#nullable restore
#line 57 "C:\Git_proj2\FostHerProject\Views\Validation\MembershipValidation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
