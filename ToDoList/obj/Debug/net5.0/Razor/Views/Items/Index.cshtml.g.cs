#pragma checksum "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a522110913f59127d5f5af5abbb9f43c7815ad0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a522110913f59127d5f5af5abbb9f43c7815ad0a", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>To Do List</h1>\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no items in the list.</p>\r\n");
#nullable restore
#line 7 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
   foreach (Item item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><a");
            BeginWriteAttribute("href", " href=\'", 174, "\'", 196, 2);
            WriteAttributeValue("", 181, "/items/", 181, 7, true);
#nullable restore
#line 11 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
WriteAttributeValue("", 188, item.Id, 188, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 12 "C:\Users\HP\Desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<a href=\"/items/new\">Add a new item.</a>\r\n\r\n<form action=\"/items/delete\" method=\"post\">\r\n  <button type=\"submit\" name=\"button\">Clear All Items</button>\r\n</form>");
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
