#pragma checksum "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19cdb733710f7ee689a5a72d2964dde2d6fcf7ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#line 1 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\_ViewImports.cshtml"
using Library_MS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\_ViewImports.cshtml"
using Library_MS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cdb733710f7ee689a5a72d2964dde2d6fcf7ba", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23773305ecfeb9f01767514745f5f917dcfd3611", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library_MS.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
  
    var imagePath = "\\" + Model.ImagePath;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n");
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 455, "\"", 484, 1);
#nullable restore
#line 17 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
WriteAttributeValue("", 461, Url.Content(imagePath), 461, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%; height:100%;"" />
            </div>
            <div class=""col-md-9"">
                <div class=""card-header"">
                    <h5>Book Details</h5>
                </div>
                <table class=""table table-sm table-striped"">
                    <tr>
                        <th>Book Name</th>
                        <td colspan=""3"">");
#nullable restore
#line 26 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                                   Write(Model.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       \r\n                    </tr>\r\n                    <tr>\r\n                        <th>ISBN</th>\r\n                        <td colspan=\"3\">");
#nullable restore
#line 31 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                                   Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Category</th>\r\n                        <td>");
#nullable restore
#line 35 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.BookCategory.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <th>Format</th>\r\n                        <td>");
#nullable restore
#line 37 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.Format);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n\r\n                    <tr>\r\n                        <th>Total Page</th>\r\n                        <td>");
#nullable restore
#line 42 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.numberOfPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <th>Language</th>\r\n                        <td>");
#nullable restore
#line 44 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Purchase Date</th>\r\n                        <td>");
#nullable restore
#line 48 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.PurchaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <th>Publish Date</th>\r\n                        <td>");
#nullable restore
#line 50 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Price</th>\r\n                        <td>");
#nullable restore
#line 54 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <th>Status</th>\r\n                        <td>");
#nullable restore
#line 56 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                       Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>

                </table>
            </div>

            <div class=""col-md-12"">
                <div class=""card-header"">
                    <h5>Author Details</h5>
                </div>
                <table class=""table tabe-sm table-striped"">
                    <tbody>
                        <tr>
");
#nullable restore
#line 69 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                             foreach (var author in Model.BookAuthors)
                            {

                                if (Model.BookID == author.BookId)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                               Write(author.Author.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Books\Details.cshtml"
                                                       ; 
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                        \r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library_MS.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
