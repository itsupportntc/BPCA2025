namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for SectionReport1.
    /// </summary>
    partial class UnitListingReport
    {
        private GrapeCity.ActiveReports.SectionReportModel.PageHeader pageHeader;
        private GrapeCity.ActiveReports.SectionReportModel.Detail detail;
        private GrapeCity.ActiveReports.SectionReportModel.PageFooter pageFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitListingReport));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textRowNumber = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
            this.reportInfo2 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
            this.reportHeader1 = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
            this.imgLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
            this.label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.textBuildingAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.reportFooter1 = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
            this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
            this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
            this.textBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textBox5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBuildingAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Height = 0F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textRowNumber});
            this.detail.Height = 0.2F;
            this.detail.Name = "detail";
            // 
            // textBox1
            // 
            this.textBox1.DataField = "unitcode";
            this.textBox1.Height = 0.2F;
            this.textBox1.Left = 1.01F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Text = "textBox1";
            this.textBox1.Top = 0F;
            this.textBox1.Width = 1.995F;
            // 
            // textBox2
            // 
            this.textBox2.DataField = "pctci";
            this.textBox2.Height = 0.2F;
            this.textBox2.Left = 2.676F;
            this.textBox2.Name = "textBox2";
            this.textBox2.Style = "text-align: right";
            this.textBox2.Text = "textBox1";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.995F;
            // 
            // textBox3
            // 
            this.textBox3.DataField = "Owner";
            this.textBox3.Height = 0.2F;
            this.textBox3.Left = 5.302F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Text = "textBox1";
            this.textBox3.Top = 0F;
            this.textBox3.Width = 2.578001F;
            // 
            // textRowNumber
            // 
            this.textRowNumber.DataField = "unitcode";
            this.textRowNumber.Height = 0.12F;
            this.textRowNumber.Left = 0.437F;
            this.textRowNumber.Name = "textRowNumber";
            this.textRowNumber.Style = "font-size: 7pt; text-align: right";
            this.textRowNumber.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Count;
            this.textRowNumber.SummaryGroup = "groupHeader1";
            this.textRowNumber.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All;
            this.textRowNumber.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
            this.textRowNumber.Text = "textBox4";
            this.textRowNumber.Top = 0.04F;
            this.textRowNumber.Width = 0.479F;
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.reportInfo1,
            this.reportInfo2});
            this.pageFooter.Height = 0.2395833F;
            this.pageFooter.Name = "pageFooter";
            // 
            // reportInfo1
            // 
            this.reportInfo1.FormatString = "Printed On: {RunDateTime:MM/dd/yyyy}";
            this.reportInfo1.Height = 0.14F;
            this.reportInfo1.Left = 0.302F;
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Style = "font-size: 8pt";
            this.reportInfo1.Top = 0.05F;
            this.reportInfo1.Width = 2.042F;
            // 
            // reportInfo2
            // 
            this.reportInfo2.FormatString = "Unit Listing: Page {PageNumber} of {PageCount}";
            this.reportInfo2.Height = 0.14F;
            this.reportInfo2.Left = 5.203F;
            this.reportInfo2.Name = "reportInfo2";
            this.reportInfo2.Style = "font-size: 8pt; text-align: right";
            this.reportInfo2.Top = 0.05F;
            this.reportInfo2.Width = 2.677F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.imgLogo,
            this.label4,
            this.textBuildingAddress});
            this.reportHeader1.Height = 1F;
            this.reportHeader1.Name = "reportHeader1";
            this.reportHeader1.Format += new System.EventHandler(this.reportHeader1_Format);
            // 
            // imgLogo
            // 
            this.imgLogo.Height = 0.812F;
            this.imgLogo.HyperLink = null;
            this.imgLogo.ImageData = ((System.IO.Stream)(resources.GetObject("imgLogo.ImageData")));
            this.imgLogo.Left = 0.06699991F;
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch;
            this.imgLogo.Top = 0F;
            this.imgLogo.Width = 3.198F;
            // 
            // label4
            // 
            this.label4.Height = 0.2F;
            this.label4.HyperLink = null;
            this.label4.Left = 3.406F;
            this.label4.Name = "label4";
            this.label4.Style = "font-weight: bold; text-align: left; vertical-align: middle";
            this.label4.Text = "UNITS LISTING";
            this.label4.Top = 0F;
            this.label4.Width = 2.031F;
            // 
            // textBuildingAddress
            // 
            this.textBuildingAddress.Height = 1.021F;
            this.textBuildingAddress.Left = 3.406F;
            this.textBuildingAddress.Name = "textBuildingAddress";
            this.textBuildingAddress.Text = "textBox4";
            this.textBuildingAddress.Top = 0.18F;
            this.textBuildingAddress.Width = 2.031F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Height = 0F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label1,
            this.label2,
            this.label3});
            this.groupHeader1.Height = 0.2F;
            this.groupHeader1.Name = "groupHeader1";
            // 
            // label1
            // 
            this.label1.Height = 0.2F;
            this.label1.HyperLink = null;
            this.label1.Left = 1.01F;
            this.label1.Name = "label1";
            this.label1.Style = "font-weight: bold; text-decoration: underline";
            this.label1.Text = "Unit Code";
            this.label1.Top = 3.72529E-09F;
            this.label1.Width = 1F;
            // 
            // label2
            // 
            this.label2.Height = 0.2F;
            this.label2.HyperLink = null;
            this.label2.Left = 2.661F;
            this.label2.Name = "label2";
            this.label2.Style = "font-weight: bold; text-align: right; text-decoration: underline";
            this.label2.Text = "Common Interest Percent";
            this.label2.Top = 3.72529E-09F;
            this.label2.Width = 2.01F;
            // 
            // label3
            // 
            this.label3.Height = 0.2F;
            this.label3.HyperLink = null;
            this.label3.Left = 5.302F;
            this.label3.Name = "label3";
            this.label3.Style = "font-weight: bold; text-align: left; text-decoration: underline";
            this.label3.Text = "Current Title Owner";
            this.label3.Top = 0F;
            this.label3.Width = 2.578001F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.textBox4,
            this.textBox5});
            this.groupFooter1.Height = 0.2083333F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // textBox4
            // 
            this.textBox4.DataField = "pctci";
            this.textBox4.Height = 0.2F;
            this.textBox4.Left = 3.005F;
            this.textBox4.Name = "textBox4";
            this.textBox4.OutputFormat = resources.GetString("textBox4.OutputFormat");
            this.textBox4.Style = "font-weight: bold; text-align: right";
            this.textBox4.SummaryGroup = "groupHeader1";
            this.textBox4.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All;
            this.textBox4.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal;
            this.textBox4.Text = "textBox4";
            this.textBox4.Top = 0F;
            this.textBox4.Width = 1.666F;
            // 
            // textBox5
            // 
            this.textBox5.Height = 0.2F;
            this.textBox5.Left = 0.437F;
            this.textBox5.Name = "textBox5";
            this.textBox5.Style = "font-weight: bold";
            this.textBox5.Text = "Total  Common Interest Percent:";
            this.textBox5.Top = 0F;
            this.textBox5.Width = 2.255F;
            // 
            // UnitListingReport
            // 
            this.MasterReport = false;
            this.PageSettings.Margins.Bottom = 0.1F;
            this.PageSettings.Margins.Left = 0.1F;
            this.PageSettings.Margins.Right = 0.1F;
            this.PageSettings.Margins.Top = 0.1F;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.978667F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBuildingAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.ReportHeader reportHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.ReportFooter reportFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.Picture imgLogo;
        private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label2;
        private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label3;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox2;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox3;
        private GrapeCity.ActiveReports.SectionReportModel.Label label4;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBuildingAddress;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox4;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textRowNumber;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox5;
        private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
        private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo2;
    }
}
