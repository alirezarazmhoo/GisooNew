#pragma checksum "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a9573d6bdf7e808ab4c3318fe788f77d40459c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_Login), @"mvc.1.0.view", @"/Views/CustomerHome/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerHome/Login.cshtml", typeof(AspNetCore.Views_CustomerHome_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a9573d6bdf7e808ab4c3318fe788f77d40459c", @"/Views/CustomerHome/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a3d81957a23aba7d7f90efb3e953c2fa1497fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gisoo.ViewModel.UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/HomeContent/assets/img/auth-bg.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("شماره همراه"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("کد تایید"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
  
	ViewData["Title"] = "Register";
	Layout = "~/Views/Shared/_CustomerLoginLayout.cshtml";

#line default
#line hidden
            BeginContext(132, 71, true);
            WriteLiteral("\n<section>\n\t<section class=\"auth\">\n\t\t<div class=\"auth__background\">\n\t\t\t");
            EndContext();
            BeginContext(203, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "57b829ec2c904d9c9eadfe514bfb6aeb", async() => {
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
            BeginContext(251, 97, true);
            WriteLiteral("\n\t\t</div>\n\t\t<div class=\"container\">\n\t\t\t<div class=\"auth__wrapper\">\n\t\t\t\t<div class=\"auth__logo\">\n\n");
            EndContext();
            BeginContext(445, 114, true);
            WriteLiteral("\t\t\t\t\t<h4 style=\"padding-top:10%;\">سامانه مدیریت سالن های آرایشی گیسو</h4>\n\t\t\t\t\t<p class=\"text text-danger\">\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(560, 64, false);
#line 22 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(624, 87, true);
            WriteLiteral("\n\t\t\t\t\t</p>\n\t\t\t\t</div>\n\t\t\t\t<div class=\"auth__form\">\n\t\t\t\t\t<div class=\"form-group\">\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(711, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb8668ea149947adb8e4dbf37dffffdb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 27 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.cellphone);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(812, 7, true);
            WriteLiteral("\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(819, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "929ca91e643e440da68d6e3daf299231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 28 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.returnUrl);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(865, 8, true);
            WriteLiteral("\n\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(873, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a89a51ce26542b0b873a730c5bf99b1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 30 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.cellphone);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(937, 83, true);
            WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\"form-group\" id=\"divCode\" style=\"display:none\">\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1020, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39d6ab6f00da4a7595a008a4351428eb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 33 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.code);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1098, 88, true);
            WriteLiteral("\n\t\t\t\t\t\t<span id=\"codCk\" class=\"text-danger\" hidden>کد تایید را وارد نمایید</span>\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1186, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8836e0074ebd41a8aa50667cba3d4fb3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 35 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.code);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1245, 44, true);
            WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\"form-group\">\n\n");
            EndContext();
#line 39 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
                          
							if (Model.isNoticeShortcut == 0 && Model.isAdverstitment==0)
							{

#line default
#line hidden
            BeginContext(1375, 88, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<button onclick=\"sendcode()\" id=\"Codebtn\" class=\"btn\">درخواست رمز عبور</button>\n");
            EndContext();
#line 43 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
							}
							else
							{

#line default
#line hidden
            BeginContext(1493, 98, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<button onclick=\"sendcode()\" id=\"Codebtn\" class=\"btn\">ثبت نام و درخواست رمز عبور</button>\n");
            EndContext();
#line 47 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
							}

						

#line default
#line hidden
            BeginContext(1609, 314, true);
            WriteLiteral(@"
						<button id=""Loginbtn"" onclick=""LoginUser()"" style=""display:none"" class=""btn"">ورود</button>
					</div>

					<button type=""button"" id=""btnretry"" onclick=""tryagain()"" class=""btn btn-color-reverse btn-full"" style=""display:none"">
						<span id=""countdown"" class=""timer""></span>
						تلاش مجدد
					</button>
");
            EndContext();
            BeginContext(2126, 37, true);
            WriteLiteral("\t\t\t\t\t<input id=\"shouldnoticeshortcut\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2163, "\"", 2194, 1);
#line 65 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
WriteAttributeValue("", 2171, Model.isNoticeShortcut, 2171, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2195, 55, true);
            WriteLiteral(" hidden />\n\t\t\t\t\t<input id=\"shouldAdverstitmentshortcut\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2250, "\"", 2280, 1);
#line 66 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
WriteAttributeValue("", 2258, Model.isAdverstitment, 2258, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2281, 933, true);
            WriteLiteral(@" hidden />


					
				</div>

			</div>
		</div>
	</section>
</section>
<div class=""modal fade"" id=""ErrorModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog modal-dialog-centered"" role=""document"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h4 class=""modal-title"">ارسال کد</h4>
				<div data-dismiss=""modal""></div>
			</div>
			<div class=""modal-body"">
				<p id=""errortext""></p>
			</div>
		</div>
	</div>
</div>
<div class=""modal fade"" id=""SuccessModals"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog modal-dialog-centered"" role=""document"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h4 class=""modal-title"">ارسال کد</h4>
				<div data-dismiss=""modal""></div>
			</div>
			<div class=""modal-body"">
				<p id=""successtxt""></p>
			</div>
		</div>
	</div>
</div>
");
            EndContext();
            BeginContext(3294, 512, true);
            WriteLiteral(@"<div class=""modal fade"" id=""reg-user"">
	<div class=""modal-dialog"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<button type=""button"" class=""close"" data-dismiss=""modal"" style=""margin-top: 7px; margin-left: 7px;"">
				</button>
				<h4 class=""modal-title"">سامانه گیسو</h4>
			</div>
			<div class=""modal-body"">
				<p id=""payText""></p>
			</div>
		</div>
		<!-- /.modal-content -->
	</div>
	<!-- /.modal-dialog -->
</div>
<script>
     window.onload = Load;
    function Load() {

        if ('");
            EndContext();
            BeginContext(3807, 30, false);
#line 123 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
        Write(Html.Raw(ViewBag.textRegister));

#line default
#line hidden
            EndContext();
            BeginContext(3837, 93, true);
            WriteLiteral("\'!=\"\") {\n            $(\'#reg-user\').modal(\'show\');\n            $(\"#reg-user #payText\").html(\'");
            EndContext();
            BeginContext(3931, 48, false);
#line 125 "C:\Users\Razmjoo\Desktop\Gisoo-main\Gisoo\Views\CustomerHome\Login.cshtml"
                                     Write(Html.Raw(ViewBag.textRegister.Replace("-", " ")));

#line default
#line hidden
            EndContext();
            BeginContext(3979, 4701, true);
            WriteLiteral(@"');
            $(""#Loginbtn"").show();
            $(""#btnretry"").show();
            $(""#divCode"").show();
            $(""#Codebtn"").hide();
        }
    }
</script>
<script>
	var seconds = 30;

	function sendcode() {
		var fd = new FormData();
		fd.append(""cellphone"", $('#cellphone').val());
		$.ajax({
			type: ""POST"",
			url: ""../CustomerHome/SignInConfirmCode"",
			data: fd,
			dataType: ""json"",
			contentType: false,
			processData: false,
			success: function (response) {
				if (response.success == false) {
					$(""#errortext"").text(response.responseText);
					$('#ErrorModal').modal('show');
				}
				else {
					$(""#Loginbtn"").show();
					$(""#btnretry"").show();
					$(""#divCode"").show();
					$(""#Codebtn"").hide();
				}
			},
			error: function (response) {

			}
		});
	}
	function tryagain() {
		seconds = 30;
		$(""#btnretry"").prop(""disabled"", true);
		$('#countdown').attr(""hidden"", false);

		countdown();

		PostAjaxtryagain();
	}
	function PostAjaxtryagain() {
		var fd = new FormData();
		fd.appen");
            WriteLiteral(@"d(""cellphone"", $('#cellphone').val());
		$.ajax({
			type: ""POST"",
			url: ""../CustomerHome/SignInConfirmCode"",
			data: fd,
			dataType: ""json"",
			contentType: false,
			processData: false,
			success: function (response) {
				if (response.success == false) {
					$(""#errortext"").text(response.responseText);
					$('#ErrorModal').modal('show');
				}
				if (response.success == true) {
					$(""#successtxt"").text(""پیامک مجددا ارسال شد"");
					$('#SuccessModals').modal('show');
				}
			},
			error: function (response) {

			}
		});
	}
	function secondPassed() {
		var minutes = Math.floor(seconds / 60);
		var remainingSeconds = seconds % 60;
		if (remainingSeconds < 10) {
			remainingSeconds = ""0"" + remainingSeconds;
		}
		document.getElementById('countdown').innerHTML = minutes + "":"" + remainingSeconds;
		if (seconds == 0) {
			$(""#btnretry"").prop(""disabled"", false);
			$('#countdown').attr(""hidden"", true);
		}
	}
	$(""#code"").change(function () {
		$(""#codCk"").attr(""hidden"", ""hidden"");
	});


	function Logi");
            WriteLiteral(@"nUser() {
		if ($('#code').val() == """") {
			$(""#codCk"").removeAttr(""hidden"");
		}
		else {

		var fd = new FormData();
		fd.append(""cellphone"", $('#cellphone').val());
		fd.append(""code"", $('#code').val());
		fd.append(""returnUrl"", $('#returnUrl').val());
		fd.append(""shouldnoticeshortcut"", $('#shouldnoticeshortcut').val());
		fd.append(""shouldAdverstitmentshortcut"", $('#shouldAdverstitmentshortcut').val());


		
		$.ajax({
			type: ""POST"",
			url: ""../CustomerHome/SignIn"",
			data: fd,
			dataType: ""json"",
			contentType: false,
			processData: false,
			success: function (response) {
				if (response.success == false) {
					$(""#errortext"").text(response.responseText);
					$('#ErrorModal').modal('show');
				}
				else {

					if (response.returnUrl != null && response.returnUrl != """") {
						window.location.href = response.returnUrl;
					}
					else {
						if (response.roleNameEn == ""SalonOwner"")
							window.location.href = '/CustomerHome/SalonOwner?isNoticeShortcut=' + response.hasnoticeshortcut + ");
            WriteLiteral(@"'&isadverstitmentShortcut=' + response.hasadverstitmentshortcut + '';
						if (response.roleNameEn == ""HairStylist"")
							window.location.href = '/CustomerHome/HairStylist?isNoticeShortcut=' + response.hasnoticeshortcut + '&isadverstitmentShortcut=' + response.hasadverstitmentshortcut + '';
						if (response.roleNameEn == ""Store"")
							window.location.href = '/CustomerHome/Store?isNoticeShortcut=' + response.hasnoticeshortcut + '&isadverstitmentShortcut=' + response.hasadverstitmentshortcut + '';
						if (response.roleNameEn == ""Academy"")
							window.location.href = '/CustomerHome/Academy?isNoticeShortcut=' + response.hasnoticeshortcut + '&isadverstitmentShortcut=' + response.hasadverstitmentshortcut + '';
                        if (response.roleNameEn == ""Mentor"")
                            window.location.href = '/CustomerHome/Mentor?isNoticeShortcut=' + response.hasnoticeshortcut + '&isadverstitmentShortcut=' + response.hasadverstitmentshortcut + '';
						if (response.roleNameEn == ""Student"")
	");
            WriteLiteral(@"						window.location.href = '/CustomerHome/Student?isNoticeShortcut=' + response.hasnoticeshortcut + '&isadverstitmentShortcut=' + response.hasadverstitmentshortcut + '';
						if (response.roleNameEn == ""Member"")
							window.location.href = '/CustomerHome/Member?isNoticeShortcut=' + response.hasnoticeshortcut + '&isadverstitmentShortcut=' + response.hasadverstitmentshortcut + '';
					}
				}
			},
			error: function (response) {

			}
		});
		}
	}
	function countdown() {
		secondPassed();
		if (seconds != 0) {
			seconds--;
			countdownTimer = setTimeout('countdown()', 1000);
		}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gisoo.ViewModel.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
