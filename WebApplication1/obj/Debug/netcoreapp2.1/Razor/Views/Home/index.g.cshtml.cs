#pragma checksum "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8e8d6425c1145d875869f766021b096d664eea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e8d6425c1145d875869f766021b096d664eea4", @"/Views/Home/index.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
  
    ViewData["Title"] = "Viewhola";
    string m1 =@ViewData["Message"].ToString();
    string m2 = @ViewData["Message2"].ToString();

#line default
#line hidden
            BeginContext(148, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(155, 2, false);
#line 9 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
Write(m1);

#line default
#line hidden
            EndContext();
            BeginContext(157, 11, true);
            WriteLiteral("</h1>\r\n<h1>");
            EndContext();
            BeginContext(169, 2, false);
#line 10 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
Write(m2);

#line default
#line hidden
            EndContext();
            BeginContext(171, 11, true);
            WriteLiteral("</h1>\r\n<h2>");
            EndContext();
            BeginContext(183, 14, false);
#line 11 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
Write(ViewBag.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(197, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(209, 16, false);
#line 12 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
Write(ViewBag.apellido);

#line default
#line hidden
            EndContext();
            BeginContext(225, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(237, 8, false);
#line 13 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
Write(Model[0]);

#line default
#line hidden
            EndContext();
            BeginContext(245, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
 foreach( string item in Model)
{

#line default
#line hidden
            BeginContext(290, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(327, 4, false);
#line 19 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
       Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(331, 32, true);
            WriteLiteral("<br>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 22 "C:\Users\peli\source\repos\WebApplication1\WebApplication1\Views\Home\index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591