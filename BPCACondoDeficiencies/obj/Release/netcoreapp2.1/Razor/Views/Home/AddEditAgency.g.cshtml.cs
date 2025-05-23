#pragma checksum "C:\Bpca\BPCA latest\Latest BPCA-02112023\Latest-rollback\BPCAGit\BPCACondoDeficiencies\Views\Home\AddEditAgency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "772c58b393a2c109b9cdd9f1fbdc8e0b9a33130a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddEditAgency), @"mvc.1.0.view", @"/Views/Home/AddEditAgency.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddEditAgency.cshtml", typeof(AspNetCore.Views_Home_AddEditAgency))]
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
#line 1 "C:\Bpca\BPCA latest\Latest BPCA-02112023\Latest-rollback\BPCAGit\BPCACondoDeficiencies\Views\_ViewImports.cshtml"
using BPCACondoDeficiencies;

#line default
#line hidden
#line 2 "C:\Bpca\BPCA latest\Latest BPCA-02112023\Latest-rollback\BPCAGit\BPCACondoDeficiencies\Views\_ViewImports.cshtml"
using BPCACondoDeficiencies.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772c58b393a2c109b9cdd9f1fbdc8e0b9a33130a", @"/Views/Home/AddEditAgency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8fbd9faa897a3de153447734863bc8f11e1a8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddEditAgency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Bpca\BPCA latest\Latest BPCA-02112023\Latest-rollback\BPCAGit\BPCACondoDeficiencies\Views\Home\AddEditAgency.cshtml"
  
    ViewData["Title"] = "Add/Edit Agency";

