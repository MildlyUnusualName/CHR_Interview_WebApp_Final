#pragma checksum "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe923f9470f56d7855f4e3ba1564e87bebe3b3ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Model_ProcessCode), @"mvc.1.0.view", @"/Views/Model/ProcessCode.cshtml")]
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
#line 1 "B:\Programming\CHR_Interview_WebApp_Final\Views\_ViewImports.cshtml"
using CHR_Interview_WebApp_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Programming\CHR_Interview_WebApp_Final\Views\_ViewImports.cshtml"
using CHR_Interview_WebApp_Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe923f9470f56d7855f4e3ba1564e87bebe3b3ab", @"/Views/Model/ProcessCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fa88084157165acc08d9dc6669acf05584787d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Model_ProcessCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CHR_Interview_WebApp_Final.Models.StateCodes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml"
  
    ViewData["Title"] = "ProcessCode";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Results</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>State Codes</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 17 "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml"
         if (Model.Results.Count != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml"
             foreach (var item in Model.Results)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml"
             
        }

        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                That was not a valid entry.\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "B:\Programming\CHR_Interview_WebApp_Final\Views\Model\ProcessCode.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n<p>Select \"Home\" to conduct another search.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CHR_Interview_WebApp_Final.Models.StateCodes> Html { get; private set; }
    }
}
#pragma warning restore 1591
