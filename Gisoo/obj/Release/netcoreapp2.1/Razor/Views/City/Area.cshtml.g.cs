#pragma checksum "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64843c57958faf6fe000d2a1462e58fa82814f8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_City_Area), @"mvc.1.0.view", @"/Views/City/Area.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/City/Area.cshtml", typeof(AspNetCore.Views_City_Area))]
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
#line 1 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\_ViewImports.cshtml"
using Gisoo;

#line default
#line hidden
#line 2 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\_ViewImports.cshtml"
using Gisoo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64843c57958faf6fe000d2a1462e58fa82814f8c", @"/Views/City/Area.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_City_Area : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<Gisoo.Models.Area>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Area", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AreaForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 152, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-xs-12\">\n        <div class=\"box\">\n            <div class=\"box-header\">\n                <h3 class=\"box-title\">حومه ");
            EndContext();
            BeginContext(205, 30, false);
#line 6 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                                      Write(ViewData["parentProvinceName"]);

#line default
#line hidden
            EndContext();
            BeginContext(235, 66, true);
            WriteLiteral("</h3>\n                <br />\n                <p style=\"color:red\">");
            EndContext();
            BeginContext(302, 15, false);
#line 8 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                                Write(ViewBag.success);

#line default
#line hidden
            EndContext();
            BeginContext(317, 227, true);
            WriteLiteral("</p>\n            </div>\n\n            <div class=\"row\">\n                <div class=\"col-md-12\">\n                    <a class=\"btn btn-default\" data-toggle=\"modal\" data-target=\"#modal-default\">حومه جدید</a>\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 544, "\"", 594, 2);
            WriteAttributeValue("", 551, "/City/Province?id=", 551, 18, true);
