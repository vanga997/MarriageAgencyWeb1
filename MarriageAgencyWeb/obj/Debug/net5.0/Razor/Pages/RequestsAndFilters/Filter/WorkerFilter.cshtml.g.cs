#pragma checksum "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\RequestsAndFilters\Filter\WorkerFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef56ab9d9f09ef71630dcc860a4aab4357c50b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MarriageAgencyWeb.Pages.RequestsAndFilters.Filter.Pages_RequestsAndFilters_Filter_WorkerFilter), @"mvc.1.0.razor-page", @"/Pages/RequestsAndFilters/Filter/WorkerFilter.cshtml")]
namespace MarriageAgencyWeb.Pages.RequestsAndFilters.Filter
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef56ab9d9f09ef71630dcc860a4aab4357c50b33", @"/Pages/RequestsAndFilters/Filter/WorkerFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f815a0acb30fd9e43fddadf232681dd1e88f28", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RequestsAndFilters_Filter_WorkerFilter : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Отдел кадров</h1>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 10 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\RequestsAndFilters\Filter\WorkerFilter.cshtml"
               Write(Html.DisplayNameFor(model => model.Worker[0].FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 13 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\RequestsAndFilters\Filter\WorkerFilter.cshtml"
               Write(Html.DisplayNameFor(model => model.Worker[0].PositionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\RequestsAndFilters\Filter\WorkerFilter.cshtml"
             foreach (var item in Model.Worker)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\RequestsAndFilters\Filter\WorkerFilter.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\RequestsAndFilters\Filter\WorkerFilter.cshtml"
                   Write(Model.Position.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\79686\MarriageAgencyWeb\MarriageAgencyWeb\Pages\RequestsAndFilters\Filter\WorkerFilter.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarriageAgencyWeb.Pages.RequestsAndFilters.Filter.WorkerFilterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarriageAgencyWeb.Pages.RequestsAndFilters.Filter.WorkerFilterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MarriageAgencyWeb.Pages.RequestsAndFilters.Filter.WorkerFilterModel>)PageContext?.ViewData;
        public MarriageAgencyWeb.Pages.RequestsAndFilters.Filter.WorkerFilterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
