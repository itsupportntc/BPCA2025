namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for BPCAInvoiceAdjustments.
    /// </summary>
    partial class BPCAInvoiceAdjustments
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BPCAInvoiceAdjustments));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.subReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
            this.subReport2 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label1});
            this.pageHeader.Name = "pageHeader";
            // 
            // label1
            // 
            this.label1.Height = 0.2F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.167F;
            this.label1.Name = "label1";
            this.label1.Style = "font-weight: bold";
            this.label1.Text = "Adjustments";
            this.label1.Top = 0.05F;
            this.label1.Width = 1F;
            // 
            // detail
            // 
            this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.subReport1,
            this.subReport2});
            this.detail.Height = 0.4791666F;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // subReport1
            // 
            this.subReport1.CloseBorder = false;
            this.subReport1.Height = 0.208F;
            this.subReport1.Left = 0F;
            this.subReport1.Name = "subReport1";
            this.subReport1.Report = null;
            this.subReport1.ReportName = "subReport1";
            this.subReport1.Top = 0F;
            this.subReport1.Width = 6.427001F;
            // 
            // subReport2
            // 
            this.subReport2.CloseBorder = false;
            this.subReport2.Height = 0.208F;
            this.subReport2.Left = 0F;
            this.subReport2.Name = "subReport2";
            this.subReport2.Report = null;
            this.subReport2.ReportName = "subReport2";
            this.subReport2.Top = 0.208F;
            this.subReport2.Width = 6.427001F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // BPCAInvoiceAdjustments
            // 
            this.MasterReport = false;
            this.PageSettings.Margins.Bottom = 0.1F;
            this.PageSettings.Margins.Left = 0.1F;
            this.PageSettings.Margins.Top = 0.1F;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.489583F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            this.ReportStart += new System.EventHandler(this.BPCAInvoiceAdjustments_ReportStart);
            this.ReportEnd += new System.EventHandler(this.BPCAInvoiceAdjustments_ReportEnd);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.Label label1;
        private GrapeCity.ActiveReports.SectionReportModel.SubReport subReport1;
        private GrapeCity.ActiveReports.SectionReportModel.SubReport subReport2;
    }
}
