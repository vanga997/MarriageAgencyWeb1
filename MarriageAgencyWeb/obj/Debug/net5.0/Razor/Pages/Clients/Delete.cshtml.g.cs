#pragma checksum "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b54d33e5f7669c8c81960c353eb381cd1e247ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MarriageAgencyWeb.Pages.Clients.Pages_Clients_Delete), @"mvc.1.0.razor-page", @"/Pages/Clients/Delete.cshtml")]
namespace MarriageAgencyWeb.Pages.Clients
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
#line 1 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\_ViewImports.cshtml"
using MarriageAgencyWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b54d33e5f7669c8c81960c353eb381cd1e247ff", @"/Pages/Clients/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f815a0acb30fd9e43fddadf232681dd1e88f28", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>??????????????</h1>\r\n\r\n<h3>???? ?????????????? ?????? ???????????? ?????????????? ?????????????</h3>\r\n<div>\r\n    <h4>????????????</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Passport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Passport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.FamilyStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.FamilyStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.InfoAboutPartner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.InfoAboutPartner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.NumberOfChild));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.NumberOfChild));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.BadHabbits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.BadHabbits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Hobbies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Hobbies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.ZodiacId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.ZodiacId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Nationality.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Relation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Relation.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Client.Service));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Client.Service.ServiceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b54d33e5f7669c8c81960c353eb381cd1e247ff16420", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b54d33e5f7669c8c81960c353eb381cd1e247ff16687", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 126 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\Clients\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Client.ClientId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b54d33e5f7669c8c81960c353eb381cd1e247ff18487", async() => {
                    WriteLiteral("??????????");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarriageAgencyWeb.Pages_Clients.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarriageAgencyWeb.Pages_Clients.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarriageAgencyWeb.Pages_Clients.DeleteModel>)PageContext?.ViewData;
        public MarriageAgencyWeb.Pages_Clients.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
