#pragma checksum "C:\Users\wreye\Documents\Redsoft\BPCA\BPCACondoDeficiencies\BPCACondoDeficiencies\Views\Home\AddEditSuspendedDefaults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7746ce4a874c61fe55b17b54cbbaa9998492ea3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddEditSuspendedDefaults), @"mvc.1.0.view", @"/Views/Home/AddEditSuspendedDefaults.cshtml")]
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
#line 1 "C:\Users\wreye\Documents\Redsoft\BPCA\BPCACondoDeficiencies\BPCACondoDeficiencies\Views\_ViewImports.cshtml"
using BPCACondoDeficiencies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wreye\Documents\Redsoft\BPCA\BPCACondoDeficiencies\BPCACondoDeficiencies\Views\_ViewImports.cshtml"
using BPCACondoDeficiencies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7746ce4a874c61fe55b17b54cbbaa9998492ea3d", @"/Views/Home/AddEditSuspendedDefaults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8fbd9faa897a3de153447734863bc8f11e1a8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddEditSuspendedDefaults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/book_next.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/book_previous.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\wreye\Documents\Redsoft\BPCA\BPCACondoDeficiencies\BPCACondoDeficiencies\Views\Home\AddEditSuspendedDefaults.cshtml"
  
    ViewData["Title"] = "Add/Edit Suspended Defaults";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html>
