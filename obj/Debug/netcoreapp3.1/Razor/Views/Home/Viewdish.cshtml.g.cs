#pragma checksum "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6c5a242faec701006c0964d40e705d0718df927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Viewdish), @"mvc.1.0.view", @"/Views/Home/Viewdish.cshtml")]
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
#line 1 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6c5a242faec701006c0964d40e705d0718df927", @"/Views/Home/Viewdish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ef9a5a98889a98b9daca31de6dc842d4293ab3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Viewdish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"title\">\r\n        <h1>");
#nullable restore
#line 4 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml"
       Write(Model.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>");
#nullable restore
#line 5 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml"
      Write(Model.ChefName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div id=\"home\">\r\n        <h3>\r\n            <a href=\"/\">Home</a>\r\n        </h3>\r\n    </div>\r\n    <hr>\r\n    <div class=\"recipe-info\">\r\n        <p>Description: ");
#nullable restore
#line 14 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Calories: ");
#nullable restore
#line 15 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml"
                Write(Model.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Tastiness: ");
#nullable restore
#line 16 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml"
                 Write(Model.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"buttons\">\r\n        <div id=\"btn\" id=\"delete-btn\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 514, 2);
            WriteAttributeValue("", 493, "/delete/", 493, 8, true);
#nullable restore
#line 20 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml"
WriteAttributeValue("", 501, Model.DishId, 501, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n        </div>\r\n        <div id=\"btn\" id=\"edit-btn\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 619, "\"", 645, 2);
            WriteAttributeValue("", 626, "/edit/", 626, 6, true);
#nullable restore
#line 23 "C:\Users\Dragon\Desktop\Folders\Coding_Dojo1\CSharp_Stack\w2d3\CRUDelicious\Views\Home\Viewdish.cshtml"
WriteAttributeValue("", 632, Model.DishId, 632, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">Edit</a>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
