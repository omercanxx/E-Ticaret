#pragma checksum "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47c5c24c322428a6cf41dd84fd8cf1ae8862a34f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditCategory), @"mvc.1.0.view", @"/Views/Admin/EditCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EditCategory.cshtml", typeof(AspNetCore.Views_Admin_EditCategory))]
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
#line 1 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\_ViewImports.cshtml"
using ETicaret.Entities;

#line default
#line hidden
#line 2 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\_ViewImports.cshtml"
using ETicaret.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47c5c24c322428a6cf41dd84fd8cf1ae8862a34f", @"/Views/Admin/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6c415faacc436e55db54e4b07d040b656ece27f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletefromcategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
  
    ViewData["Title"] = "EditCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(117, 93, true);
            WriteLiteral("\r\n<h2>Edit Category</h2>\r\n\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(210, 674, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b978c61183cc4ef388caa07460d47055", async() => {
                BeginContext(279, 44, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 323, "\"", 340, 1);
#line 14 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 331, Model.Id, 331, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(341, 63, true);
                WriteLiteral(" />\r\n            <div class=\"form-group row\">\r\n                ");
                EndContext();
                BeginContext(404, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17d0ff90749d4ed48b955ec30c5f3482", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 16 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(466, 63, true);
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
                EndContext();
                BeginContext(529, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6e8a933634d40f2b37d2eba4b501bdd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 18 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 18 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
                                     WriteLiteral(Model.Name);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(594, 283, true);
                WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""col-md-10 offset-md-2"">
                    <button type=""submit"" class=""btn btn-primary"">Save Category</button>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(884, 42, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n");
            EndContext();
#line 29 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
         if (Model.Products.Count() > 0)
        {


#line default
#line hidden
            BeginContext(981, 452, true);
            WriteLiteral(@"            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <td style=""width:30px;"">Id</td>
                        <td style=""width:100px;"">Image</td>
                        <td>Name</td>
                        <td style=""width:12px;"">Price</td>
                        <td style=""width:150px;""></td>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 43 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
            BeginContext(1515, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1578, 7, false);
#line 46 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1585, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1658, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7c4099e79e641adbd5b50ce9542aa10", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1668, "~/img/", 1668, 6, true);
#line 48 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
AddHtmlAttributeValue("", 1674, item.ImageUrl, 1674, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1703, 69, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(1773, 9, false);
#line 50 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1782, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1822, 10, false);
#line 51 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 111, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\"btn btn-primary btn-sm mr-2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1943, "\"", 1974, 2);
            WriteAttributeValue("", 1950, "/admin/products/", 1950, 16, true);
#line 53 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1966, item.Id, 1966, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1975, 45, true);
            WriteLiteral(">Edit</a>\r\n\r\n                                ");
            EndContext();
            BeginContext(2020, 417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d74e1c4d464b59b500c71f7c114b25", async() => {
                BeginContext(2099, 75, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2174, "\"", 2190, 1);
#line 56 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 2182, item.Id, 2182, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2191, 79, true);
                WriteLiteral(" />\r\n                                    <input type=\"hidden\" name=\"categoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2270, "\"", 2287, 1);
#line 57 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 2278, Model.Id, 2278, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2288, 142, true);
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2437, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 62 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
                    }

#line default
#line hidden
            BeginContext(2528, 52, true);
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n");
            EndContext();
#line 67 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2616, 105, true);
            WriteLiteral("            <div class=\"alert alert-warning\">\r\n                <h4>No Products</h4>\r\n            </div>\r\n");
            EndContext();
#line 73 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Admin\EditCategory.cshtml"
        }

#line default
#line hidden
            BeginContext(2732, 24, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