#line default
#line hidden
            BeginContext(51, 11974, true);
            WriteLiteral(@"
<script>
    $(document).ready
        (function () {
            checkSession();
            checkAdmin();
            loadAgencies();
        });

    function loadAgencies() {
        $.ajax(
            {
                type: 'GET',
                url: '/Home/GetAgencies',
                cache: false,
                dataType: ""json"",
                contentType: ""application/json; charset=utf-8"",
                success: successCallback,
                error: errorCallback()
            });
    };

    function successCallback(data) {

        $(""#agencyList"").igGrid({
            autoGenerateColumns: false,
            renderCheckboxes: false,
            primaryKey: ""AgencyGuid"",
            caption: ""Agencies"",
            columns:
                [
                    { headerText: ""AgencyGuid"", key: ""AgencyGuid"", dataType: ""string"", width: ""0%"" },
                    { headerText: ""Agency Code"", key: ""AgencyCode"", dataType: ""string"", width: ""7%"" },
             ");
            WriteLiteral(@"       { headerText: ""Agency"", key: ""AgencyName"", dataType: ""string"", width: ""20%"" },
                    { headerText: ""Address 1"", key: ""Add1"", dataType: ""string"", width: ""20%"" },
                    { headerText: ""Address 2"", key: ""Add2"", dataType: ""string"", width: ""0%"" },
                    { headerText: ""City"", key: ""City"", dataType: ""string"", width: ""10%"" },
                    { headerText: ""State"", key: ""State"", dataType: ""string"", width: ""10%"" },
                    { headerText: ""Zip Code"", key: ""Zip"", dataType: ""string"", width: ""0%"" },
                    { headerText: ""Contact"", key: ""Contact"", dataType: ""string"", width: ""10%"" },
                    { headerText: ""Phone"", key: ""Phone"", dataType: ""string"", width: ""0%"" },
                    { headerText: ""Fax"", key: ""Fax"", dataType: ""string"", width: ""0%"" },
                    {
                        headerText: """",
                        key: ""Delete"",
                        unbound: true,
                        template: ""<inpu");
            WriteLiteral(@"t type='image' src='/images/delete.png' onclick='deleteAgency(${AgencyGuid})' />"",
                        width: ""5%"",
                        columnCssClass: ""deleteAlign""
                    }
                ],
            dataSource: data,
            autofitLastColumn: false,
            dataSourceType: ""json"",
            responseDataKey: ""results"",
            width: ""100%"",
            tabIndex: 1,
            features: [
                {
                    name: ""Selection"",
                    mode: ""row"",
                    multipleSelection: false
                },
                {
                    name: ""Sorting""
                },
                {
                    name: ""Updating"",
                    locale: {
                        addRowLabel: ""Add new agency..."",
                        rowEditDialogCaptionLabel: ""Add/Edit Agency""
                    },
                    enableAddRow: true,
                    enableUpdateRow: true,
               ");
            WriteLiteral(@"     enableDeleteRow: false,
                    editRowEnding: function (evt, ui) {
                        var an = ui.values['AgencyName'];
                        var ac = ui.values['AgencyCode'];
                        var add1 = ui.values['Add1'];
                        var add2 = ui.values['Add2'];
                        var ct = ui.values['City'];
                        var st = ui.values['State'];
                        var zip = ui.values['Zip'];
                        var cn = ui.values['Contact'];
                        var ph = ui.values['Phone'];
                        var fx = ui.values['Fax'];

                        if (ui.update == true && ui.rowAdding == false) {
                            var ag = ui.rowID;
                            $.ajax(
                                {
                                    async: false,
                                    type: 'POST',
                                    url: '/Home/UpdateAgency',
                        ");
            WriteLiteral(@"            cache: false,
                                    data: {
                                        agencyGuid: ag, agencyCode: ac, agencyName: an, address1: add1, address2: add2,
                                        city: ct, state: st, zip: zip, contact: cn, phone: ph, fax: fx
                                    },
                                    dataType: ""json"",
                                    success: function()
                                    { },
                                    error: function ()
                                    { }
                                });
                        }
                        if (ui.update == true && ui.rowAdding == true) {
                            $.ajax(
                                {
                                    async: false,
                                    type: 'POST',
                                    url: '/Home/InsertAgency',
                                    cache: false,
         ");
            WriteLiteral(@"                           data: {
                                        agencyCode: ac, agencyName: an, address1: add1, address2: add2,
                                        city: ct, state: st, zip: zip, contact: cn, phone: ph, fax: fx
                                    },
                                    dataType: ""json"",
                                    success: function () { },
                                    error: function () { }
                                });
                        }

                        loadAgencies();
                    },
                    columnSettings: [
                        {
                            columnKey: ""Delete"",
                            readOnly: true
                        },
                    ],
                    startEditTriggers: ""click"",
                    editMode: ""dialog"",
                    rowEditDialogOptions: {
                        width: 700,
                        height: 700,
        ");
            WriteLiteral(@"                dialogTemplateSelector: ""#dialogTemplate"",
                        editorsTemplateSelector: ""#editorsTemplate"",
                        containment: ""ui"",
                        animationDuration: 400,
                        showReadonlyEditors: false
                    },
                },
                {
                    name: 'Hiding',
                    columnSettings:
                        [
                            {
                                columnKey: ""AgencyGuid"",
                                allowHiding: false,
                                editorType: ""text"",
                                readOnly: true,
                                defaultValue: -1,
                                hidden: true
                            },
                            {
                                columnKey: ""AgencyCode"",
                                editorType: ""text"",
                                allowHiding: false,
                 ");
            WriteLiteral(@"               readOnly: false,
                                defaultValue: '',
                                hidden: false,
                                required: true
                            },
                            {
                                columnKey: ""AgencyName"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: true,
                                defaultValue: '',
                                hidden: false,
                                required: true
                            },
                            {
                                columnKey: ""Add1"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: true,
                                defaultValue: '',
                                hidden: false,
                                required: true
    ");
            WriteLiteral(@"                        },
                            {
                                columnKey: ""Add2"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: true,
                                defaultValue: '',
                                hidden: false,
                                required: false
                            },
                            {
                                columnKey: ""City"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: true,
                                defaultValue: 'New York',
                                hidden: false,
                                required: true
                            },
                            {
                                columnKey: ""State"",
                                editorType: ""text"",
                ");
            WriteLiteral(@"                allowHiding: false,
                                readOnly: true,
                                defaultValue: 'NY',
                                hidden: false,
                                required: true
                            },
                            {
                                columnKey: ""Zip"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: true,
                                defaultValue: '',
                                hidden: false,
                                required: true
                            },
                            {
                                columnKey: ""Contact"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: false,
                                defaultValue: '',
                                hidden: false,
");
            WriteLiteral(@"                                required: true
                            },
                            {
                                columnKey: ""Phone"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: true,
                                defaultValue: '555-555-5555',
                                hidden: false,
                                required: true
                            },
                            {
                                columnKey: ""Fax"",
                                editorType: ""text"",
                                allowHiding: false,
                                readOnly: true,
                                defaultValue: '',
                                hidden: false,
                                required: false
                            }
                        ]
                }
            ]

        });
    };

    function");
            WriteLiteral(@" errorCallback() {
    };

    function deleteAgency(agencyGuid) {
        $.ajax(
            {
                async: true,
                type: 'POST',
                url: '/Home/DeleteAgency',
                data: { agencyGuid: agencyGuid },
                cache: false,
                success: function () {
                    loadAgencies();
                }
            });
    }
</script>

<style>
    td.edge {
        width: 17%;
        vertical-align: top;
    }

    #agencyList tr td {
        white-space: nowrap;
    }

    input:hover {
        color: initial;
    }

    .deleteAlign {
        text-align: right !important;
    }
</style>

<html>
");
            EndContext();
            BeginContext(12025, 816, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36939360a4bd47439091383703775c3a", async() => {
                BeginContext(12031, 803, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Add/Edit Agency</title>
    <script id=""dialogTemplate"" type=""text/html"">
        <div style=""float: left; width: 100%"">
            <strong>${Name}</strong><br />
            <table style=""width: 100%;"">
                <colgroup>
                    <col style=""width: 30%;"" />
                    <col style=""width: 200%;"" />
                </colgroup>
                <tbody data-render-tmpl=""true""></tbody>
            </table>
        </div>
    </script>

    <script id=""editorsTemplate"" type=""text/html"">
        <tr>
            <td style=""color: black;"">${headerText}</td>
            <td><input data-editor-for-${key}=""true"" style=""color: black; width: 1000px;"" /></td>
        </tr>
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(12841, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(12843, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32ce7324d9ab4e1e973d12c3f9c81ed0", async() => {
                BeginContext(12849, 115, true);
                WriteLiteral("\r\n\r\n    <div class=\"page-content\" style=\"padding-top:40px;\">\r\n        <table id=\"agencyList\"></table>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(12971, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
