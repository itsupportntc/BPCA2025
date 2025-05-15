namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_RollbackSubReport.
    /// </summary>
    partial class DeficiencyReport_RollbackSubReport
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DeficiencyReport_RollbackSubReport));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.reportHeader1 = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
            this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.reportFooter1 = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
            this.labelPaybacksDue = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.textBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelPaybacksDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
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
            this.textBox2});
            this.detail.Height = 0.1770834F;
            this.detail.Name = "detail";
            // 
            // textBox1
            // 
            this.textBox1.DataField = "invoiceDate";
            this.textBox1.Height = 0.15F;
            this.textBox1.Left = 0.082F;
            this.textBox1.Name = "textBox1";
            this.textBox1.OutputFormat = resources.GetString("textBox1.OutputFormat");
            this.textBox1.Style = "font-family: Tahoma; font-size: 8pt";
            this.textBox1.Text = "textBox1";
            this.textBox1.Top = 0F;
            this.textBox1.Width = 0.6000001F;
            // 
            // textBox2
            // 
            this.textBox2.CurrencyCulture = new System.Globalization.CultureInfo("en-US");
            this.textBox2.DataField = "diffAmount";
            this.textBox2.Height = 0.15F;
            this.textBox2.Left = 1.603F;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "font-family: Tahoma; font-size: 8pt; text-align: right";
            this.textBox2.Text = "textBox1";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.315F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label1});
            this.reportHeader1.Height = 0.1770833F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // label1
            // 
            this.label1.Height = 0.2F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.08200002F;
            this.label1.Name = "label1";
            this.label1.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-decoration: underlin" +
    "e";
            this.label1.Text = "Rollbacks";
            this.label1.Top = 0F;
            this.label1.Width = 1F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.labelPaybacksDue,
            this.textBox3,
            this.line1,
            this.line2,
            this.line3});
            this.reportFooter1.Height = 0.2291667F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // labelPaybacksDue
            // 
            this.labelPaybacksDue.Height = 0.17F;
            this.labelPaybacksDue.HyperLink = null;
            this.labelPaybacksDue.Left = 0.08200002F;
            this.labelPaybacksDue.Name = "labelPaybacksDue";
            this.labelPaybacksDue.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-decoration: none";
            this.labelPaybacksDue.Text = "Rollbacks Total:";
            this.labelPaybacksDue.Top = 0F;
            this.labelPaybacksDue.Width = 1.521F;
            // 
            // textBox3
            // 
            this.textBox3.CurrencyCulture = new System.Globalization.CultureInfo("en-US");
            this.textBox3.DataField = "diffAmount";
            this.textBox3.Height = 0.15F;
            this.textBox3.Left = 1.603F;
            this.textBox3.Name = "textBox3";
            this.textBox3.OutputFormat = resources.GetString("textBox3.OutputFormat");
            this.textBox3.Style = "font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align: right";
            this.textBox3.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal;
            this.textBox3.Text = "textBox1";
            this.textBox3.Top = 0F;
            this.textBox3.Width = 1.315F;
            // 
            // line1
            // 
            this.line1.Height = 0F;
            this.line1.Left = 1.918F;
            this.line1.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash;
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 0F;
            this.line1.Width = 1F;
            this.line1.X1 = 1.918F;
            this.line1.X2 = 2.918F;
            this.line1.Y1 = 0F;
            this.line1.Y2 = 0F;
            // 
            // line2
            // 
            this.line2.Height = 0F;
            this.line2.Left = 1.918F;
            this.line2.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash;
            this.line2.LineWeight = 1F;
            this.line2.Name = "line2";
            this.line2.Top = 0.16F;
            this.line2.Width = 1F;
            this.line2.X1 = 1.918F;
            this.line2.X2 = 2.918F;
            this.line2.Y1 = 0.16F;
            this.line2.Y2 = 0.16F;
            // 
            // line3
            // 
            this.line3.Height = 0F;
            this.line3.Left = 1.918F;
            this.line3.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 0.2F;
            this.line3.Width = 1F;
            this.line3.X1 = 1.918F;
            this.line3.X2 = 2.918F;
            this.line3.Y1 = 0.2F;
            this.line3.Y2 = 0.2F;
            // 
            // DeficiencyReport_RollbackSubReport
            // 
            this.MasterReport = false;
            this.PageSettings.Gutter = 0.1F;
            this.PageSettings.Margins.Bottom = 0.1F;
            this.PageSettings.Margins.Left = 0.1F;
            this.PageSettings.Margins.Right = 0.1F;
            this.PageSettings.Margins.Top = 0.1F;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 3F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
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
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelPaybacksDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.ReportHeader reportHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.ReportFooter reportFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox2;
        private GrapeCity.ActiveReports.SectionReportModel.Label label1;
        private GrapeCity.ActiveReports.SectionReportModel.Label labelPaybacksDue;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox3;
        private GrapeCity.ActiveReports.SectionReportModel.Line line1;
        private GrapeCity.ActiveReports.SectionReportModel.Line line2;
        private GrapeCity.ActiveReports.SectionReportModel.Line line3;
    }
}
