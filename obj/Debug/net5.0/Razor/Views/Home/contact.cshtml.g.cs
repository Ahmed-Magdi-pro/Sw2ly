#pragma checksum "C:\Users\hadee\OneDrive\المستندات\Visual Studio 2019\Projects\Fast_Market\Fast_Market\Views\Home\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70b99877f20a017e188d2515386fe5b1d24d21d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contact), @"mvc.1.0.view", @"/Views/Home/contact.cshtml")]
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
#line 1 "C:\Users\hadee\OneDrive\المستندات\Visual Studio 2019\Projects\Fast_Market\Fast_Market\Views\_ViewImports.cshtml"
using Fast_Market;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hadee\OneDrive\المستندات\Visual Studio 2019\Projects\Fast_Market\Fast_Market\Views\_ViewImports.cshtml"
using Fast_Market.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b99877f20a017e188d2515386fe5b1d24d21d8", @"/Views/Home/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a448cbf8cf6f49b6ef26616c05868564d82cec2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\hadee\OneDrive\المستندات\Visual Studio 2019\Projects\Fast_Market\Fast_Market\Views\Home\contact.cshtml"
  
    ViewData["Title"] = "contact";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("section1", async() => {
                WriteLiteral(@"
    <!-- Start All Title Box -->
    <div class=""all-title-box"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <h2>Contact Us</h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Contact US</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- End All Title Box -->
");
            }
            );
            WriteLiteral(@"

<!-- Start Contact Us  -->
<div class=""contact-box-main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-sm-12"">
                <div class=""contact-form-right"">
                    <h2>GET IN TOUCH</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed odio justo, ultrices ac nisl sed, lobortis porta elit. Fusce in metus ac ex venenatis ultricies at cursus mauris.</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b99877f20a017e188d2515386fe5b1d24d21d85139", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" id=""name"" name=""name"" placeholder=""Your Name"" required data-error=""Please enter your name"">
                                    <div class=""help-block with-errors""></div>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <input type=""text"" placeholder=""Your Email"" id=""email"" class=""form-control"" name=""name"" required data-error=""Please enter your email"">
                                    <div class=""help-block with-errors""></div>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-gr");
                WriteLiteral(@"oup"">
                                    <input type=""text"" class=""form-control"" id=""subject"" name=""name"" placeholder=""Subject"" required data-error=""Please enter your Subject"">
                                    <div class=""help-block with-errors""></div>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <textarea class=""form-control"" id=""message"" placeholder=""Your Message"" rows=""4"" data-error=""Write your message"" required></textarea>
                                    <div class=""help-block with-errors""></div>
                                </div>
                                <div class=""submit-button text-center"">
                                    <button class=""btn hvr-hover"" id=""submit"" type=""submit"">Send Message</button>
                                    <div id=""msgSubmit"" class=""h3 text-center hidden""></div>
     ");
                WriteLiteral("                               <div class=\"clearfix\"></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            <div class=""col-lg-4 col-sm-12"">
                <div class=""contact-info-left"">
                    <h2>CONTACT INFO</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent urna diam, maximus ut ullamcorper quis, placerat id eros. Duis semper justo sed condimentum rutrum. Nunc tristique purus turpis. Maecenas vulputate. </p>
                    <ul>
                        <li>
                            <p><i class=""fas fa-map-marker-alt""></i>Address: Michael I. Days 9000 <br>Preston Street Wichita,<br> KS 87213 </p>
                        </li>
                        <li>
                            <p><i class=""fas fa-phone-square""></i>Phone: <a href=""tel:+1-888705770"">+1-888 705 770</a></p>
                        </li>
                        <li>
                            <p><i class=""fas fa-envelope""></i>Email: <a href=""mailto:contactinfo@gmail.com"">contactinfo@gmail.com</a></p>
          ");
            WriteLiteral("              </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- End Cart -->\r\n");
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