#line 14 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
WriteAttributeValue("", 569, ViewData["parentCityId"], 569, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(595, 477, true);
            WriteLiteral(@" class=""btn btn-danger"">بازگشت</a>

                </div>

            </div>
            <!-- /.box-header -->
            <div class=""box-body table-responsive"">
                <table id=""example2"" class=""table table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>عنوان</th>

                            <th>امکانات</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 30 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1151, 69, true);
            WriteLiteral("                            <tr>\n                                <td>");
            EndContext();
            BeginContext(1221, 9, false);
#line 33 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1230, 134, true);
            WriteLiteral("</td>\n\n                                <td>\n                                    <button name=\"Edit-Area\" data-toggle=\"modal\" data-id=\"");
            EndContext();
            BeginContext(1365, 7, false);
#line 36 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                                                                                     Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1372, 78, true);
            WriteLiteral("\" class=\"btn btn-default\">ویرایش</button>\n                                    ");
            EndContext();
            BeginContext(1450, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24891e29aff04fbe805cc13a080176f5", async() => {
                BeginContext(1525, 3, true);
                WriteLiteral("حذف");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                                                                 WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1532, 74, true);
            WriteLiteral("\n\n                                </td>\n                            </tr>\n");
            EndContext();
#line 41 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                        }

#line default
#line hidden
            BeginContext(1632, 440, true);
            WriteLiteral(@"                    </tbody>
                    <tfoot>
                    </tfoot>
                </table>
            </div>
            <!-- /.box-body -->
            <div class=""row"">
                <div class=""col-sm-5"">
                </div>
                <div class=""col-sm-7"">
                    <div class=""dataTables_paginate paging_simple_numbers"" id=""example1_paginate"">
                        <ul class=""pagination"">
");
            EndContext();
            BeginContext(2496, 65, true);
            WriteLiteral("                            <li>\n                                ");
            EndContext();
            BeginContext(2561, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58875f6cb3a04f6ca201911db5cb92ea", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
#line 61 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
                                                                                               WriteLiteral(ViewData["parentProvinceId"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2669, 597, true);
            WriteLiteral(@"
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- /.col -->
</div>
<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">حومه</h4>
            </div>
            ");
            EndContext();
            BeginContext(3266, 1186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da6cd898385046a49a2a587b1c21fb78", async() => {
                BeginContext(3286, 129, true);
                WriteLiteral("\n                <input type=\"hidden\" id=\"id\" name=\"id\" value=\"\" />\n                <div class=\"modal-body\">\n                    ");
                EndContext();
                BeginContext(3415, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37585cade4504c4d85bf294be9de3a39", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 84 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3481, 96, true);
                WriteLiteral("\n                    <input class=\"form-control\" type=\"hidden\" id=\"provinceId\" name=\"provinceId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3577, "\"", 3614, 1);
#line 85 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\City\Area.cshtml"
WriteAttributeValue("", 3585, ViewData["parentProvinceId"], 3585, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3615, 830, true);
                WriteLiteral(@">

                    <div class=""form-group"">
                        <label class=""control-label"">عنوان حومه</label>
                        <input class=""form-control"" type=""text"" data-val=""true"" data-val-maxlength=""عنوان حومه نمی تواند بیشتر از 50 کاراکتر باشد ."" data-val-maxlength-max=""50"" data-val-required=""لطفا عنوان حومه را وارد کنید"" id=""name"" name=""name"" value="""">
                        <span class=""text-danger field-validation-valid"" data-valmsg-for=""name"" data-valmsg-replace=""true""></span>
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">خروج</button>
                    <button type=""submit"" class=""btn btn-primary"">ذخیره</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4452, 95, true);
            WriteLiteral("\n        </div>\n        <!-- /.modal-content -->\n    </div>\n    <!-- /.modal-dialog -->\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4569, 2997, true);
                WriteLiteral(@"
    <script>
        $(""#AreaForm"").submit(function (event) {
            event.preventDefault();
            if ($('#AreaForm').valid()) {
                var pagenumber = $(""#PageNumber"").val();
                var form = $(this).serialize();
                $.ajax({
                    url: ""/City/CreateOrEditArea"",
                    method: ""POST"",
                    data: form,
                    success: function (data) {
                        $('#modal-default').modal('hide');
                        var messageText = """";
                        if ($('#modal-default #id').val() != '' && $('#modal-default #id').val() != 0) {
                            messageText = 'ویرایش  حومه با موفقیت انجام شد';
                        }
                        else {
                            messageText = 'اضافه کردن حومه با موفقیت انجام شد';
                        }
                        swal({
                            title: '!  موفقیت آمیز',
                            text: messageText,
      ");
                WriteLiteral(@"                      type: 'success',
                            buttonsStyling: false,
                            confirmButtonClass: 'btn btn-sm btn-light',
                            background: 'rgba(0, 0, 0, 0.96)',
                            timer: 1500
                        })
                        var id = $(""#categoryForm #id"").val();
                        if(id!="""")
                            location.reload();
                        else
                        window.location.href = ""/City/Area?page=1"";
                    },
                    error: function () {
                        alert(""Ajax call failed"");
                    }
                })
            }
        });
        $(""button[name='Edit-Area']"").click(function (e) {
            $(""#Area-header"").html(""ویرایش حومه"");
            var Id = $(this).attr(""data-id"");
            $.ajax({
                url: ""/City/GetArea?id="" + Id + """",
                method: ""Get"",
                dataType: ""json"",
              ");
                WriteLiteral(@"  success: function (data) {
                    if (data.id != 0) {
                        $(""#AreaForm #id"").val(data.id);
                        $(""#AreaForm #name"").val(data.name);
                        $('#modal-default').modal('show');
                    }
                    else {
                        alert(""ID is incorrect"");
                    }
                },
                error: function () {
                    alert(""Ajax call failed"");
                }
            })
        })

        $('#modal-default').on('hidden.bs.modal', function () {
            $('#modal-default').find('input,textarea,select').each(function (key) {
                if ($(this).attr('id') == ""id"") {
                    $(this).val(0);
                }
                else
                    if ($(this).attr('name') != '__RequestVerificationToken')
                        $(this).val('');
            })
        })
    </script>


");
                EndContext();
            }
            );
            BeginContext(7568, 1, true);
            WriteLiteral("\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<Gisoo.Models.Area>> Html { get; private set; }
    }
}
#pragma warning restore 1591
