#pragma checksum "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3077527e1c472be13cb3cd919ce1d96e1ca4c02b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.razor-page", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index), null)]
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
#line 1 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\_ViewImports.cshtml"
using BlockChainPaymentShop;

#line default
#line hidden
#line 2 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\_ViewImports.cshtml"
using BlockChainPaymentShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077527e1c472be13cb3cd919ce1d96e1ca4c02b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295894c1599dd8a6a1fc451c8034b84a984f21b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/qrcode.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
  
    string ip = HttpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
    var users = VideoOwned.users;
    var lstVideoes = ViewBag.Videoes as List<Video>;
    var DomainName = HttpContextAccessor.HttpContext.Request.Scheme + "://" + HttpContextAccessor.HttpContext.Request.Host;

#line default
#line hidden
            BeginContext(396, 148, true);
            WriteLiteral("\r\n<style>\r\n    .qrcode {\r\n        width: 128px;\r\n        height: 128px;\r\n        margin: 0 auto;\r\n        text-align: center;\r\n    }\r\n</style>\r\n<h2>");
            EndContext();
            BeginContext(545, 2, false);
#line 20 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
Write(ip);

#line default
#line hidden
            EndContext();
            BeginContext(547, 32, true);
            WriteLiteral("</h2>\r\n<div class=\"container\">\r\n");
            EndContext();
#line 22 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
     foreach (var item in lstVideoes)
    {

#line default
#line hidden
            BeginContext(625, 101, true);
            WriteLiteral("        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-10\" style=\"color:blue\"><h2>");
            EndContext();
            BeginContext(727, 10, false);
#line 26 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(737, 56, true);
            WriteLiteral("</h2></div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 29 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
              
                string img = "/images/" + item.Id + ".PNG";
            

#line default
#line hidden
            BeginContext(885, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 32 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
             if (users.FirstOrDefault(x => x.Id == item.Id && x.Ip == ip) == null)
            {

#line default
#line hidden
            BeginContext(984, 37, true);
            WriteLiteral("                <div class=\"col-xs-8\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1021, "\"", 1100, 4);
            WriteAttributeValue("", 1029, "height:500px;background-image:url(\'", 1029, 35, true);
#line 34 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1064, img, 1064, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1068, "\');background-repeat:", 1068, 21, true);
            WriteAttributeValue(" ", 1089, "no-repeat;", 1090, 11, true);
            EndWriteAttribute();
            BeginContext(1101, 27, true);
            WriteLiteral(">\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1128, "\"", 1145, 2);
            WriteAttributeValue("", 1133, "div_", 1133, 4, true);
#line 35 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1137, item.Id, 1137, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1146, 165, true);
            WriteLiteral(" class=\"text-center\" style=\"background-color:white\">\r\n                        <div class=\"qrcode\">\r\n                            http://192.168.1.29:5000/api/Pay?pid=");
            EndContext();
            BeginContext(1312, 7, false);
#line 37 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
                                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 4, true);
            WriteLiteral("&ip=");
            EndContext();
            BeginContext(1324, 2, false);
#line 37 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
                                                                        Write(ip);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 60, true);
            WriteLiteral("&recipient=1EDvdbQVNEtEvSsUpwunpjbGoZa3SCnkUu&fees=1&amount=");
            EndContext();
            BeginContext(1387, 10, false);
#line 37 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
                                                                                                                                       Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 113, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n\r\n                        <h2 class=\"\" style=\"background-color:white;\">Pay ");
            EndContext();
            BeginContext(1511, 10, false);
#line 42 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
                                                                    Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 91, true);
            WriteLiteral(" Coins to UnLock this Video</h2>\r\n                    </div>\r\n\r\n                    <iframe");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1612, "\"", 1632, 2);
            WriteAttributeValue("", 1617, "iframe_", 1617, 7, true);
#line 45 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1624, item.Id, 1624, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1633, 110, true);
            WriteLiteral(" width=\"870\" height=\"490\" class=\"hide\"\r\n                            src=\"\"></iframe>\r\n                </div>\r\n");
            EndContext();
#line 48 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1791, 67, true);
            WriteLiteral("                <div class=\"col-xs-8\">\r\n                    <iframe");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1858, "\"", 1878, 2);
            WriteAttributeValue("", 1863, "iframe_", 1863, 7, true);
#line 52 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1870, item.Id, 1870, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1879, 34, true);
            WriteLiteral(" width=\"870\" height=\"490\" class=\"\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n                            src=\"", 1913, "\"", 2003, 3);
            WriteAttributeValue("", 1948, "http://www.youtube.com/embed/", 1948, 29, true);
#line 53 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 1977, item.URL, 1977, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1986, "?rel=0&autoplay=1", 1986, 17, true);
            EndWriteAttribute();
            BeginContext(2004, 36, true);
            WriteLiteral("></iframe>\r\n                </div>\r\n");
            EndContext();
#line 55 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2055, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
            BeginContext(2073, 38, true);
            WriteLiteral("        <div class=\"col-xs-4\"></div>\r\n");
            EndContext();
#line 59 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(2120, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(2130, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3077527e1c472be13cb3cd919ce1d96e1ca4c02b13091", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2178, 143, true);
            WriteLiteral("\r\n\r\n<script>\r\n    const connection = new signalR.HubConnectionBuilder()\r\n        .withUrl(\"/chatHub\")\r\n        .build();\r\n\r\n    connection.on(\"");
            EndContext();
            BeginContext(2322, 2, false);
#line 70 "D:\GITHUB\dotnet-core-blockchain-advanced\BlockChainPaymentShop\BlockChainPaymentShop\Views\Home\Index.cshtml"
              Write(ip);

#line default
#line hidden
            EndContext();
            BeginContext(2324, 559, true);
            WriteLiteral(@""", (id, url) => {//ReceiveMessage==ip address
        //var id = user;
        //var url = message;
        //alert(id + url);
        var v = document.getElementById(""div_"" + id);
        v.setAttribute(""class"", ""hide"");
        v.parentElement.setAttribute(""style"", """");
        var c = document.getElementById(""iframe_"" + id);
        c.setAttribute(""src"", ""http://www.youtube.com/embed/"" + url +""?rel=0&autoplay=1"");
        c.setAttribute(""class"", """");
    });
    connection.start().catch(err => console.error(err.toString()));
</script>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2900, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2906, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3077527e1c472be13cb3cd919ce1d96e1ca4c02b15542", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2944, 634, true);
                WriteLiteral(@"

    <script>
        $('.qrcode').each(function () {
            //https://codepen.io/html5andblog/pen/rLQdNV
            var $this = $(this);
            var value = $this.text().trim();
            //alert(value);
            // Clear Previous QR Code
            $this.html('');

            // Set Size to Match User Input
            var qrSize = 200;

            $this.css({
                'width': qrSize,
                'height': qrSize
            })

            // Generate and Output QR Code
            $this.qrcode({ width: qrSize, height: qrSize, text: value });

        });
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Index>)PageContext?.ViewData;
        public Views_Home_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591