#pragma checksum "D:\Source\.Net\NWEB.Practice.T04.ThuyNT130\NWEB.Practice.T04\Views\Request\Request.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "535b72fd9022f13a460ba5c26d785e026ff952b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Request), @"mvc.1.0.view", @"/Views/Request/Request.cshtml")]
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
#line 1 "D:\Source\.Net\NWEB.Practice.T04.ThuyNT130\NWEB.Practice.T04\Views\_ViewImports.cshtml"
using NWEB.Practice.T04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Source\.Net\NWEB.Practice.T04.ThuyNT130\NWEB.Practice.T04\Views\_ViewImports.cshtml"
using NWEB.Practice.T04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"535b72fd9022f13a460ba5c26d785e026ff952b7", @"/Views/Request/Request.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1da0d53967d0cb3490abc7f412b265d8e2d638", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Request : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Source\.Net\NWEB.Practice.T04.ThuyNT130\NWEB.Practice.T04\Views\Request\Request.cshtml"
  
    ViewData["Title"] = "View Request";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "535b72fd9022f13a460ba5c26d785e026ff952b74074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""content"">
    <!-- Begin Page Content -->
    <div class=""container-fluid"">

        <!-- Page Heading -->
        <h1 class=""h1 text-center mb-2 text-gray-800"">View Request</h1>
        <div class=""h3 mb-2 row text-right"">
            <div class=""col-md-12 col-lg-12"">
                <a");
            BeginWriteAttribute("href", " href=\"", 448, "\"", 494, 1);
#nullable restore
#line 14 "D:\Source\.Net\NWEB.Practice.T04.ThuyNT130\NWEB.Practice.T04\Views\Request\Request.cshtml"
WriteAttributeValue("", 455, Url.Action("CreateRequest", "Request"), 455, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-icon-split"">
                    <span class=""icon text-white-50"">
                        <i class=""fas fa-plus""></i>
                    </span>
                    <span class=""text"">Create Request</span>
                </a>
            </div>
        </div>

        <!-- DataTales Example -->
        <div class=""card shadow mb-4"">
            <div class=""card-body"">
");
            WriteLiteral(@"                <table class=""table table-bordered"" id=""monthPlanningTbl"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th data-orderable=""false"">Student Name</th>
                            <th data-orderable=""false"">Class Name</th>
                            <th data-orderable=""false"">Title</th>
                            <th data-orderable=""false"">Leave Type</th>
                            <th data-orderable=""false"">Reason For Leave</th>
                            <th data-orderable=""false"">Status</th

                        </tr>
                    </thead>
                    <tfoot>
                    </tfoot>
                </table>
            </div>
        </div>
    </div>
    <!-- /.container-fluid -->
</div>
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""");
            WriteLiteral(@"modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Notification</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">Do you want to delete?</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">No</button>
                <a class=""btn btn-danger"" onclick=""DeleteRequest()"">Yes</a>
            </div>
        </div>
    </div>
</div>

<script>
    var table = undefined;
    $(document).ready(function () {
        loadTable();
        $('#searchValue').keypress(function (e) {
            if (e.which == 13) {
                reloadWithPageOne();
            }
        });
    });
    function reloadWithPageOne() {
        if (table != undefined && table.api().ajax != und");
            WriteLiteral(@"efined)
            table.api().ajax.reload(null, true);
    }
    function reload() {
        if (table != undefined && table.api().ajax != undefined)
            table.api().ajax.reload(null,false);
    }
    function loadTable() {
        table = $('#monthPlanningTbl').dataTable({
            ""oLanguage"": {
                ""sEmptyTable"": ""Empty""
            },
            ""language"": {
                ""paginate"": {
                    ""previous"": ""Previous"",
                    ""next"": ""Next""
                }
            },
            searching: false,
            paging: true,
            lengthChange: false,
            ordering: true,
            filter: false,
            destroy: true,
            orderMulti: false,
            serverSide: true,
            processing: true,
            lengthChange: false,
            ""bSort"": false,
            ajax: function (data, callback, settings) {
                data.searchValue = $('#searchValue').val();
                post");
            WriteLiteral("Table(\"");
#nullable restore
#line 116 "D:\Source\.Net\NWEB.Practice.T04.ThuyNT130\NWEB.Practice.T04\Views\Request\Request.cshtml"
                      Write(Url.Action("GetListRequest", "Request"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", data, callback);
            },
            ""columns"": [
                {
                    ""class"": ""action"",
                    ""render"": function (data, row, full) {
                        return ""<a class='' title='Sửa' onclick=DetailRequest('"" + full.id + ""'); >""+ full.studentName + ""</a>"";
                    }
                },
                { ""data"": ""class"", ""name"": ""Class"", ""class"": ""class"" },
                { ""data"": ""title"", ""name"": ""Title"", ""class"": ""title"" },
                { ""data"": ""leaveType"", ""name"": ""LeaveType"", ""class"": ""leaveType"" },
                { ""data"": ""reasonForLeave"", ""name"": ""ReasonForLeave"", ""class"": ""reasonForLeave"" },
                {
                    ""class"": ""action"",
                    ""render"": function (data, row, full) {
                        if(full.status == 2){
                            return ""<td class=''>Approve</td>"";
                        }else if(full.status == 3){
                            return ""<td class=''>Cance");
            WriteLiteral(@"l</td>"";
                        }else if(full.status == 4){
                            return ""<td class=''>Reject</td>"";
                        }else {
                            return ""<td class=''>Submited</td>"";
                        }
                    }
                }

            ]
        });
    }

    function openConfirmDelete(id) {
        deleteId = id;
    }

    function DeleteRequest() {
        var formData = new FormData();
        formData.append(""Id"", deleteId);
        formData.append(""__RequestVerificationToken"", _token);
        postAjax('");
#nullable restore
#line 156 "D:\Source\.Net\NWEB.Practice.T04.ThuyNT130\NWEB.Practice.T04\Views\Request\Request.cshtml"
             Write(Url.Action("DeleteRequest"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', formData, function (data) {
            $('#deleteModal').modal(""hide"");
            reload();
        });
    }

    function DetailRequest(id) {
        location.href = '/request-detail' + ""/"" + id;
    }
    function UpdateRequest(id) {
        location.href = '/update-request' + ""/"" + id;
    }
</script>
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
