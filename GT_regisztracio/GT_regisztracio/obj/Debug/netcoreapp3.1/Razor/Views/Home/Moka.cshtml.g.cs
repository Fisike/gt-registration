#pragma checksum "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbdd631416cce63a08ee2b92105b92d03ec75942"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Moka), @"mvc.1.0.view", @"/Views/Home/Moka.cshtml")]
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
#line 1 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\_ViewImports.cshtml"
using GT_regisztracio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\_ViewImports.cshtml"
using GT_regisztracio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbdd631416cce63a08ee2b92105b92d03ec75942", @"/Views/Home/Moka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8c5c159f17faaf455ed5e507ace2b7bf970a23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Moka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GT_regisztracio.Models.EredmenyVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
  
    ViewData["Title"] = "Moka";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Moka</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
           Write(Html.DisplayNameFor(model => model.Nev));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
           Write(Html.DisplayNameFor(model => model.Neptun));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
           Write(Html.DisplayNameFor(model => model.Osszpont));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nev));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
               Write(Html.DisplayFor(modelItem => item.Neptun));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
               Write(Html.DisplayFor(modelItem => item.Osszpont));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 47 "C:\Users\fisch\source\repos\GT_regisztracio\GT_regisztracio\Views\Home\Moka.cshtml"
Write(Html.ActionLink("Vissza", "Eredmeny"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GT_regisztracio.Models.EredmenyVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
