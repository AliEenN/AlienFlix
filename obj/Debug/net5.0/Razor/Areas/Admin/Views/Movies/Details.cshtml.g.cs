#pragma checksum "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "290e6cf1a2083e3a2a1fa8bd1a0b333374bb1b32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Movies_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Movies/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"290e6cf1a2083e3a2a1fa8bd1a0b333374bb1b32", @"/Areas/Admin/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1eec70a12e82ae9bccc6c11f40f22d80d2fed6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-between mt-60-px\">\r\n    <div class=\"col-md-3\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 162, "\"", 227, 2);
            WriteAttributeValue("", 168, "data:image/*;base64,", 168, 20, true);
#nullable restore
#line 9 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
WriteAttributeValue("", 188, Convert.ToBase64String(Model.Poster), 188, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 250, "\"", 268, 1);
#nullable restore
#line 9 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
WriteAttributeValue("", 256, Model.Title, 256, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-md-7\">\r\n        <div class=\"d-flex justify-content-between\">\r\n            <h3>");
#nullable restore
#line 13 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <span class=\"mt-2\">\r\n                <i class=\"bi bi-star-fill text-warning\"></i>\r\n                <span class=\"text-muted\">");
#nullable restore
#line 16 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
                                    Write(Model.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </span>\r\n        </div>\r\n        <span class=\"text-muted mr-3\">\r\n            <i class=\"bi bi-calendar-week\"></i>\r\n            ");
#nullable restore
#line 21 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <span class=\"text-muted\">\r\n            <i class=\"bi bi-film\"></i>\r\n");
#nullable restore
#line 25 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
             foreach (var item in Model.Genres)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 27 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>&nbsp;</span></span>\r\n");
#nullable restore
#line 28 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </span>\r\n        <p class=\"text-justify mt-3\">");
#nullable restore
#line 30 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
                                Write(Model.Storyline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"mt-5\">\r\n");
#nullable restore
#line 32 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
             if (User.IsInRole(Roles.Admin) || User.IsInRole(Roles.Manager) || User.IsInRole(Roles.DataEntry))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290e6cf1a2083e3a2a1fa8bd1a0b333374bb1b328785", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
                                                                 WriteLiteral(Model.Id);

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
#line 35 "C:\Users\ali\source\repos\AlienFlix\AlienFlix\Areas\Admin\Views\Movies\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290e6cf1a2083e3a2a1fa8bd1a0b333374bb1b3211273", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591