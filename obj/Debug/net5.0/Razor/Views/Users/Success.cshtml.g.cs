#pragma checksum "C:\Users\robi\Desktop\Rabi\Views\Users\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "804f4f271617ec1808c8c7483f8f8c7652989517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Success), @"mvc.1.0.view", @"/Views/Users/Success.cshtml")]
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
#line 1 "C:\Users\robi\Desktop\Rabi\Views\_ViewImports.cshtml"
using Lost_and_Found;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\robi\Desktop\Rabi\Views\_ViewImports.cshtml"
using Lost_and_Found.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\robi\Desktop\Rabi\Views\Users\Success.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"804f4f271617ec1808c8c7483f8f8c7652989517", @"/Views/Users/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8df4b686de749b5f55122cbab12f90f045c4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lost_and_Found.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\robi\Desktop\Rabi\Views\Users\Success.cshtml"
   ViewData["Title"] = "Success"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Login Successful</h2>\r\n\r\n<br />\r\n\r\n<script>\r\n    setTimeout(function() {\r\n        window.location.href = \'");
#nullable restore
#line 11 "C:\Users\robi\Desktop\Rabi\Views\Users\Success.cshtml"
                           Write(Url.Action("Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    }, 2000); // 2000 milliseconds (2 seconds) delay\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lost_and_Found.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
