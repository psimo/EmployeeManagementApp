#pragma checksum "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4eaebd269a2859d563a5cfe2695c11232a11e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\_ViewImports.cshtml"
using EmployeeManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\_ViewImports.cshtml"
using EmployeeManagementApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4eaebd269a2859d563a5cfe2695c11232a11e6", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdb1d742e97484ec7cf24ca61b6843eb773b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManagementApp.Data.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Employee List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        <button class=\"btn btn-info\">\r\n            ");
#nullable restore
#line 13 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
       Write(Html.ActionLink("Create New Employee", "AddEmployee", "Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </button>
    </div>
</div>
<br />
<table class=""table table-striped border"">
    <thead>
        <tr class=""table-striped"">
            <th>Name</th>
            <th>Gender</th>
            <th>Address</th>
            <th>Project</th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
           Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
           Write(employee.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
           Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
           Write(employee.Project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = employee.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = employee.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManagementApp.Data.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
