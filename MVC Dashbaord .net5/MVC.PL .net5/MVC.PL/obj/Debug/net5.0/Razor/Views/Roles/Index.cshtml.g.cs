#pragma checksum "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4dbb50130cdc90fb03b9b10ec560be98326fb2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
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
#line 1 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\_ViewImports.cshtml"
using MVC.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\_ViewImports.cshtml"
using MVC.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\_ViewImports.cshtml"
using MVC.PL.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\_ViewImports.cshtml"
using MVC.DAL.Entites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\_ViewImports.cshtml"
using MVC.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4dbb50130cdc90fb03b9b10ec560be98326fb2d", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae9eb1311efbec04591bf03ceed1267aa2df5b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonViewPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "All Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .serchClass {\r\n        display:flex;\r\n        justify-content:center;\r\n    }\r\n</style>\r\n<h1>All Roles</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4dbb50130cdc90fb03b9b10ec560be98326fb2d5488", async() => {
                WriteLiteral("Create New Role ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 16 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
 if (Model?.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 21 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
               Write(Html.DisplayNameFor(R => R.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 22 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
               Write(Html.DisplayNameFor(R => R.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 34 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4dbb50130cdc90fb03b9b10ec560be98326fb2d8738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 36 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id.ToString();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 38 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 41 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning mt-1\">\r\n        <h3>No Roles Found !!</h3>\r\n    </div>\r\n");
#nullable restore
#line 48 "D:\Courses\Route\Backend\Lectures\07 ASP Core MVC\Session 05\MVC.PL\MVC.PL\Views\Roles\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
