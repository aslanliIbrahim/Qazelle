#pragma checksum "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a263b2be0167300f7fb63ebbd1152ffa24119be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a263b2be0167300f7fb63ebbd1152ffa24119be", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d0f50235f1edbd527fdad75fa2dfb76114423f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Shared\Components\Header\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header>
    <div class=""container"">
        <nav>
            <div class=""menu-icons"">

                <i class=""fas fa-bars""></i>
                <i class=""fas fa-window-close""></i>
            </div>
            <a href=""#"" class=""logo"">
                <i");
            BeginWriteAttribute("class", " class=\"", 314, "\"", 337, 2);
            WriteAttributeValue("", 322, "fas", 322, 3, true);
#nullable restore
#line 15 "C:\Users\MSI\Desktop\FinalProjectRestorant\FinalProjectRestorant\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue(" ", 325, Model.Eogo, 326, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></i>
            </a>
            <ul class=""nav-list"">
                <li>
                    <a href=""#"">Home</a>
                </li>
                <li>
                    <a href=""#"">Menu</a>
                    <ul class=""menu-table"">
                        <li><a href=""#"">Dinner</a></li>
                        <li><a href=""#"">Hot Meals</a></li>
                        <li><a href=""#"">Cold Meals</a></li>
                        <li><a href=""#"">Drinks</a></li>
                    </ul>
                </li>
                <li>
                    <a href=""#"">Reservation</a>
                </li>
                <li>
                    <a href=""#"">Services</a>
                    <ul class=""menu-table"">
                        <li><a href=""#"">Order</a></li>

                    </ul>
                </li>
                <li>
                    <a href=""#"">About</a>
                </li>
                <li>
                    <a href=""#"">Contact</a>
             ");
            WriteLiteral("   </li>\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1416, "\"", 1423, 0);
            EndWriteAttribute();
            WriteLiteral(">Login</a>\r\n                </li>\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1503, "\"", 1510, 0);
            EndWriteAttribute();
            WriteLiteral(">Sign Up</a>\r\n                </li>\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591
