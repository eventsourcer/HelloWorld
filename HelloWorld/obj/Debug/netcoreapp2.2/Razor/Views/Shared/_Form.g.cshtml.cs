#pragma checksum "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39dd6a71bd6f17b33a9a4e3b0c453231e344db40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Form), @"mvc.1.0.view", @"/Views/Shared/_Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Form.cshtml", typeof(AspNetCore.Views_Shared__Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39dd6a71bd6f17b33a9a4e3b0c453231e344db40", @"/Views/Shared/_Form.cshtml")]
    public class Views_Shared__Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloWorld.Models.Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
  
    string action = @ViewData["title"].ToString() == "Create action" ? "FormProcessor" : "EditProcessor";

#line default
#line hidden
            BeginContext(152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
 using (Html.BeginForm(FormMethod.Post, new { @action = action }))
{

#line default
#line hidden
            BeginContext(225, 30, true);
            WriteLiteral("<table class=\"table-create\">\r\n");
            EndContext();
#line 10 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
         if (action == "EditProcessor")
        {
            ViewContext.Writer.Write(Html.TextBoxFor(x => x.id, null, new { @type = "hidden" }));
        }

#line default
#line hidden
            BeginContext(417, 66, true);
            WriteLiteral("\r\n    <tr>\r\n        <th>Full name</th>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(484, 101, false);
#line 18 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.TextBoxFor(x => x.Name, null, new { @class = "form-control",placeholder="Type your full name" }));

#line default
#line hidden
            EndContext();
            BeginContext(585, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(600, 38, false);
#line 19 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(638, 91, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Position</th>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(730, 113, false);
#line 25 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.TextBoxFor(x => x.Position, null, new { @class = "form-control", placeholder = "Type your position title" }));

#line default
#line hidden
            EndContext();
            BeginContext(843, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(858, 42, false);
#line 26 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.ValidationMessageFor(x => x.Position));

#line default
#line hidden
            EndContext();
            BeginContext(900, 93, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Department</th>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(994, 114, false);
#line 32 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.TextBoxFor(x => x.Department, null, new { @class = "form-control", placeholder = "Type department section" }));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1123, 44, false);
#line 33 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.ValidationMessageFor(x => x.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 88, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Email</th>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1256, 109, false);
#line 39 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.TextBoxFor(x => x.Email, null, new { @class = "form-control", placeholder = "Type your email address" }));

#line default
#line hidden
            EndContext();
            BeginContext(1365, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1380, 39, false);
#line 40 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 88, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Grade</th>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1508, 107, false);
#line 46 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.TextBoxFor(x => x.Grade, null, new { @class = "form-control", placeholder = "Type your grade level" }));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1630, 39, false);
#line 47 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.ValidationMessageFor(x => x.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 89, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Gender</th>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1759, 103, false);
#line 53 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.TextBoxFor(x => x.Gender, null, new { @class = "form-control", placeholder = "Type your gender" }));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1877, 40, false);
#line 54 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
       Write(Html.ValidationMessageFor(x => x.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 72, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th><button type=\"submit\">");
            EndContext();
#line 58 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
                                     ViewContext.Writer.Write(action == "FormProcessor" ? "Create" : "Update"); 

#line default
#line hidden
            BeginContext(2068, 37, true);
            WriteLiteral("</button></th>\r\n    </tr>\r\n</table>\r\n");
            EndContext();
#line 61 "C:\Users\Administrator.pc-PC\Documents\ASP.Net Core\HelloWorld\HelloWorld\Views\Shared\_Form.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWorld.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
