#pragma checksum "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e42e5e6494b4e9800fed8f637f8df78e6529f22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_Student), @"mvc.1.0.view", @"/Views/CustomerHome/Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/Student.cshtml", typeof(AspNetCore.Views_CustomerHome_Student))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e42e5e6494b4e9800fed8f637f8df78e6529f22", @"/Views/CustomerHome/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
  
	ViewData["Title"] = "Student";
	Layout = "~/Views/Shared/_CustomerProfileLayout.cshtml";

#line default
#line hidden
            BeginContext(96, 269, true);
            WriteLiteral(@"<section class=""profile"">
	<div class=""container"">
		<div class=""profile__header"">
			<div class=""profile__header__toggle"" onclick=""openTab()"">
				<i class=""dn-menu""></i>
			</div>
			<div class=""profile__header__user"">
				<div class=""profile__header__user__avatar"">
");
            EndContext();
#line 14 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
                     if (String.IsNullOrEmpty(ViewBag.url))
					{

#line default
#line hidden
            BeginContext(417, 53, true);
            WriteLiteral("\t\t\t\t\t\t<img src=\"/HomeContent/assets/img/avatar.jpg\">\n");
            EndContext();
#line 17 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(494, 10, true);
            WriteLiteral("\t\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 504, "\"", 531, 2);
            WriteAttributeValue("", 510, "/wwwroot/", 510, 9, true);
#line 20 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
WriteAttributeValue("", 519, ViewBag.url, 519, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(532, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 21 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
					}

#line default
#line hidden
            BeginContext(543, 82, true);
            WriteLiteral("\t\t\t\t</div>\n\t\t\t\t<div class=\"profile__header__user__name\">\n\t\t\t\t\t<span id=\"testname\">");
            EndContext();
            BeginContext(626, 16, false);
#line 24 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
                                   Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(642, 161, true);
            WriteLiteral("</span>\n\t\t\t\t</div>\n\t\t\t\t&nbsp; &nbsp; &nbsp;\n\t\t\t\t<div class=\"profile__header__user__name\">\n\t\t\t\t\t<span id=\"testname\" style=\"color:red\">کد شما برای معرفی به دوستان:");
            EndContext();
            BeginContext(804, 20, false);
#line 28 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
                                                                                 Write(ViewBag.identifyCode);

#line default
#line hidden
            EndContext();
            BeginContext(824, 2860, true);
            WriteLiteral(@"</span>
				</div>
			</div>
			<div class=""profile__header__menu"">
				<ul>
					<li>
						<a href=""/LogoutCustomer"">خروج</a>
					</li>
				</ul>
			</div>
		</div>
		<div class=""profile__wrapper"" style=""min-height:350px;"">
			<div class=""profile__sidebar"">
				<nav>
                    <ul>
                        <li>
                            <a href=""#""><span>تکمیل پروفایل</span></a>
                            <ul>
                                <li>
                                    <a style=""cursor:pointer"" onclick=""profileManagment()"" @*href=""#!""*@ class=""link""><span>تکمیل اطلاعات پروفایل</span></a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#""><span>رزروها</span></a>
                            <ul>
                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllReservedSalowns()"" class=""link""><span>سالن های رزرو شده</s");
            WriteLiteral(@"pan></a>
                                </li>

                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllReservedClasses()"" class=""link""><span>کلاس های رزرو شده</span></a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#""><span>مدیریت تبلیغات و ورکشاپ</span></a>
                            <ul>

                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllAdvertisment()"" class=""link""><span>همه تبلیغات من</span></a>
                                </li>
                                <li>
                                    <a style=""cursor:pointer"" id=""newAdvertisment"" class=""link""><span>ایجاد تبلیغ</span></a>

                                </li>

                            </ul>
                        </li>
                        <li>
                            <a href=""#""");
            WriteLiteral(@"><span>مدیریت آگهی ها</span></a>
                            <ul>

                                <li>
                                    <a style=""cursor:pointer"" onclick=""showAllNotice()"" class=""link""><span>همه آگهی های من</span></a>
                                </li>
                                <li>
                                    <a style=""cursor:pointer"" id=""newNotice"" class=""link""><span>ایجاد آگهی</span></a>

                                </li>

                            </ul>
                        </li>

                    </ul>
				</nav>
			</div>
			<div class=""profile__content"">
				<div class=""profile__content__dashboard"">
					<div class=""row"">
						<div class=""col-lg-3"">
							<div class=""profile__content__dashboard__item"">
								<span>امتیاز</span>
								<span>");
            EndContext();
            BeginContext(3685, 17, false);
#line 101 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
                                 Write(ViewBag.UserScore);

#line default
#line hidden
            EndContext();
            BeginContext(3702, 162, true);
            WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t<div class=\"col-lg-3\">\n\t\t\t\t\t\t\t<div class=\"profile__content__dashboard__item\">\n\t\t\t\t\t\t\t\t<span>آگهی ها</span>\n\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(3865, 19, false);
#line 107 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
                                 Write(ViewBag.TotalNotice);

#line default
#line hidden
            EndContext();
            BeginContext(3884, 170, true);
            WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t<div class=\"col-lg-3\">\n\t\t\t\t\t\t\t<div class=\"profile__content__dashboard__item\">\n\t\t\t\t\t\t\t\t<span>تبلیغات وورکشاپ</span>\n\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(4055, 26, false);
#line 113 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
                                 Write(ViewBag.TotalAdvertisments);

#line default
#line hidden
            EndContext();
            BeginContext(4081, 161, true);
            WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t<div class=\"col-lg-3\">\n\t\t\t\t\t\t\t<div class=\"profile__content__dashboard__item\">\n\t\t\t\t\t\t\t\t<span>رزروها</span>\n\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(4243, 20, false);
#line 119 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
                                 Write(ViewBag.TotalReserve);

#line default
#line hidden
            EndContext();
            BeginContext(4263, 1336, true);
            WriteLiteral(@"</span>
							</div>
						</div>
					</div>
				</div>
				<div id=""profile__content"" style=""display:none"">

				</div>
				<div id=""divRegister"" style=""display:none"">

				</div>
			</div>
		</div>
	</div>
</section>

<div id=""Error"">

</div>
<div id=""Question"">

</div>
<div id=""Advertisment"">

</div>
<div id=""Notice"">

</div>
<div class=""modal fade"" id=""score-user"">
	<div class=""modal-dialog"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<button type=""button"" class=""close"" data-dismiss=""modal"" style=""margin-top: 7px; margin-left: 7px;"">
				</button>
				<h4 class=""modal-title"">سامانه گیسو</h4>
			</div>
			<div class=""modal-body"">
				<p>درخواست شما با موفقیت انجام شد و از امتیاز شما کسر گردید</p>
			</div>
		</div>
		<!-- /.modal-content -->
	</div>
	<!-- /.modal-dialog -->
</div>
<div id=""ItemId"">
	<input name=""advertismentid"" id=""advertismentid"" hidden>
	<input name=""noticeid"" id=""noticeid"" hidden>
</div>
<script>
    function openTab() {
        $('.profile__wrapper').toggleClass(");
            WriteLiteral(@"'profile__wrapper--collapse');

    }
    $('.profile__sidebar nav a').on('click', function () {
        if ($(this).hasClass('link')) {
            $('.profile__wrapper').toggleClass('profile__wrapper--collapse');
        }
    })
    window.onload = Load;
	function Load() {

		CreateAllModals();
        if ('");
            EndContext();
            BeginContext(5600, 16, false);
#line 181 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
        Write(ViewBag.subScore);

#line default
#line hidden
            EndContext();
            BeginContext(5616, 77, true);
            WriteLiteral("\' == \'True\') {\n        $(\'#score-user\').modal(\'show\');\n        }\n       if (\'");
            EndContext();
            BeginContext(5694, 24, false);
#line 184 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
       Write(ViewBag.isNoticeShortcut);

#line default
#line hidden
            EndContext();
            BeginContext(5718, 49, true);
            WriteLiteral("\' == 1) {\n\t\t\t$(\"#newNotice\").click();\n\t\t}\n\t\tif (\'");
            EndContext();
            BeginContext(5768, 32, false);
#line 187 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
        Write(ViewBag.hasadverstitmentshortcut);

#line default
#line hidden
            EndContext();
            BeginContext(5800, 63, true);
            WriteLiteral("\' == 1) {\n\t\t\t$(\"#newAdvertisment\").click();\n\t\t}\n\t}\n\n\n\n    if (\'");
            EndContext();
            BeginContext(5864, 22, false);
#line 194 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
    Write(ViewBag.isRegisterLine);

#line default
#line hidden
            EndContext();
            BeginContext(5886, 53, true);
            WriteLiteral("\' == \'True\') {\n        showAllLine();\n    }\n    if (\'");
            EndContext();
            BeginContext(5940, 30, false);
#line 197 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
    Write(ViewBag.isRegisterAdvertisment);

#line default
#line hidden
            EndContext();
            BeginContext(5970, 61, true);
            WriteLiteral("\' == \'True\') {\n        showAllAdvertisment();\n    }\n    if (\'");
            EndContext();
            BeginContext(6032, 24, false);
#line 200 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Student.cshtml"
    Write(ViewBag.isRegisterNotice);

#line default
#line hidden
            EndContext();
            BeginContext(6056, 1758, true);
            WriteLiteral(@"' == 'True') {
        showAllNotice();
    }

	function showAllReservedSalowns() {
		GetData(""/CustomerHome/ReservedSalowns"", ""divRegister"");
	}

    function showAllReservedClasses() {
		GetData(""/CustomerHome/ReservedClass"", ""divRegister"");
	}
      function showAllAdvertisment() {

        GetData(""/CustomerHome/AllAdvertisment"", ""divRegister"");
    }

    function RemoveAdvertisment() {
        var Parameters = [{ id: ""id"", htmlname: ""advertismentid"", special: """" }];
        PostAjax('../CustomerHome/RemoveAdvertisment', Parameters, showAllAdvertisment);
        $(""#QuestionModalAdvertisment"").modal('hide');
        $('.modal-backdrop').remove();
    }
    function RemoveNotice() {
        var Parameters = [{ id: ""id"", htmlname: ""noticeid"", special: """" }];
        PostAjax('../CustomerHome/RemoveNotice', Parameters, showAllNotice);
        $(""#QuestionModalNotice"").modal('hide');
        $('.modal-backdrop').remove();
    }

    function AssignButtonClicked(elem, page) {
        if (page == 1) {
        ");
            WriteLiteral(@"    $('#lineid').val($(elem).data('assigned-id'));
        }
        if (page == 2) {
            $('#advertismentid').val($(elem).data('assigned-id'));
        }
        if (page == 3) {
            $('#noticeid').val($(elem).data('assigned-id'));
        }

    }
    $(""#newAdvertisment"").on(""click"", function () {
        GetData(""/CustomerHome/RegisterAdvertisment"", ""divRegister"");
    });

    $(""#newNotice"").on(""click"", function () {
        GetData(""/CustomerHome/RegisterNotice"", ""divRegister"");
    });
    function showAllNotice() {
        GetData(""/CustomerHome/AllNotice"", ""divRegister"");
	}
	function profileManagment() {
        GetData(""/CustomerHome/ProfileManagment"", ""divRegister"", null, true);
	}



</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591