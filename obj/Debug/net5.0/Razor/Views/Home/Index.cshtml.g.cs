#pragma checksum "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8ede35a7cf2bdf42d0c04b057c9b55685933272"
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
#line 1 "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\_ViewImports.cshtml"
using AS1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\_ViewImports.cshtml"
using AS1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8ede35a7cf2bdf42d0c04b057c9b55685933272", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dba000c9b13fa19c698751618ba8a2bc04238925", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AS1.Models.Conversion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2 class=\"text-center\"> Converter</h2>\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8ede35a7cf2bdf42d0c04b057c9b556859332724124", async() => {
                WriteLiteral("\r\n    <div class=\"col-sm\">\r\n        <h3>Decimal</h3>\r\n        <input type=\"text\" class=\"form-control\" aria-label=\"Decimal1\" id=\"Decimal1\" name=\"Decimal1\"");
                BeginWriteAttribute("value", " value=\"", 324, "\"", 347, 1);
#nullable restore
#line 13 "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\Home\Index.cshtml"
WriteAttributeValue("", 332, Model.Decimal1, 332, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"col-sm\">\r\n        <h3>Binary</h3>\r\n        <input type=\"text\" class=\"form-control\" aria-label=\"Binary\" id=\"Binary\" name=\"Binary\"");
                BeginWriteAttribute("value", " value=\"", 507, "\"", 528, 1);
#nullable restore
#line 17 "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\Home\Index.cshtml"
WriteAttributeValue("", 515, Model.Binary, 515, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    </div>\r\n    <br />\r\n    <button style=\"margin-right:15px\" type=\"submit\" class=\"btn btn-info btn-lg\" id=\"ConvertB\" name=\"ConvertSL\" value=\"ConvertB\">Convert</button>\r\n    \r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8ede35a7cf2bdf42d0c04b057c9b556859332726971", async() => {
                WriteLiteral("\r\n    <div class=\"col-sm\">\r\n        <h3>Decimal</h3>\r\n        <input type=\"text\" class=\"form-control\" aria-label=\"Decimal2\" id=\"Decimal2\" name=\"Decimal2\"");
                BeginWriteAttribute("value", " value=\"", 934, "\"", 957, 1);
#nullable restore
#line 33 "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\Home\Index.cshtml"
WriteAttributeValue("", 942, Model.Decimal2, 942, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"col-sm\">\r\n        <h3>Hexa Decimal</h3>\r\n        <input type=\"text\" class=\"form-control\" aria-label=\"HexaDecimal\" id=\"HexaDecimal\" name=\"HexaDecimal\"");
                BeginWriteAttribute("value", " value=\"", 1138, "\"", 1164, 1);
#nullable restore
#line 37 "C:\Users\nelso\Desktop\Software Test&Usability\AS1\AS1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1146, Model.HexaDecimal, 1146, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <br />\r\n    <button type=\"submit\" class=\"btn btn-info btn-lg\" style=\"align-self:center;margin-right:15px\" id=\"ConvertH\" name=\"ConvertSL\" value=\"ConvertH\">Convert</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<div class=""flex-column flex-md-column"">
    <button class=""toogleBold btn btn-lg btn-outline-info"">Bold</button>
    <button class=""toogleIta btn btn-lg btn-dark"" onclick=""myFunction()"">Italicized</button>
</div>
<script>
    
    $("".toogleBold"").click(function () {
        document.getElementById(""Decimal1"").classList.toggle(""bold1"");
    });
    $("".toogleBold"").click(function () {
        document.getElementById(""Binary"").classList.toggle(""bold1"");
    });
    $("".toogleBold"").click(function () {
        document.getElementById(""Decimal2"").classList.toggle(""bold1"");
    });
    $("".toogleBold"").click(function () {
        document.getElementById(""HexaDecimal"").classList.toggle(""bold1"");
    });
    $("".toogleIta"").click(function () {
        document.getElementById(""Decimal1"").classList.toggle(""it1"");
    });
    $("".toogleIta"").click(function () {
        document.getElementById(""Binary"").classList.toggle(""it1"");
    });
    $("".toogleIta"").click(function () {
        ");
            WriteLiteral(@"document.getElementById(""Decimal2"").classList.toggle(""it1"");
    });
    $("".toogleIta"").click(function () {
        document.getElementById(""HexaDecimal"").classList.toggle(""it1"");
    });
    var str = document.getElementById(""HexaDecimal"");
    var strItalic = new String(""Italic"");
    function myFunction() {

        // Toggling between normal and italic
        if (str.innerHTML == ""Normal"") {

            // Using italics() to italicize
            str.innerHTML = strItalic.italics();
        }
        else {
            str.innerHTML = ""Normal"";
        }
    }
</script>
<style>
    .bold1 {
        font-weight: bold;
    }

    .it1 {
        font-style: italic;
    }
</style>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>
<script src=""http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AS1.Models.Conversion> Html { get; private set; }
    }
}
#pragma warning restore 1591
