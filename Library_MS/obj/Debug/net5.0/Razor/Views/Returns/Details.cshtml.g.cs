#pragma checksum "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf558fb46603682d64c24ae32884056064d5c1bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Returns_Details), @"mvc.1.0.view", @"/Views/Returns/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf558fb46603682d64c24ae32884056064d5c1bf", @"/Views/Returns/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23773305ecfeb9f01767514745f5f917dcfd3611", @"/Views/_ViewImports.cshtml")]
    public class Views_Returns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library_MS.Models.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Returns", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card shadow p-2\">\r\n    <div class=\"card-header\">\r\n\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-md-8\">\r\n                <input");
            BeginWriteAttribute("value", " value=\"", 238, "\"", 261, 1);
#nullable restore
#line 15 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
WriteAttributeValue("", 246, Model.MemberID, 246, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  readonly hidden/>
                <table class=""table table-sm table-striped"">
                    <tr>
                        <th>Name</th>
                        <td>
                            <label id=""memberFullName"">
                                ");
#nullable restore
#line 21 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <th>Member Code</th>
                        <td >
                            <label id=""memberIdValue"">
                                ");
#nullable restore
#line 29 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(Model.MemberCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>                           \r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>joning Date</th>\r\n                        <td>");
#nullable restore
#line 35 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                       Write(Model.MembershipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Status</th>\r\n                        <td>");
#nullable restore
#line 39 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                       Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n            <div class=\"col-md-1\"></div>\r\n            <div class=\"col-md-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1416, "\"", 1438, 1);
#nullable restore
#line 45 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
WriteAttributeValue("", 1422, Model.ImagePath, 1422, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""MeberImage"" style=""width:60%; height:auto;"" />
            </div>
        </div>
        <hr class=""bg-info"" />
        <div class=""table-responsive"">
            <table class=""table table-striped"" id=""issuedBookIndex"">
                <thead>
                    <tr>
                        <th hidden>ID</th>
                        <th>Image</th>
                        <th>Book Title</th>
                        <th>ISBN</th>
                        <th>Category</th>
                        <th>Issued Date</th>
                        <th>Due Date</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 64 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                     foreach (var issue in Model.Issues)
                    {
                        string imgePath = "\\" + @issue.Book.ImagePath;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                            <td hidden>\r\n                                ");
#nullable restore
#line 69 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(issue.Book.BookID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2523, "\"", 2538, 1);
#nullable restore
#line 72 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
WriteAttributeValue("", 2529, imgePath, 2529, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:auto\" />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 75 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(issue.Book.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 78 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(issue.Book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 81 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(issue.Book.BookCategory.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 85 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(issue.issueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                           Write(issue.dueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                            <td>
                                <button class=""btn btn-sm btn-success bookReturnBtn"" data-toggle=""modal"" data-target=""#returnModel"">
                                    Return
                                </button>
");
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 97 "E:\Binod\ASP.NET\Library\Library_MS\Library_MS\Views\Returns\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"

<!-- Modal -->
<div class=""modal fade"" id=""returnModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""returnModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""returnModalLabel"">Book Return</h5>
                <button type=""button"" class=""close text-danger"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf558fb46603682d64c24ae32884056064d5c1bf12265", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label>Member <span class=""text-danger"">*</span></label>
                            <input class=""form-control"" id=""memberName"" readonly/>
                            <input class=""form-control"" name=""memberCode"" id=""memberCode"" readonly style=""display:none;""/>
                        </div>
                        <div class=""col-md-12 form-group"">
                            <label>Book <span class=""text-danger"">*</span></label>
                            <input class=""form-control"" id=""bookName"" readonly />
                            <input class=""form-control"" name=""bookId"" id=""bookId"" readonly style=""display:none;"" />
                        </div>
                        <div class=""col-md-12 form-group"">
                            <label>Return Date <span class=""text-danger"">*</span></label>
                            ");
                WriteLiteral(@"<input type=""date"" class=""form-control"" name=""returnDate"" id=""returnDate"" />
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" id=""returnBookBtn"" class=""btn btn-primary"">Save</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>

        $(document).ready(function () {



            $(""#issuedBookIndex tbody tr .bookReturnBtn"").click(function () {

                var bookid = $(this).closest('tr').find('td:eq(0)').html();
                var bookName = $(this).closest('tr').find('td:eq(2)').html();
                var member = $('#memberIdValue').html().trim();
                var memberFullName = $('#memberFullName').html().trim();
               
                $(""#bookId"").val(bookid.trim());
                $(""#memberCode"").val(member);

                $(""#bookName"").val(bookName.trim());
                $(""#memberName"").val(memberFullName.trim());
            });


            $(""#returnBookBtn"").click(function () {
                var member = $(""#memberId"").val();
                var bookid = $(""#bookId"").val();
                var returnDate = $(""#returnDate"").val();
                
                $(""#returnBookBtn"").prop(""type"", ""button"");
               
                if ");
                WriteLiteral(@"(member == """" || bookid == """" || returnDate == """"){
                    $(""#returnBookBtn"").prop(""type"", ""button"");
                    if (member == """" || member == ""undefined"")
                    {
                        $(""#memberName"").css({ ""border-color"": ""red"" });
                    }
                    if (bookid == """" || bookid == ""undefined"") {
                        $(""#bookName"").css({ ""border-color"": ""red"" });
                    }
                    if (returnDate == """" || returnDate == ""undefined"") {
                        console.log(""hi"");
                        $(""#returnDate"").css({ ""border-color"": ""red"" });
                    }
                }
                else {
                    $(""#returnBookBtn"").prop(""type"", ""submit"");
                }
            });

            $(""#returnDate"").change(function () {
                if ($(""#returnDate"").val() == """") {
                    $(""#returnDate"").css({ ""border-color"": ""red"" });
                }
       ");
                WriteLiteral("         else {\r\n                    $(\"#returnDate\").css({ \"border-color\": \"#BF40BF\" });\r\n                }\r\n            });\r\n\r\n        });\r\n\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library_MS.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
