#pragma checksum "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa4e0f40ef81132bd49e111cf3f3ab6519927d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\_ViewImports.cshtml"
using FinalProjectRestorant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\_ViewImports.cshtml"
using FinalProjectRestorant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\_ViewImports.cshtml"
using FinalProjectRestorant.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa4e0f40ef81132bd49e111cf3f3ab6519927d6", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d0f50235f1edbd527fdad75fa2dfb76114423f", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Full Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("E-mail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-value message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">
    <section>
        <div class=""map"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3036.052775232489!2d49.74419201537426!3d40.45196887936107!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x403085da946625ff%3A0x2be4f3680f7341c8!2zWMSxcmRhbGFuIFBhcmvEsQ!5e0!3m2!1sen!2s!4v1634663486292!5m2!1sen!2s""
                    width=""100%"" height=""450px"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 484, "\"", 502, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"">
            </iframe>
        </div>
    </section>

    <section id=""send-message"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-sm-12 up"">
                    <div class=""col-lg-12 up-2"">
                        <h3>
                            Send a Message
                        </h3>
                    </div>
                    <div class=""col-lg-12 up-2"">
                        <p>
                            Potenti inceptos, facilisi, pariatur netus, scelerisque. Porta eum sapiente temporibus,
                            placerat voluptates! Debitis necessitatibus fugit nesciunto malesuada consequat nostra
                            accusamus commodi.
                        </p>
                        <br>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4e0f40ef81132bd49e111cf3f3ab6519927d67847", async() => {
                WriteLiteral("\r\n                            <div class=\"inputs\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8aa4e0f40ef81132bd49e111cf3f3ab6519927d68191", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8aa4e0f40ef81132bd49e111cf3f3ab6519927d69891", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 34 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                            <br>\r\n                            <div class=\"inputs col-md-12\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4e0f40ef81132bd49e111cf3f3ab6519927d611730", async() => {
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 38 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                            </div>
                            <br>
                            <button class=""anima-button circle-button btn-xs btn w-100"" type=""submit"">
                                <i class=""fas fa-inbox""></i>
                                Send Message
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-lg-6 col-sm-12 down"">
                    <div class=""col-lg-12"">
                        <h3 class=""col-lg-12"">
                            How To Reach Us
                        </h3>
                        <div class=""col-lg-12"">
                            <p>
                                ");
#nullable restore
#line 57 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                           Write(Model.HowToReach);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <ul class=""fa-ul down1"">
                                    <li>
                                        <i class=""fab fa-skype""></i>
                                        ");
#nullable restore
#line 65 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </li>\r\n                                    <li>\r\n                                        <i class=\"fas fa-headset\"></i>\r\n                                        ");
#nullable restore
#line 69 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                                   Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </li>\r\n                                    <li>\r\n                                        <i class=\"fas fa-mail-bulk\"></i>\r\n                                        ");
#nullable restore
#line 73 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </li>\r\n                                    <li>\r\n                                        <i class=\"fab fa-skype\"></i>\r\n                                        ");
#nullable restore
#line 77 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </li>\r\n                                    <li>\r\n                                        <i class=\"fab fa-skype\"></i>\r\n                                        ");
#nullable restore
#line 82 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    </li>
                                </ul>
                            </div>
                            <div class=""col-md-6"">
                                <ul class=""fa-ul down1"">
                                    <li>
                                        <i class=""fas fa-house-user""></i>
                                        ");
#nullable restore
#line 91 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                                   Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </li>\r\n                                    <li>\r\n                                        <i class=\"fas fa-house-user\"></i>\r\n                                        ");
#nullable restore
#line 95 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
                                   Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""text-center"">
                        <div class=""btn-group btn-group-icons"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 4869, "\"", 4894, 1);
#nullable restore
#line 103 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
WriteAttributeValue("", 4876, Model.SocialMedia, 4876, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default contact\">\r\n                                <i class=\"fab fa-facebook-square\"></i>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5066, "\"", 5091, 1);
#nullable restore
#line 106 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
WriteAttributeValue("", 5073, Model.SocialMedia, 5073, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default contact\">\r\n                                <i class=\"fab fa-twitter-square\"></i>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5262, "\"", 5287, 1);
#nullable restore
#line 109 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
WriteAttributeValue("", 5269, Model.SocialMedia, 5269, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default contact\">\r\n                                <i class=\"fab fa-google\"></i>\r\n                            </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5450, "\"", 5475, 1);
#nullable restore
#line 112 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Contact\Index.cshtml"
WriteAttributeValue("", 5457, Model.SocialMedia, 5457, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-default contact"">
                                <i class=""fab fa-linkedin""></i>
                            </a>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </section>
</main>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
