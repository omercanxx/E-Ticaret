#pragma checksum "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf732c41f86b552c1a7ff08f583d8f5c3570673"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Details.cshtml", typeof(AspNetCore.Views_Shop_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf732c41f86b552c1a7ff08f583d8f5c3570673", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe33a38cf8335e6dac56fd122de4dee63afeb736", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(118, 57, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            EndContext();
            BeginContext(175, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b95f871e0d4a435eb600de247b501b72", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 185, "~/img/", 185, 6, true);
#line 9 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 191, Model.Product.ImageUrl, 191, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 221, Model.Product.Name, 221, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(262, 81, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"mb-3\">\r\n            ");
            EndContext();
            BeginContext(344, 18, false);
#line 13 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
       Write(Model.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(362, 33, true);
            WriteLiteral("\r\n        </h1>\r\n        <hr />\r\n");
            EndContext();
#line 16 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
         foreach(var category in Model.Categories)
        {

#line default
#line hidden
            BeginContext(458, 54, true);
            WriteLiteral("            <a href=\"#\" class=\"btn btn-link p-0 mb-3\">");
            EndContext();
            BeginContext(513, 13, false);
#line 18 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
                                                 Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(526, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 19 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(543, 88, true);
            WriteLiteral("        <div class=\"mb-3\">\r\n            <h4 class=\"text-primary mb-3\">\r\n                ");
            EndContext();
            BeginContext(632, 19, false);
#line 22 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
           Write(Model.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(651, 234, true);
            WriteLiteral(" TL\r\n            </h4>\r\n            <button type=\"submit\" class=\"btn btn-primary btn-lg\">Add To Cart</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <p class=\"p-3\">\r\n            ");
            EndContext();
            BeginContext(886, 25, false);
#line 32 "C:\Users\omer6\OneDrive\Belgeler\GitHub\E-Ticaret\ETicaret.WebUI\Views\Shop\Details.cshtml"
       Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(911, 36, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