<script type=""text/javascript"">
    var og = '00000000-0000-0000-0000-000000000000';
    var opts = {
        lines: 13, // The number of lines to draw
        length: 20, // The length of each line
        width: 10, // The line thickness
        radius: 30, // The radius of the inner circle
        corners: 1, // Corner roundness (0..1)
        rotate: 0, // The rotation offset
        direction: 1, // 1: clockwise, -1: counterclockwise
        color: '#000', // #rgb or #rrggbb or array of colors
        speed: 1, // Rounds per second
        trail: 60, // Afterglow percentage
        shadow: false, // Whether to render a shadow
        hwaccel: false, // Whether to use hardware acceleration
        className: 'spinner', // The CSS class to assign to the spinner
        zIndex: 2e9, // The z-index (defaults to 2000000000)
        top: 'auto', // Top position relative to parent in px
        left: 'auto' // Left position relative to parent in px
    };

    $(document).r");
            WriteLiteral(@"eady
        (function () {
            checkSession();
            checkAdmin();
            $(""#comboBuildings"").igCombo();
            $(""#comboUnits"").igCombo();
            loadBuildings();
        });

    function loadBuildings() {
        $.ajax(
            {
                type: 'GET',
                url: '/Home/GetBuildingList',
                cache: false,
                dataType: ""json"",
                contentType: ""application/json; charset=utf-8"",
                success: loadBuildingSuccess,
                error: loadBuildingsError()
            });
    }

    function loadBuildingsError() {

    }

    function loadBuildingSuccess(data) {
        $(""#comboBuildings"").igCombo({
            width: ""270px"",
            textKey: ""Name"",
            valueKey: ""BuildingGuid"",
            dataSource: jQuery.parseJSON(data),
            dataSourceType: ""json"",
            filteringType: ""local"",
            autoComplete: true,
            placeHolder: ""Select ");
            WriteLiteral(@"a building..."",
            dropDownOrientation: ""bottom""
        });
        $(""#comboBuildings"").on(""igcomboselectionchanged"", function (evt, ui) {
            var bg = $(""#comboBuildings"").igCombo(""value"");
            loadBuildingSelection(bg, true);
        });

        $(""#comboUnits"").igCombo();
    }

    function loadBuildingSelection(bg, async) {
        $.ajax(
        {
            type: 'GET',
            async: true,
            url: '/Home/GetUnitList',
            data: { buildingGuid: bg },
            dataType: ""json"",
            success: function (response) {
                getUnitList(response);
            },
            error: loadBuildingsError()
        });
    }
    function getUnitList(data) {
        $(""#comboUnits"").igCombo({
            width: ""270px"",
            textKey: ""unitcode"",
            valueKey: ""unitguid"",
            dataSource: jQuery.parseJSON(data),
            dataSourceType: ""json"",
            filteringType: ""local"",
          ");
            WriteLiteral(@"  autoComplete: true,
            placeHolder: ""Select a unit..."",
            dropDownOrientation: ""bottom""
        });
        $(""#comboUnits"").on(""igcomboselectionchanged"", function (evt, ui) {
            var ug = $(""#comboUnits"").igCombo(""value"");
            loadUnitSelection(ug);
        });
    }
    function loadUnitSelection(ug) {
        $.ajax(
        {
            type: 'GET',
            async: true,
            url: '/Home/GetAddEditSuspenedDefaultList',
            data: { unitGuid: ug },
            dataType: ""json"",
            success: function (response) {
                setSuspendedDefaultList(response);
                $('#modalSpinner').modal('hide');
            },
            error: loadBuildingsError()
        });
    }
    function setSuspendedDefaultList(data) {
        $.ig.checkboxMarkupClasses = ""ui-state-default ui-corner-all ui-igcheckbox-small"";
        $(""#gridOwners"").igGrid({
            key: ""Table"",
            width: ""100%"",
            da");
            WriteLiteral(@"taSource: jQuery.parseJSON(data),
            dataSourceType: ""json"",
            responseDataKey: ""Table"",
            autoGenerateColumns: false,
            autofitLastColumn: false,
            primaryKey: ""Trxid"",
            renderCheckboxes: true,
            autoCommit: true,
            columns: [
                { key: ""Trxid"", headerText: ""Employee ID"", dataType: ""number"", width: ""0%"", hidden: true },
                { key: ""OwnerGuid"", headerText: ""ownerGuid"", dataType: ""string"", width: ""0%"", hidden: true },
                { key: ""TitleName"", headerText: ""Title Name"", dataType: ""string"", width: ""15%"" },
                { key: ""TrxDate"", headerText: ""Date"", dataType: ""date"", width: ""20%"" },
                { key: ""BaseRent"", headerText: ""Base Rent"", dataType: ""number"", width: ""15%"", format: ""currency"" },
                { key: ""CivicFacility"", headerText: ""Civic"", dataType: ""number"", width: ""15%"", format: ""currency"" },
                { key: ""Supplemental"", headerText: ""Supplemental");
            WriteLiteral(@""", dataType: ""number"", width: ""15%"", format: ""currency"" },
                { key: ""PILOT"", headerText: ""PILOT"", dataType: ""number"", width: ""15%"", format: ""currency"" },
                { key: ""Suspended"", headerText: ""Suspended"", dataType: ""bool"", width: ""12%"" }
            ],
            features: [
                {
                    name: ""Updating"",
                    editMode: ""cell"",
                    startEditTriggers: ""click"",
                    editCellStarting: function (evt, ui) {
                        if (ui.columnKey === ""Suspended"" && $(evt.originalEvent.target).hasClass(""ui-icon-check"")) {
                            ui.value = !ui.value;
                        }
                    },
                    editCellEnded: function (evt, ui) {
                        if (ui.update || ui.rowAdding) {
                            $.ajax(
                                {
                                    type: 'POST',
                                    async: true,
    ");
            WriteLiteral(@"                                url: '/Home/SaveSuspendedTransactionState',
                                    data: { trxId: ui.rowID, suspendedValue: ui.value },
                                    dataType: ""json"",
                                    success: function () {
                                    },
                                    error: function () { }
                                });
                        }
                    },
                    enableAddRow: false,
                    enableUpdateRow: true,
                    enableDeleteRow: false,
                    columnSettings: [
                        {
                            columnKey: ""OwnerGuid"", editorOptions: { readOnly: true },
                            columnKey: ""Trxid"", editorOptions: { readOnly: true },
                            columnKey: ""TitleName"", editorOptions: { readOnly: true },
                            columnKey: ""TrxDate"", editorOptions: { readOnly: true },
           ");
            WriteLiteral(@"                 columnKey: ""CivicFacility"", editorOptions: { readOnly: true },
                            columnKey: ""Supplemental"", editorOptions: { readOnly: true },
                            columnKey: ""PILOT"", editorOptions: { readOnly: true },
                            columnKey: ""Suspended"", editorOptions: { readOnly: false, editorType: ""checkbox""}
                        }]
                },
                {
                    name: ""Sorting"",
                    type: ""local"",
                    mode: ""multi"",
                    persist: true
                },
                {
                    name: ""Filtering"",
                    type: ""local"",
                    persist: true,
                    columnSettings: [
                        { columnKey: ""OwnerGuid"", allowFiltering: false },
                        { columnKey: ""Trxid"", allowFiltering: false }
                    ]
                }
            ]
        });
        $(""#gridOwners"").on(""iggridcel");
            WriteLiteral(@"lclick"", function (evt, ui) {
            var val = $(""#gridOwners"").igGrid(""getCellValue"", ui.rowKey, ""Suspended"");
            val = !val;
            if (ui.colKey == ""Suspended"") {
                $.ajax(
                    {
                        type: 'POST',
                        async: true,
                        url: '/Home/SaveSuspendedTransactionState',
                        data: { trxId: ui.rowID, suspendedValue: val },
                        dataType: ""json"",
                        success: function () {
                        },
                        error: function () { }
                    });
            }
        });

    }

    function selectAll() {
        var rows = $(""#gridOwners"").igGrid(""allRows"");
        var rowId;
        var target = document.getElementById('searching_spinner_center');
        var spinner = new Spinner(opts).spin(target);
        $('#modalSpinner').modal('show');

        $.each(rows, function (index, row) {
            ");
            WriteLiteral(@"rowId = $(row).attr(""data-id"");
            $.ajax(
                {
                    type: 'POST',
                    async: true,
                    url: '/Home/SaveSuspendedTransactionState',
                    data: { trxId: rowId, suspendedValue: true },
                    dataType: ""json"",
                    success: function () {
                    },
                    error: function () { }
                });
        });
        var ug = $(""#comboUnits"").igCombo(""value"");
        loadUnitSelection(ug);
        
    }

    function unselectAll() {
        var rows = $(""#gridOwners"").igGrid(""allRows"");
        var rowId;
        var target = document.getElementById('searching_spinner_center');
        var spinner = new Spinner(opts).spin(target);
        $('#modalSpinner').modal('show');

        $.each(rows, function (index, row) {
            rowId = $(row).attr(""data-id"");
            $.ajax(
                {
                    type: 'POST',
              ");
            WriteLiteral(@"      async: true,
                    url: '/Home/SaveSuspendedTransactionState',
                    data: { trxId: rowId, suspendedValue: false },
                    dataType: ""json"",
                    success: function () {
                    },
                    error: function () { }
                });
        });
        var ug = $(""#comboUnits"").igCombo(""value"");
        loadUnitSelection(ug);
    }
</script>

    <html>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7746ce4a874c61fe55b17b54cbbaa9998492ea3d15813", async() => {
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"width=device-width\" />\r\n        <title>Add/Edit Suspended Defaults</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7746ce4a874c61fe55b17b54cbbaa9998492ea3d16911", async() => {
                WriteLiteral(@"
        <table style=""width: 100%"">
            <tr>
                <td><h4>Building:</h4></td>
                <td rowspan=""4"" align=""right"">
                    <div id=""selectOptions"">
                        <table>
                            <tr><td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7746ce4a874c61fe55b17b54cbbaa9998492ea3d17440", async() => {
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
                WriteLiteral(" <a href=\"#\" onclick=\"selectAll();\">Select All</a></td></tr>\r\n                            <tr><td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7746ce4a874c61fe55b17b54cbbaa9998492ea3d18627", async() => {
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
                WriteLiteral(@" <a href=""#"" onclick=""unselectAll();"">Un-Select All </a></td></tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan=""1"">
                    <div id=""comboBuildings""></div>
                </td>
            </tr>
            <tr><td colspan=""1""><h4>Unit:</h4></td></tr>
            <tr>
                <td colspan=""1"">
                    <div id=""comboUnits""></div>
                </td>
            </tr>
            <tr>
                <td colspan=""2"">
                    <div id=""gridOwners""></div>
                </td>
            </tr>
        </table>
        <div id=""modalSpinner"" class=""modal fade"" tabindex=""-1"" role=""dialog"" data-keyboard=""false"" data-backdrop=""static"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
");
                WriteLiteral(@"                    <div class=""modal-body"">
                        <br>
                        <br>
                        <br>
                        <br>
                        <br>
                        <br>
                        <span id=""searching_spinner_center"" style=""position:fixed; left:50%;top:50%;""></span>
                    </div>
                    <div class=""modal-footer"" style=""text-align: center""></div>
                </div>
            </div>
        </div>
        </div>
    ");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
