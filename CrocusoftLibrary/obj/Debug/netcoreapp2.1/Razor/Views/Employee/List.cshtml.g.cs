#pragma checksum "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aa5b10257d9f6270a7e6df5cb9d77d6c38a5382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_List), @"mvc.1.0.view", @"/Views/Employee/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/List.cshtml", typeof(AspNetCore.Views_Employee_List))]
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
#line 1 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\_ViewImports.cshtml"
using CrocusoftLibrary;

#line default
#line hidden
#line 2 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\_ViewImports.cshtml"
using CrocusoftLibrary.Models;

#line default
#line hidden
#line 3 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\_ViewImports.cshtml"
using CrocusoftLibrary.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aa5b10257d9f6270a7e6df5cb9d77d6c38a5382", @"/Views/Employee/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3a86b71eeb5fc7ed6a2450b789edd9f2feb61ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary w-100 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
 if (TempData["Created"] != null)
{

#line default
#line hidden
            BeginContext(72, 67, true);
            WriteLiteral("    <p class=\"text-center text-success\">Yeni işçi yaradıldı !</p>\r\n");
            EndContext();
#line 6 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
}

#line default
#line hidden
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
 if (TempData["Updated"] != null)
{

#line default
#line hidden
            BeginContext(182, 77, true);
            WriteLiteral("    <p class=\"text-center text-success\">İşçinin məlumatları yeniləndi !</p>\r\n");
            EndContext();
#line 11 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
}

#line default
#line hidden
            BeginContext(262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
 if (TempData["Deleted"] != null)
{

#line default
#line hidden
            BeginContext(302, 60, true);
            WriteLiteral("    <p class=\"text-center text-success\">İşçi silindi !</p>\r\n");
            EndContext();
#line 16 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
}

#line default
#line hidden
            BeginContext(365, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
 if (TempData["PasswordChanged"] != null)
{

#line default
#line hidden
            BeginContext(413, 69, true);
            WriteLiteral("    <p class=\"text-center text-success\">Şifrəniz dəyişdirildi !</p>\r\n");
            EndContext();
#line 21 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
}

#line default
#line hidden
            BeginContext(485, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 24 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
     if (ViewBag.IsAdminRole == 1)
    {

#line default
#line hidden
            BeginContext(549, 47, true);
            WriteLiteral("        <div class=\"col-12 mb-5\">\r\n            ");
            EndContext();
            BeginContext(596, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7fc5a7d6bbb4228b10df45017959801", async() => {
                BeginContext(686, 15, true);
                WriteLiteral("Yeni işçi yarat");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(705, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 29 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
    }

#line default
#line hidden
            BeginContext(730, 400, true);
            WriteLiteral(@"    <div class=""col-12"">
        <table class=""table table-hover table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Ad</th>
                    <th>Soyad</th>
                    <th>Yaş</th>
                    <th>İstifadəçi adı</th>
                    <th>Əməliyyat</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 42 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                 foreach (CustomUser user in Model)
                {

#line default
#line hidden
            BeginContext(1202, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1257, 14, false);
#line 45 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                       Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1307, 13, false);
#line 46 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                       Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1320, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1356, 8, false);
#line 47 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                       Write(user.Age);

#line default
#line hidden
            EndContext();
            BeginContext(1364, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1400, 13, false);
#line 48 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1413, 75, true);
            WriteLiteral("</td>\r\n                        <td class=\"d-flex justify-content-center\">\r\n");
            EndContext();
#line 50 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                             if (ViewBag.IsAdminRole == 1 || ViewBag.IsAdminRole != 1 && user.UserName == ViewBag.ActiveUser)
                            {

#line default
#line hidden
            BeginContext(1646, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1678, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42e8daae75bd4d499ed65f2f50c9ebd7", async() => {
                BeginContext(1751, 98, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-pen\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                                                                                   WriteLiteral(user.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1853, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                            }

#line default
#line hidden
            BeginContext(1886, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 56 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                             if (ViewBag.IsAdminRole == 1 && user.UserName != ViewBag.ActiveUser)
                            {

#line default
#line hidden
            BeginContext(2016, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2048, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aef480909184c9c912bbf03e3041163", async() => {
                BeginContext(2121, 109, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-trash-alt ml-5\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                                                                                   WriteLiteral(user.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 61 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                            }

#line default
#line hidden
            BeginContext(2267, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 64 "D:\Programming\Other\CrocusoftLibrary\CrocusoftLibrary\Views\Employee\List.cshtml"
                }

#line default
#line hidden
            BeginContext(2344, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
