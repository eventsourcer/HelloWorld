#pragma checksum "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\Components\PostedData\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62c80a877d417dcb94594b100bd8408726c222af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PostedData_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PostedData/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PostedData/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PostedData_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c80a877d417dcb94594b100bd8408726c222af", @"/Views/Shared/Components/PostedData/Default.cshtml")]
    public class Views_Shared_Components_PostedData_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HelloWorld.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 122, true);
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Post ID</th>\r\n        <th>Post content</th>\r\n        <th>Post date time</th>\r\n    </tr>\r\n");
            EndContext();
#line 9 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\Components\PostedData\Default.cshtml"
     foreach (var post in Model)
    {

#line default
#line hidden
            BeginContext(207, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(238, 7, false);
#line 12 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\Components\PostedData\Default.cshtml"
           Write(post.id);

#line default
#line hidden
            EndContext();
            BeginContext(245, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(269, 9, false);
#line 13 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\Components\PostedData\Default.cshtml"
           Write(post.post);

#line default
#line hidden
            EndContext();
            BeginContext(278, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(302, 19, false);
#line 14 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\Components\PostedData\Default.cshtml"
           Write(post.postedDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(321, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 16 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\Components\PostedData\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(350, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HelloWorld.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
