#pragma checksum "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075e6c330f7f2cdaa62d83b874276ef2ed9a9452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\_ViewImports.cshtml"
using AlienFlix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\_ViewImports.cshtml"
using AlienFlix.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\_ViewImports.cshtml"
using AlienFlix.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\_ViewImports.cshtml"
using AlienFlix.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075e6c330f7f2cdaa62d83b874276ef2ed9a9452", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1eec70a12e82ae9bccc6c11f40f22d80d2fed6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LockUnLock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Users List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container whiteBackground border mt-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 col-md-6\">\r\n            <h1 class=\"text-info\">Users List</h1>\r\n        </div>\r\n\r\n        <div class=\"col-12 col-md-6 text-md-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075e6c330f7f2cdaa62d83b874276ef2ed9a94526001", async() => {
                WriteLiteral("\r\n                <i class=\"bi bi-plus-lg\"></i>\r\n                New Employee Redester\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"mt-4\">\r\n");
#nullable restore
#line 21 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning mt-3\" role=\"alert\">\r\n                No Users in the list ...!\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped border table-hover\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(e => e.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th class=\"d-none d-md-block\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(e => e.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n\r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"col12\">\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(e => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td class=\"d-none d-md-block\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(e => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n");
#nullable restore
#line 55 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                             if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075e6c330f7f2cdaa62d83b874276ef2ed9a945210589", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-unlock-fill\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075e6c330f7f2cdaa62d83b874276ef2ed9a945213299", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-lock-fill\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 69 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 71 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
