#pragma checksum "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b5a54c5696243610719a8c9e051fb692736e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Show), @"mvc.1.0.view", @"/Views/Items/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b5a54c5696243610719a8c9e051fb692736e2b", @"/Views/Items/Show.cshtml")]
    public class Views_Items_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>To Do List Item Details: </h1>\r\n\r\n<h2>");
#nullable restore
#line 3 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Show.cshtml"
Write(Model["item"].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Category: ");
#nullable restore
#line 4 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Show.cshtml"
         Write(Model["category"].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\'", 123, "\'", 173, 3);
            WriteAttributeValue("", 130, "/categories/", 130, 12, true);
#nullable restore
#line 6 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Show.cshtml"
WriteAttributeValue("", 142, Model["category"].Id, 142, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 163, "/items/new", 163, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Add another item</a>\r\n<a href=\'/categories\'>View all categories</a>");
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
