#pragma checksum "C:\Users\Rizvi\Documents\GitHub\dotnetcoreapptutorial\dotnetcoreapptutorial\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f0815b689ad884b6386a0968dc1546bffce08b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f0815b689ad884b6386a0968dc1546bffce08b", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dotnetcoreapptutorial.ViewModels.HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rizvi\Documents\GitHub\dotnetcoreapptutorial\dotnetcoreapptutorial\Views\Home\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Employee Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 8 "C:\Users\Rizvi\Documents\GitHub\dotnetcoreapptutorial\dotnetcoreapptutorial\Views\Home\Details.cshtml"
Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div>\r\n    Name: ");
#nullable restore
#line 11 "C:\Users\Rizvi\Documents\GitHub\dotnetcoreapptutorial\dotnetcoreapptutorial\Views\Home\Details.cshtml"
     Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Email: ");
#nullable restore
#line 14 "C:\Users\Rizvi\Documents\GitHub\dotnetcoreapptutorial\dotnetcoreapptutorial\Views\Home\Details.cshtml"
      Write(Model.Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Department: ");
#nullable restore
#line 17 "C:\Users\Rizvi\Documents\GitHub\dotnetcoreapptutorial\dotnetcoreapptutorial\Views\Home\Details.cshtml"
           Write(Model.Employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnetcoreapptutorial.ViewModels.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
