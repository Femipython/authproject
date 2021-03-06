#pragma checksum "C:\Users\User\Desktop\Authsystem\Authsystem\Areas\administratorAreaRegistration\Views\_adminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2aa0d394cde588fe774fb3894c1221432e935a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_administratorAreaRegistration_Views__adminLayout), @"mvc.1.0.view", @"/Areas/administratorAreaRegistration/Views/_adminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2aa0d394cde588fe774fb3894c1221432e935a", @"/Areas/administratorAreaRegistration/Views/_adminLayout.cshtml")]
    public class Areas_administratorAreaRegistration_Views__adminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2aa0d394cde588fe774fb3894c1221432e935a2884", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width-device-width\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\User\Desktop\Authsystem\Authsystem\Areas\administratorAreaRegistration\Views\_adminLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>

    <link rel=""stylesheet"" href=""css/home_page.css"">
    <link href=""https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@500&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <!-- <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous""> -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2aa0d394cde588fe774fb3894c1221432e935a4720", async() => {
                WriteLiteral(@"

    <!-- Header -->

    <div class=""section-container"">
        <section class=""wrap-header-intro"">
            <div class=""section-header-navigation"" id=""navigation"">
                <a class=""section-header-title"" href=""index.html"">DigiReceipts</a>
                <div class=""section-nav"">
                    <a href=""login.html"" class=""nav-login"">Login</a>
                    <a href=""register.html"" class=""nav-register"">Register to start now!</a>
                    <a href=""javascript:void(0);"" class=""icon"" onclick=""navbar()"">
                        <i class=""fa fa-bars""></i>
                    </a>
                </div>
            </div>

            <!-- Introduction -->

            <div class=""intro"">
                <div class=""section-intro-title"">
                    Create receipts for your customers In 3 seconds
                </div>
                <div class=""section-intro-paragraph"">
                    <p>
                        Creating web receipts for your");
                WriteLiteral(@" customers is easier than before,
                        send it as a PDF or send the weblink, either ways, it’s easier than you think
                    </p>
                </div>
                <div class=""section-intro-email"">
                    <div class=""section-email"">Enter Your Email Address</div>
                    <div class=""section-email-start""><a href=""register.html"">Start now!</a></div>
                </div>
            </div>
        </section>

        <!-- Services -->

        <section class=""wrap-services-footer"">
            <div class=""services-offered"">
                <div class=""section-services-title"">
                    Fast-track your business with us
                </div>

                <div class=""section-services-paragraph"">
                    <p>
                        Creating web receipts for your customers is easier than before,
                        send it as a PDF or send the weblink
                    </p>
                </div>
  ");
                WriteLiteral("              <div class=\"services\">\r\n                    <div class=\"service\">\r\n                        <img src=\"img/Icon awesome-user-friends.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 2849, "\"", 2855, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        User-friendly Interface
                        <p>
                            Creating web receipts for your customers is easier than before,
                            send it as a PDF or send the weblink, either ways, it’s easier than you think.
                        </p>
                    </div>
                    <div class=""service"">
                        <img src=""img/Icon awesome-share-square.svg""");
                BeginWriteAttribute("alt", " alt=\"", 3307, "\"", 3313, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        Export and Sharing Options
                        <p>
                            Creating web receipts for your customers is easier than before,
                            send it as a PDF or send the weblink, either ways, it’s easier than you think.
                        </p>
                    </div>
                    <div class=""service"">
                        <img src=""img/Icon material-business-center.svg""");
                BeginWriteAttribute("alt", " alt=\"", 3772, "\"", 3778, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        Business Ready Always
                        <p>
                            Creating web receipts for your customers is easier than before,
                            send it as a PDF or send the weblink, either ways, it’s easier than you think.
                        </p>
                    </div>
                </div>
            </div>

            <div class=""section-offers"">
                <div class=""section-offers-title"">
                    Fast-track your business with us now!
                </div>
                <div class=""section-offers-email"">
                    <div class=""section-email"">Enter Your Email Address</div>
                    <div class=""section-email-start""><a href=""register.html"">Start now!</a></div>
                </div>
            </div>


            <!-- Footer -->

            <section class=""footer-items"">
                <div class=""footer"">
                    <div class=""footer-team"">
                        C");
                WriteLiteral(@"reated by team-enya
                    </div>
                    <div class=""footer-privacy"">
                        Privacy Policy | Terms and Conditions
                    </div>
                </div>
            </section>
        </section>
    </div>

    <!-- JavaScript for navbar -->

    <script src=""js/home_page.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
