#pragma checksum "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709e6127c93e84fa4686b75b909e81b61eb57630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Details), @"mvc.1.0.view", @"/Views/Member/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709e6127c93e84fa4686b75b909e81b61eb57630", @"/Views/Member/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23773305ecfeb9f01767514745f5f917dcfd3611", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library_MS.Models.Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card shadow\">\r\n    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 185, "\"", 207, 1);
#nullable restore
#line 11 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
WriteAttributeValue("", 191, Model.ImagePath, 191, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%; height:auto;\" />\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <table class=\"table table-sm table-striped\">\r\n                    <tr>\r\n                        <th>Name</th>\r\n                        <td>");
#nullable restore
#line 17 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                       Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Status</th>\r\n                        <td>");
#nullable restore
#line 21 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                       Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Member Code</th>\r\n                        <td>");
#nullable restore
#line 25 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                       Write(Model.MemberCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Gender</th>\r\n                        <td>");
#nullable restore
#line 29 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                       Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n                    <tr>\r\n                        <th>phone</th>\r\n                        <td>");
#nullable restore
#line 34 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Email</th>\r\n                        <td>");
#nullable restore
#line 38 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>memberShip Date</th>\r\n                        <td>");
#nullable restore
#line 42 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                       Write(Model.MembershipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n\r\n                </table>\r\n                \r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <h5>Address Details</h5>\r\n");
#nullable restore
#line 53 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                 foreach (var address in Model.Addresses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>");
#nullable restore
#line 55 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                      Write(address.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 55 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                        Write(address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 55 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                                       Write(address.AdditionalInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 56 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n");
#nullable restore
#line 61 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                          
                            decimal FineAmount = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                         foreach (var item in Model.Issues)
                        {
                            foreach (var fine in item.Fines)
                            {

                                FineAmount += fine.FineAmount;
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                         if (FineAmount > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"text-danger\">Fine Amount: ");
#nullable restore
#line 74 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                                               Write(FineAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 75 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"text-danger\">Fine Amount: 00.00</label>\r\n");
#nullable restore
#line 79 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""col-md-6"">
                        <button class=""btn btn-warning px-3"" id=""payFineModelBtn"" data-toggle=""modal"" data-target=""#finePaymentModel"">Pay Fine</button>
                    </div>
                </div>
            </div>

        </div>
        <hr class=""bg-warning"" />

        <div class=""mt-3"">
            <nav>
                <div class=""nav nav-tabs col-md-12"" id=""nav-tab"" role=""tablist"">
                    <a class=""nav-item nav-link active col-md-4"" id=""nav-home-tab"" data-toggle=""tab"" href=""#holding"" role=""tab"" aria-controls=""holding"" aria-selected=""true"">Holding</a>
                    <a class=""nav-item nav-link col-md-4"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#checkout"" role=""tab"" aria-controls=""checkout"" aria-selected=""false"">Checkout History</a>
                    <a class=""nav-item nav-link col-md-4"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#fine"" role=""tab"" aria-controls=""fine"" aria-selected=""fals");
            WriteLiteral(@"e"">Fine Payment History</a>
                </div>
            </nav>
            <div class=""tab-content"" id=""nav-tabContent"">
                <div class=""tab-pane fade show active"" id=""holding"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                   <div>
                       <table class=""table table-striped"" id=""holdingBookDetails"">
                           <thead>
                               <tr>
                                   <th>Image</th>
                                   <th>ISBN</th>
                                   <th>Book</th>
                                   <th>Category</th>
                                   <th>Format</th>
                                   <th>Language</th>

                               </tr>
                           </thead>
                           <tbody>
");
#nullable restore
#line 115 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                foreach (var item in Model.Issues.Where(p => p.ReturnStaus == false))
                               {
                                   string imgePath = "\\" + item.Book.ImagePath;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <tr>\r\n                                      \r\n                                       <td>\r\n                                           <img");
            BeginWriteAttribute("src", " src=\"", 4937, "\"", 4952, 1);
#nullable restore
#line 121 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
WriteAttributeValue("", 4943, imgePath, 4943, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:auto\" />\r\n                                       </td>\r\n                                       <td>\r\n                                           ");
#nullable restore
#line 124 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                      Write(item.Book.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                       </td>\r\n                                       <td>\r\n                                           ");
#nullable restore
#line 127 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                      Write(item.Book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                       </td>\r\n                                       <td>\r\n                                           ");
#nullable restore
#line 130 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                      Write(item.Book.BookCategory.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                       </td>\r\n\r\n                                       <td>\r\n                                           ");
#nullable restore
#line 134 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                      Write(item.Book.Format);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                       </td>\r\n                                       <td>\r\n                                           ");
#nullable restore
#line 137 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                      Write(item.Book.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                       </td>\r\n                                       \r\n                                   </tr>\r\n");
#nullable restore
#line 141 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           </tbody>
                       </table>
                   </div>
                </div>
                <div class=""tab-pane fade"" id=""checkout"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">
                    <div>
                        <table class=""table table-striped"" id=""checkoutHistoryDetails"">
                            <thead>
                                <tr>
                                    <th>Image</th>
                                    <th>ISBN</th>
                                    <th>Book</th>
                                    <th>Category</th>
                                    <th>Format</th>
                                    <th>Language</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 161 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                 foreach (var item in Model.Issues.Where(p => p.ReturnStaus == true))
                                {
                                    string imgePath = "\\" + item.Book.ImagePath;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 7152, "\"", 7167, 1);
#nullable restore
#line 167 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
WriteAttributeValue("", 7158, imgePath, 7158, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:auto\" />\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 170 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                       Write(item.Book.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 173 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                       Write(item.Book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 176 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                       Write(item.Book.BookCategory.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 180 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                       Write(item.Book.Format);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 183 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                       Write(item.Book.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 187 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""fine"" role=""tabpanel"" aria-labelledby=""nav-contact-tab"">
                    <div>
                        <table class=""table-striped"">
                            <thead>
                                <tr>
                                    <td>Date</td>
                                    <td>Paid Amount</td>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 202 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                 foreach (var fine in Model.FineDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 205 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                       Write(fine.PayedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 206 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                       Write(fine.PaidAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 208 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral(@"

<!-- Modal -->
<div class=""modal fade"" id=""finePaymentModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""finePaymentModelModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""finePaymentModelModalLabel"">Fine Payment</h5>
                <button type=""button"" class=""close text-danger"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
#nullable restore
#line 232 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
             using (Html.BeginForm("FinePayment", "Returns"))
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"modal-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"form-group col-md-12\">\r\n                        <label>MemberID</label>\r\n                        <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 10221, "\"", 10244, 1);
#nullable restore
#line 240 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
WriteAttributeValue("", 10229, Model.MemberID, 10229, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""MemberID"" id=""MemberID"" />
                        <label class=""text-danger"" id=""memebrErrMgs"" style=""display:none;"">Plese Select Valid Member.</label>
                    </div>
                    <div class=""form-group col-md-12"">
                        <label>Date</label>
                        <input class=""form-control"" name=""date"" id=""date"" type=""date"" />
                        <label class=""text-danger"" id=""dateErrMgs"" style=""display:none;"">Plese provide Valid amount.</label>
                    </div>
                    <div class=""form-group col-md-12"">
                        <label>Amount</label>
                        <input class=""form-control"" name=""amount"" id=""amount"" type=""number"" />
                        <label class=""text-danger"" id=""amountErrMgs"" style=""display:none;"">Plese provide Valid amount.</label>
                        <label class=""text-danger"" id=""fineErr"" style=""display:none;"">Paid amount is greater than fine.</label>
                    </div>
     ");
            WriteLiteral("           </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                \r\n                <button type=\"button\" id=\"payFineBtn\" class=\"btn btn-primary\">Add</button>\r\n            </div>\r\n");
#nullable restore
#line 260 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n\r\n\r\n<script>\r\n\r\n    $(document).ready(function () {\r\n\r\n        $(\"#amount\").keyup(function () {\r\n            var fineAmount = parseFloat(");
#nullable restore
#line 275 "E:\Binod\ASP.NET\Library_MS\Library_MS\Views\Member\Details.cshtml"
                                   Write(FineAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@");
            var paidAmount = parseFloat($(""#amount"").val());
            //console.log(fineAmount, paidAmount);
            if (paidAmount > fineAmount) {
                $(""#fineErr"").show();
                $(""#payFineBtn"").prop('disabled', true);
            }
            else {
                $(""#fineErr"").hide('');
                $(""#payFineBtn"").prop('disabled', false);
            }

        });


        $(""#payFineBtn"").click(function () {
            var memberID = $(""#MemberID"").val();
            var paidDate = $(""#date"").val();
            var paidAmount = $(""#amount"").val();

            if (memberID != '' && paidDate != '' && paidAmount != '') {
                $(""#memebrErrMgs"").hide(''); $(""#dateErrMgs"").hide(''); $(""#amountErrMgs"").hide('');

                $(""#payFineBtn"").prop('type', 'submit');

");
                WriteLiteral(@"
            }
            else {
                $(""#payFineBtn"").prop('type', 'button');
                if (memberID == '') {
                    $(""#memebrErrMgs"").show();
                }
                if (paidDate == '') {
                    $(""#dateErrMgs"").show()
                }
                if (paidAmount == '') {
                    $(""#amountErrMgs"").show();
                }
            }

        });






    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library_MS.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
