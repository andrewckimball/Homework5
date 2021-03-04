#pragma checksum "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c9cbf9f706f95c785f7b0e9c1c67fd3c3c93f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProjectSummary), @"mvc.1.0.view", @"/Views/Shared/ProjectSummary.cshtml")]
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
#line 1 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\_ViewImports.cshtml"
using AndrewHomework5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\_ViewImports.cshtml"
using AndrewHomework5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\_ViewImports.cshtml"
using AndrewHomework5.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c9cbf9f706f95c785f7b0e9c1c67fd3c3c93f7", @"/Views/Shared/ProjectSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5546144d6fb2206908cf9b6250e2cde91758f661", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProjectSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>\r\n            ");
#nullable restore
#line 7 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"badge badge-pill badge-success\" style=\"float:right\">\r\n                <small>");
#nullable restore
#line 9 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                  Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </span>\r\n        </h4>\r\n    </div>\r\n\r\n    <!--Bootstrap command addition: Formatting the data-->\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">Author</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 17 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                        Write(Model.AuthorFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                                           Write(Model.AuthorLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-3 text-truncate\">Publisher</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 19 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                        Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-3\">ISBN</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 21 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                        Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-3\">Classification</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 23 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                        Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-3\">Category</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 25 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                        Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-3\">Pages</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 27 "C:\Users\andrewkimball\source\repos\AndrewHomework5\AndrewHomework5\Views\Shared\ProjectSummary.cshtml"
                        Write(Model.NumberOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project> Html { get; private set; }
    }
}
#pragma warning restore 1591