#pragma checksum "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4407740f31268e7e00b5cd05611ed0229181c9e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeForm), @"mvc.1.0.view", @"/Views/Employee/EmployeeForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4407740f31268e7e00b5cd05611ed0229181c9e2", @"/Views/Employee/EmployeeForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdb1d742e97484ec7cf24ca61b6843eb773b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeManagementApp.ViewModels.EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
  
    ViewBag.Title = "Employee Form";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Employee Details</h2>\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
 using (@Html.BeginForm("Save", "Employee"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.LabelFor(m => m.Employee.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.TextBoxFor(m => m.Employee.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.LabelFor(m => m.Employee.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.DropDownListFor(m => m.Employee.Gender, Model.GenderList, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 25 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.LabelFor(m => m.Employee.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.TextBoxFor(m => m.Employee.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4407740f31268e7e00b5cd05611ed0229181c9e26572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 30 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#nullable restore
#line 31 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.LabelFor(m => m.Employee.ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
   Write(Html.DropDownListFor(m => m.Employee.ProjectId, new SelectList(Model.Project, "Id", "Name"), "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4407740f31268e7e00b5cd05611ed0229181c9e28907", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 33 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Employee.ProjectId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
Write(Html.HiddenFor(m => m.Employee.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
                                       

    var c = @Model.Employee.Id > 0 ? "Update" : "Save";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<button type=\"submit\" class=\"btn btn-info\">");
#nullable restore
#line 40 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
                                          Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 41 "C:\Users\abssacg\Documents\Tech Ed\Apps\EmployeeManagementApp\EmployeeManagementApp\Views\Employee\EmployeeForm.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManagementApp.ViewModels.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
