#pragma checksum "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Issue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e08c066fbb2178aaf0994f460ad13e6ff2cc75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Issue_Index), @"mvc.1.0.view", @"/Views/Issue/Index.cshtml")]
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
#line 1 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\_ViewImports.cshtml"
using Library_MS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\_ViewImports.cshtml"
using Library_MS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e08c066fbb2178aaf0994f460ad13e6ff2cc75", @"/Views/Issue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23773305ecfeb9f01767514745f5f917dcfd3611", @"/Views/_ViewImports.cshtml")]
    public class Views_Issue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Issue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Issue\Index.cshtml"
  
    ViewData["Title"] = "Issue Book";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #memberImg{
        width:50%;
        height:auto;
        top:-25%;
        border-radius:50%;
    }
</style>

<div class=""row"">
    <div class=""col-md-8"">
        <div class=""card shadow"">
            <div class=""card-header"">
                <h5>Issue Form</h5>
            </div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e08c066fbb2178aaf0994f460ad13e6ff2cc754667", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <label>Book ISBN</label>
                            <input class=""form-control"" name=""bookISBN"" id=""isbn"" />
                            <label id=""bookErrorMgs"" class=""text-danger"" style=""display:none;"">Please Provide Valid Book ISBN.</label>
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>Member Code</label>
                            <input class=""form-control"" name=""memberCode"" id=""memberCode"" />
                            <label id=""memberErrorMgs"" class=""text-danger"" style=""display:none;"">Please Provide Valid Member Code.</label>
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label>Issue Date</label>
                            <input class=""form-control"" name=""issueDate"" type=""date"" />
                        </div>
  ");
                WriteLiteral(@"                      <div class=""col-md-6 form-group"">
                            <label>Due Date</label>
                            <input class=""form-control"" name=""dueDate"" type=""date"" />
                        </div>
                    </div>
                    <hr class=""bg-warning""/>
                    <div class=""form-group text-center"">
                        <button type=""reset"" class=""btn btn-secondary mr-2 px-3"" id=""allClear"">Clear</button>
                        <button type=""submit"" class=""btn btn-info px-3"">Issue</button>
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
            WriteLiteral(@"
               
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""card shadow"">
            <div class=""card-header"">
                <h5>Member Details</h5>
            </div>
            <div class=""card-body"">
                <div class=""text-center"">
                    <img id=""memberImg"" class=""border-info""");
            BeginWriteAttribute("src", " src=\"", 2521, "\"", 2527, 0);
            EndWriteAttribute();
            WriteLiteral(@" alt=""memberImage""/>
                </div>
                <hr class=""bg-info""/>
                <table class=""table table-sm table-striped"">
                    <tr>
                        <th>Name:</th>
                        <td >
                            <label id=""memberName"" class=""text-right""></label>
                        </td>
                    </tr>
                    <tr>
                        <th>Joining Date: </th>
                        <td >
                            <label id=""Mdate"" class=""text-right""></label>
                        </td>
                    </tr>
                    <tr>
                        <th>Book Issued: </th>
                        <td >
                            <label id=""Issudestatus"" class=""text-right""></label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
<hr class=""bg-info""/>
<div class=""card"">
    <div class=""card-header"">
  ");
            WriteLiteral(@"      <h5>Book Details</h5>
    </div>
    <div class=""table-responsive"">
        <table class=""table table-striped"" id=""BookDetailsTables"">
            <thead>
                <tr>
                    <td>Image</td>
                    <td>Titile</td>
                    <td>Category</td>
                    <td>Language</td>
                    <td>Format</td>
                    <td>Authors</td>
                    <td>Status</td>
                </tr>
            </thead>
            <tbody>

            </tbody>
        </table>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 


<script>


    $(document).ready(function () {

        
        $(""#isbn"").keypress(function (event) {

            var keycode = (event.keyCode ? event.keyCode : event.which);
            //console.log(keycode);
            if (keycode == '13') {
                event.preventDefault();
                var bookIsbn = $(""#isbn"").val();
                if (bookIsbn != '') {
                   // alert();
                    $.ajax({
                        contentType: 'application/json',
                        dataType: 'json',
                        type: 'get',
                        url: '/Issue/getBook',
                        data: { ISBN: bookIsbn},
                        success: function (response) {
                           // 
                            $.each(response, function (key, value) {
                                console.log(value[0].BookTitle);
                                tableData = ""<tr>"";
                                tableData += ""<td>""");
                WriteLiteral(@" + ""<img src= \\"" + value[0].BookImge + "" style='width:100px; height:auto;'>"" + ""</td>"";
                                tableData += ""<td>"" + value[0].BookTitle +""</td>"";
                                tableData += ""<td>"" + value[0].Category +""</td>"";
                                tableData += ""<td>"" + value[0].Language +""</td>"";
                                tableData += ""<td>"" + value[0].Format +""</td>"";
                                tableData += ""<td>"" + value[0].Authors + ""</td>"";
                                if (value[0].Status != ""Active"") {
                                    tableData += ""<td class='text-danger'>"" + value[0].Status + ""</td>"";
                                }
                                else {
                                    tableData += ""<td>"" + value[0].Status + ""</td>"";
                                }
                               
                                tableData += ""</tr>"";

                            });
                           ");
                WriteLiteral(@" $(""#BookDetailsTables tbody"").append(tableData); 
                       
                        },
                        error: function () {
                            console.log('error occured.');
                        }
                    });
                }
                
            }
        });

        $(""#memberCode"").keypress(function (event) {
            var keycode = (event.keyCode ? event.keyCode : event.which);
            if (keycode == ""13"") {
                event.preventDefault();
                var Code = $(""#memberCode"").val();
                console.log(Code);
                if (Code != '') {
                    $.ajax({
                        contentType: 'application/json',
                        type: 'get',
                        dataType: 'json',
                        url: '/Issue/getMember',
                        data: { uniqueCode: Code },                        
                        success: function (response) {
              ");
                WriteLiteral(@"              $.each(response, function (key, value) {
                                $(""#memberImg"").prop('src', value[0].MemberImage);
                                $(""#memberName"").html(value[0].MemberName);
                                $(""#Mdate"").html(value[0].MembershipDate);
                                $(""#Issudestatus"").html(value[0].bookCount);
                            });
                            console.log(response);
                        },
                        error: function (error) {
                            console.log(error);
                        }
                    });
                }
            }
        });

        $(""#allClear"").click(function () {

            $(""#memberImg"").prop('src', '');
            $(""#memberName"").html('');
            $(""#Mdate"").html('');
            $(""#Issudestatus"").html('');
            $(""#BookDetailsTables tbody"").html('');
        });
    })
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
