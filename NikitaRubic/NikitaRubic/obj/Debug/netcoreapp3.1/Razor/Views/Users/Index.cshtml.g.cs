#pragma checksum "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e209f17b922d9855b2a39618354908f2dd11bb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e209f17b922d9855b2a39618354908f2dd11bb6", @"/Views/Users/Index.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NikitaRubic.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Birthsday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Birthsday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1358, "\"", 1381, 1);
#nullable restore
#line 52 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
WriteAttributeValue("", 1373, item.id, 1373, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1434, "\"", 1457, 1);
#nullable restore
#line 53 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
WriteAttributeValue("", 1449, item.id, 1449, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1512, "\"", 1535, 1);
#nullable restore
#line 54 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
WriteAttributeValue("", 1527, item.id, 1527, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Никита\Documents\GitHub\NikitaRubic\NikitaRubic\NikitaRubic\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NikitaRubic.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
