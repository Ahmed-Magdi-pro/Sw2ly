#pragma checksum "C:\Users\hadee\OneDrive\المستندات\Visual Studio 2019\Projects\Fast_Market\Fast_Market\Views\Shop\cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1024979050550bbb798e5c6a6ec92a42ff24356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_cart), @"mvc.1.0.view", @"/Views/Shop/cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1024979050550bbb798e5c6a6ec92a42ff24356", @"/Views/Shop/cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a448cbf8cf6f49b6ef26616c05868564d82cec2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/img-pro-01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/img-pro-02.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/img-pro-03.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hadee\OneDrive\المستندات\Visual Studio 2019\Projects\Fast_Market\Fast_Market\Views\Shop\cart.cshtml"
  
    ViewData["Title"] = "cart";

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
                    <h2>Cart</h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Cart</li>
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

<!-- Start Cart  -->
<div class=""cart-box-main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""table-main table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Images</th>
                                <th>Product Name</th>
                                <th>Price</th>
                                <th>Quantity</th>
                                <th>Total</th>
                                <th>Remove</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class=""thumbnail-img"">
                                    <a href=""#"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1024979050550bbb798e5c6a6ec92a42ff243566831", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </td>
                                <td class=""name-pr"">
                                    <a href=""#"">
                                        Lorem ipsum dolor sit amet
                                    </a>
                                </td>
                                <td class=""price-pr"">
                                    <p>$ 80.0</p>
                                </td>
                                <td class=""quantity-box""><input type=""number"" size=""4"" value=""1"" min=""0"" step=""1"" class=""c-input-text qty text""></td>
                                <td class=""total-pr"">
                                    <p>$ 80.0</p>
                                </td>
                                <td class=""remove-pr"">
                                    <a href=""#"">
                                        <i class=""fas fa-times""></i>
                                    </a>
                             ");
            WriteLiteral("   </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"thumbnail-img\">\r\n                                    <a href=\"#\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1024979050550bbb798e5c6a6ec92a42ff243569350", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </td>
                                <td class=""name-pr"">
                                    <a href=""#"">
                                        Lorem ipsum dolor sit amet
                                    </a>
                                </td>
                                <td class=""price-pr"">
                                    <p>$ 60.0</p>
                                </td>
                                <td class=""quantity-box""><input type=""number"" size=""4"" value=""1"" min=""0"" step=""1"" class=""c-input-text qty text""></td>
                                <td class=""total-pr"">
                                    <p>$ 80.0</p>
                                </td>
                                <td class=""remove-pr"">
                                    <a href=""#"">
                                        <i class=""fas fa-times""></i>
                                    </a>
                             ");
            WriteLiteral("   </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"thumbnail-img\">\r\n                                    <a href=\"#\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1024979050550bbb798e5c6a6ec92a42ff2435611869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </td>
                                <td class=""name-pr"">
                                    <a href=""#"">
                                        Lorem ipsum dolor sit amet
                                    </a>
                                </td>
                                <td class=""price-pr"">
                                    <p>$ 30.0</p>
                                </td>
                                <td class=""quantity-box""><input type=""number"" size=""4"" value=""1"" min=""0"" step=""1"" class=""c-input-text qty text""></td>
                                <td class=""total-pr"">
                                    <p>$ 80.0</p>
                                </td>
                                <td class=""remove-pr"">
                                    <a href=""#"">
                                        <i class=""fas fa-times""></i>
                                    </a>
                             ");
            WriteLiteral(@"   </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

        <div class=""row my-5"">
            <div class=""col-lg-6 col-sm-6"">
                <div class=""coupon-box"">
                    <div class=""input-group input-group-sm"">
                        <input class=""form-control"" placeholder=""Enter your coupon code"" aria-label=""Coupon code"" type=""text"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-theme"" type=""button"">Apply Coupon</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-sm-6"">
                <div class=""update-box"">
                    <input value=""Update Cart"" type=""submit"">
                </div>
            </div>
        </div>

        <div class=""row my-5"">
            <div class=""col-lg-8 col-sm-12""");
            WriteLiteral(@"></div>
            <div class=""col-lg-4 col-sm-12"">
                <div class=""order-box"">
                    <h3>Order summary</h3>
                    <div class=""d-flex"">
                        <h4>Sub Total</h4>
                        <div class=""ml-auto font-weight-bold""> $ 130 </div>
                    </div>
                    <div class=""d-flex"">
                        <h4>Discount</h4>
                        <div class=""ml-auto font-weight-bold""> $ 40 </div>
                    </div>
                    <hr class=""my-1"">
                    <div class=""d-flex"">
                        <h4>Coupon Discount</h4>
                        <div class=""ml-auto font-weight-bold""> $ 10 </div>
                    </div>
                    <div class=""d-flex"">
                        <h4>Tax</h4>
                        <div class=""ml-auto font-weight-bold""> $ 2 </div>
                    </div>
                    <div class=""d-flex"">
                        <h4>Shipping Cost</h");
            WriteLiteral(@"4>
                        <div class=""ml-auto font-weight-bold""> Free </div>
                    </div>
                    <hr>
                    <div class=""d-flex gr-total"">
                        <h5>Grand Total</h5>
                        <div class=""ml-auto h5""> $ 388 </div>
                    </div>
                    <hr>
                </div>
            </div>
            <div class=""col-12 d-flex shopping-box""><a href=""checkout.html"" class=""ml-auto btn hvr-hover"">Checkout</a> </div>
        </div>

    </div>
</div>
<!-- End Cart -->
");
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
