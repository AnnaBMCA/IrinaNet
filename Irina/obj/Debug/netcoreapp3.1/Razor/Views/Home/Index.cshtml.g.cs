#pragma checksum "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b8740ba5cfc7fd58cad0b5cfe5549cb53c9f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Anna\source\repos\Irina\Irina\Views\_ViewImports.cshtml"
using Irina;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anna\source\repos\Irina\Irina\Views\_ViewImports.cshtml"
using Irina.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b8740ba5cfc7fd58cad0b5cfe5549cb53c9f24", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c9e74d59e11328b559e657ee92ee41e5f7fe9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Irina.Models.Home>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
  
  var imagePath = "~/images/Portfolio/Makeup/2.jpg";

  ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16b8740ba5cfc7fd58cad0b5cfe5549cb53c9f243418", async() => {
                WriteLiteral("\r\n  <div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p> ");
#nullable restore
#line 12 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
   Write(ViewBag.Anna);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n    <h2>");
#nullable restore
#line 13 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
   Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16b8740ba5cfc7fd58cad0b5cfe5549cb53c9f244199", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
  WriteLiteral(imagePath);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
     foreach (var item in Model.files)
    {
  

#line default
#line hidden
#nullable disable
                WriteLiteral("      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16b8740ba5cfc7fd58cad0b5cfe5549cb53c9f246476", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
    WriteLiteral(item.Substring(7));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Anna\source\repos\Irina\Irina\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Irina.Models.Home> Html { get; private set; }
    }
}
#pragma warning restore 1591
