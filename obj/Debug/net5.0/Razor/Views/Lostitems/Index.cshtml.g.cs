#pragma checksum "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f732266b2b965055a37db3e167afa50f8c89d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lostitems_Index), @"mvc.1.0.view", @"/Views/Lostitems/Index.cshtml")]
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
#line 2 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f732266b2b965055a37db3e167afa50f8c89d6", @"/Views/Lostitems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8df4b686de749b5f55122cbab12f90f045c4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Lostitems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lost_and_Found.Models.Lostitem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .table-bordered-light {
        border: 1px solid #e5e5e5; /* Light gray border color */
    }
        /* Add borders to table rows */
        .table-bordered-light tr {
            border: 1px solid #e5e5e5; /* Light gray border color */
        }

        /* Add borders to table cells (data cells) */
        .table-bordered-light td,
        .table-bordered-light th {
            border: 1px solid #e5e5e5; /* Light gray border color */
            padding: 8px; /* Add some padding for better spacing */
        }

        .table-bordered-light tbody tr:hover {
            background-color: #f5f5f5; /* Light gray background color on hover */
            cursor: pointer; /* Change cursor to pointer on hover */
        }
</style>
<div class=""container"">
    <div class=""d-flex justify-content-center align-items-center mt-5 mb-4"">
        <h1 class=""text-center btn btn-outline-info btn-lg text-black font-weight-bold"">Lost Items</h1>
    </div>

    <table class=""table table-b");
            WriteLiteral(@"ordered-light"">
        <thead class=""thead-dark"">
            <tr>
                <th>
                    Item Name
                </th>
                <th>
                    Category
                </th>
                <th>
                    Description
                </th>
                <th>
                    Lost Area
                </th>
                <th>
                    Date
                </th>
                <th>
                    Image
                </th>
                <th>
                    Action
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 59 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ItemCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LostArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2549, "\"", 2590, 1);
#nullable restore
#line 78 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
WriteAttributeValue("", 2555, Url.Content("~/img/" + item.Image), 2555, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" alt=\"Item Image\" />\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"btn-group\">\r\n");
#nullable restore
#line 82 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                              
                                var admin = Context.Session.GetString("Admin");
                                if (admin == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 2978, "\"", 3033, 1);
#nullable restore
#line 86 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
WriteAttributeValue("", 2985, Url.Action("Details", new { id = item.ItemId }), 2985, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">Details</a>\r\n");
#nullable restore
#line 87 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 3222, "\"", 3277, 1);
#nullable restore
#line 90 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
WriteAttributeValue("", 3229, Url.Action("Details", new { id = item.ItemId }), 3229, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">Details</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3358, "\"", 3410, 1);
#nullable restore
#line 91 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
WriteAttributeValue("", 3365, Url.Action("Edit", new { id = item.ItemId }), 3365, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Edit</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3491, "\"", 3545, 1);
#nullable restore
#line 92 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
WriteAttributeValue("", 3498, Url.Action("Delete", new { id = item.ItemId }), 3498, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Delete</a>\r\n");
#nullable restore
#line 93 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 100 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3809, "\"", 3837, 1);
#nullable restore
#line 105 "C:\Users\robi\Desktop\Rabi\Views\Lostitems\Index.cshtml"
WriteAttributeValue("", 3816, Url.Action("Create"), 3816, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary float-right mb-5\">Create New</a>\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lost_and_Found.Models.Lostitem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
