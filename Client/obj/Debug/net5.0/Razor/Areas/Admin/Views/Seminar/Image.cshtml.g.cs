#pragma checksum "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede4b1c0da22dbc0ff85a7fbbe6c0cbf108f0f08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Seminar_Image), @"mvc.1.0.view", @"/Areas/Admin/Views/Seminar/Image.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede4b1c0da22dbc0ff85a7fbbe6c0cbf108f0f08", @"/Areas/Admin/Views/Seminar/Image.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c1f8bec51aa3a6382909f1df9302c1ff216f83", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Seminar_Image : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "seminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addImgSer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
  
    ViewData["Title"] = "Image";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">

            <nav class=""navbar navbar-expand-sm bg-light"" style=""margin-bottom:3%"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 422, "\"", 479, 2);
            WriteAttributeValue("", 429, "/admin/seminar/detail?idSeminar=", 429, 32, true);
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
WriteAttributeValue("", 461, ViewBag.idSeminar, 461, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Seminar</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 668, 2);
            WriteAttributeValue("", 614, "/admin/seminar/performent?idSeminar=", 614, 36, true);
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
WriteAttributeValue("", 650, ViewBag.idSeminar, 650, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Performent</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 799, "\"", 855, 2);
            WriteAttributeValue("", 806, "/admin/seminar/image?idSeminar=", 806, 31, true);
#nullable restore
#line 20 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
WriteAttributeValue("", 837, ViewBag.idSeminar, 837, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Image</a>\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n            <button class=\"file-upload-browse btn btn-gradient-info\" type=\"button\" data-toggle=\"modal\" data-target=\"#ModalImg\">Add</button>\r\n");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
             if (ViewBag.listImg == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\" role=\"alert\">\r\n                    THERE IS NO DATA!!!\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\" style=\"width:65%; margin:auto\">\r\n                    <div class=\"carousel-inner\" id=\"imgSer\">\r\n");
#nullable restore
#line 35 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
                         foreach (var item in ViewBag.listImg)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"carousel-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ede4b1c0da22dbc0ff85a7fbbe6c0cbf108f0f089453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1716, "~/img/seminar/", 1716, 14, true);
#nullable restore
#line 38 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
AddHtmlAttributeValue("", 1730, item.Path, 1730, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"carousel-caption d-none d-md-block\">\r\n                                    <button class=\"btn btn-gradient-danger\" type=\"button\"><a");
            BeginWriteAttribute("href", " href=\"", 1936, "\"", 2009, 5);
            WriteAttributeValue("", 1943, "/admin/seminar/delImg?idSeminar=", 1943, 32, true);
#nullable restore
#line 40 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
WriteAttributeValue("", 1975, ViewBag.idSeminar, 1975, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1993, "&idImg=", 1993, 7, true);
#nullable restore
#line 40 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
WriteAttributeValue("", 2000, item.Id, 2000, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2008, "", 2009, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a></button>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""modal"" id=""ModalImg"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Add Image</h4>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ede4b1c0da22dbc0ff85a7fbbe6c0cbf108f0f0813672", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <img id=""blah"" src=""#"" alt=""your image"" class=""col-md-6"" style=""margin: auto; height:100%"" />
                    </div>
                    <div class=""row"">
                        <div class=""input-group col-md-6"" style=""margin: auto"">
                            <div class=""custom-file"">
                                <input hidden");
                BeginWriteAttribute("value", " value=\"", 3661, "\"", 3687, 1);
#nullable restore
#line 73 "C:\Users\Admin\Desktop\Project3Client\Client\Areas\Admin\Views\Seminar\Image.cshtml"
WriteAttributeValue("", 3669, ViewBag.idSeminar, 3669, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""idSeminar"" />

                                <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01"" aria-describedby=""inputGroupFileAddon01"" name=""file"">
                                <label class=""custom-file-label"" for=""inputGroupFile01"">Choose file</label>
                            </div>
                        </div>
                    </div>
                    <div class=""row col-md-6"" style=""margin: auto"">
                        <div>
                            <button class=""file-upload-browse btn btn-gradient-success"" type=""submit"" data-toggle=""modal"" data-target=""#ModalImg"">Save</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
