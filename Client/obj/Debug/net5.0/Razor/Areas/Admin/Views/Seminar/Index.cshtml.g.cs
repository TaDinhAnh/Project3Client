#pragma checksum "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb013519ef2be7ef1a375c337b5020e47fc818ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Seminar_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Seminar/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb013519ef2be7ef1a375c337b5020e47fc818ff", @"/Areas/Admin/Views/Seminar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Seminar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Seminar Table</h4>
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th> Seminar </th>
                        <th> Presenter </th>
                        <th> Time </th>
                        <th> Status </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 19 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                     if (ViewBag.listSeminar != null)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                         foreach (var seminar in ViewBag.listSeminar)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb013519ef2be7ef1a375c337b5020e47fc818ff5288", async() => {
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
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                                                                                                    Write(seminar.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                               Write(seminar.Presenters);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                               Write(seminar.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                                 if (seminar.Day < DateTime.Now && seminar.Status)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <label class=\"badge badge-gradient-success\">Completed</label>\r\n                                    </td>\r\n");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                                }
                                else if (seminar.Day >= DateTime.Now && seminar.Status)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <label class=\"badge badge-gradient-warning\">Coming soon</label>\r\n                                    </td>\r\n");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <label class=\"badge badge-gradient-danger\">False</label>\r\n                                    </td>\r\n");
#nullable restore
#line 45 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
