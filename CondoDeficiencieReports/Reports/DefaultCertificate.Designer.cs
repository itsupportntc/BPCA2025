namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DefaultCertificate.
    /// </summary>
    partial class DefaultCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultCertificate));
            this.pageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.textBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.pageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.label10 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.reportInfo3 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
            this.reportHeader1 = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
            this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.labelVerbiage = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.labelBuildingAddress = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
            this.imgLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
            this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.labelDefCertFor = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.reportFooter1 = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
            this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
            this.label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.label9 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelVerbiage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBuildingAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDefCertFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
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
            this.textBox4});
            this.detail.Height = 0.15625F;
            this.detail.Name = "detail";
            // 
            // textBox1
            // 
            this.textBox1.DataField = "titleName";
            this.textBox1.Height = 0.2F;
            this.textBox1.Left = 0.136F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Text = "Title Name";
            this.textBox1.Top = 0F;
            this.textBox1.Width = 1.781F;
            // 
            // textBox2
            // 
            this.textBox2.DataField = "unitCode";
            this.textBox2.Height = 0.2F;
            this.textBox2.Left = 2.01F;
            this.textBox2.Name = "textBox2";
            this.textBox2.Text = "Unit Code";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.135F;
            // 
            // textBox3
            // 
            this.textBox3.DataField = "owners";
            this.textBox3.Height = 0.2F;
            this.textBox3.Left = 3.219F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Text = "Unit Code";
            this.textBox3.Top = 0F;
            this.textBox3.Width = 3.062F;
            // 
            // textBox4
            // 
            this.textBox4.CurrencyCulture = new System.Globalization.CultureInfo("en-US");
            this.textBox4.DataField = "total";
            this.textBox4.Height = 0.2F;
            this.textBox4.Left = 6.771F;
            this.textBox4.Name = "textBox4";
            this.textBox4.OutputFormat = resources.GetString("textBox4.OutputFormat");
            this.textBox4.Style = "text-align: right";
            this.textBox4.Text = "Unit Code";
            this.textBox4.Top = 0F;
            this.textBox4.Width = 1.135F;
            // 
            // pageFooter
            // 
            this.pageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label10,
            this.reportInfo3});
            this.pageFooter.Height = 0.1270833F;
            this.pageFooter.Name = "pageFooter";
            // 
            // label10
            // 
            this.label10.Height = 0.138F;
            this.label10.HyperLink = null;
            this.label10.Left = 0.07300001F;
            this.label10.Name = "label10";
            this.label10.Style = "font-size: 7pt; font-weight: bold";
            this.label10.Text = "1  Common Charges being defined hearing to include Base Rent, PILOT, CFM and Supp" +
    "lemental Rent (if applicable)";
            this.label10.Top = 0.02F;
            this.label10.Width = 7.531F;
            // 
            // reportInfo3
            // 
            this.reportInfo3.FormatString = "Page {PageNumber} of {PageCount}";
            this.reportInfo3.Height = 0.138F;
            this.reportInfo3.Left = 5.76F;
            this.reportInfo3.Name = "reportInfo3";
            this.reportInfo3.Style = "font-size: 8pt; text-align: right";
            this.reportInfo3.Top = 0F;
            this.reportInfo3.Width = 2.146F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label1,
            this.label2,
            this.labelVerbiage,
            this.label4,
            this.labelBuildingAddress,
            this.reportInfo1,
            this.imgLogo,
            this.label3,
            this.label5,
            this.labelDefCertFor});
            this.reportHeader1.Height = 3.927084F;
            this.reportHeader1.Name = "reportHeader1";
            this.reportHeader1.Format += new System.EventHandler(this.reportHeader1_Format);
            // 
            // label1
            // 
            this.label1.Height = 0.1799999F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.07300001F;
            this.label1.Name = "label1";
            this.label1.Style = "";
            this.label1.Text = "To Whom It May Concern:";
            this.label1.Top = 2.998F;
            this.label1.Width = 1.771F;
            // 
            // label2
            // 
            this.label2.Height = 0.1799999F;
            this.label2.HyperLink = null;
            this.label2.Left = 0.989F;
            this.label2.Name = "label2";
            this.label2.Style = "text-decoration: underline";
            this.label2.Text = "RE: Default Certificate";
            this.label2.Top = 2.715F;
            this.label2.Width = 1.771F;
            // 
            // labelVerbiage
            // 
            this.labelVerbiage.Height = 0.6680002F;
            this.labelVerbiage.HyperLink = null;
            this.labelVerbiage.Left = 0.136F;
            this.labelVerbiage.Name = "labelVerbiage";
            this.labelVerbiage.Style = "text-align: left";
            this.labelVerbiage.Text = resources.GetString("labelVerbiage.Text");
            this.labelVerbiage.Top = 3.29F;
            this.labelVerbiage.Width = 7.77F;
            // 
            // label4
            // 
            this.label4.Height = 0.2F;
            this.label4.HyperLink = null;
            this.label4.Left = 0F;
            this.label4.Name = "label4";
            this.label4.Style = "font-weight: bold; text-align: center";
            this.label4.Text = "THE BOARD OF MANAGERS OF";
            this.label4.Top = 0.7690001F;
            this.label4.Width = 8.021F;
            // 
            // labelBuildingAddress
            // 
            this.labelBuildingAddress.Height = 0.7420001F;
            this.labelBuildingAddress.HyperLink = null;
            this.labelBuildingAddress.Left = 0F;
            this.labelBuildingAddress.Name = "labelBuildingAddress";
            this.labelBuildingAddress.Style = "font-weight: normal; text-align: center";
            this.labelBuildingAddress.Text = "THE BOARD OF MANAGERS OF";
            this.labelBuildingAddress.Top = 0.969F;
            this.labelBuildingAddress.Width = 8.021F;
            // 
            // reportInfo1
            // 
            this.reportInfo1.FormatString = "Printed On: {RunDateTime:MMMM d, yyyy}";
            this.reportInfo1.Height = 0.2F;
            this.reportInfo1.Left = 4.531F;
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Style = "text-align: right";
            this.reportInfo1.Top = 1.711F;
            this.reportInfo1.Width = 3.375F;
            // 
            // imgLogo
            // 
            this.imgLogo.Height = 0.7690001F;
            this.imgLogo.HyperLink = null;
            this.imgLogo.ImageData = ((System.IO.Stream)(resources.GetObject("imgLogo.ImageData")));
            this.imgLogo.Left = 2.676F;
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch;
            this.imgLogo.Top = 0F;
            this.imgLogo.Width = 2.792F;
            // 
            // label3
            // 
            this.label3.Height = 0.2F;
            this.label3.HyperLink = null;
            this.label3.Left = 0.136F;
            this.label3.Name = "label3";
            this.label3.Style = "font-weight: bold; text-decoration: underline";
            this.label3.Text = "BY HAND";
            this.label3.Top = 1.711F;
            this.label3.Width = 1F;
            // 
            // label5
            // 
            this.label5.Height = 0.742F;
            this.label5.HyperLink = null;
            this.label5.Left = 0.136F;
            this.label5.Name = "label5";
            this.label5.Style = "font-weight: normal; text-align: left";
            this.label5.Text = "Office of the Treasurer\r\nBattery Park City Authority\r\nOne World Financial Center-" +
    "24th Floor\r\nNew York, New York 10281-1097\r\n";
            this.label5.Top = 1.911F;
            this.label5.Width = 2.53F;
            // 
            // labelDefCertFor
            // 
            this.labelDefCertFor.Height = 0.2F;
            this.labelDefCertFor.HyperLink = null;
            this.labelDefCertFor.Left = 4.926F;
            this.labelDefCertFor.Name = "labelDefCertFor";
            this.labelDefCertFor.Style = "text-align: right";
            this.labelDefCertFor.Text = "RE: Default Certificate for {0}";
            this.labelDefCertFor.Top = 1.911F;
            this.labelDefCertFor.Width = 2.98F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Name = "reportFooter1";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.label6,
            this.label7,
            this.label8,
            this.label9});
            this.groupHeader1.Height = 0.283F;
            this.groupHeader1.Name = "groupHeader1";
            // 
            // label6
            // 
            this.label6.Height = 0.2F;
            this.label6.HyperLink = null;
            this.label6.Left = 0.136F;
            this.label6.Name = "label6";
            this.label6.Style = "text-decoration: underline";
            this.label6.Text = "Title Name";
            this.label6.Top = 0.083F;
            this.label6.Width = 1F;
            // 
            // label7
            // 
            this.label7.Height = 0.2F;
            this.label7.HyperLink = null;
            this.label7.Left = 2.01F;
            this.label7.Name = "label7";
            this.label7.Style = "text-decoration: underline";
            this.label7.Text = "Unit Code";
            this.label7.Top = 0.083F;
            this.label7.Width = 1F;
            // 
            // label8
            // 
            this.label8.Height = 0.2F;
            this.label8.HyperLink = null;
            this.label8.Left = 3.219F;
            this.label8.Name = "label8";
            this.label8.Style = "text-decoration: underline";
            this.label8.Text = "Unit Owners";
            this.label8.Top = 0.083F;
            this.label8.Width = 1F;
            // 
            // label9
            // 
            this.label9.Height = 0.2F;
            this.label9.HyperLink = null;
            this.label9.Left = 6.406F;
            this.label9.Name = "label9";
            this.label9.Style = "text-align: right; text-decoration: underline";
            this.label9.Text = "Deficiency Amount";
            this.label9.Top = 0.083F;
            this.label9.Width = 1.5F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Name = "groupFooter1";
            // 
            // DefaultCertificate
            // 
            this.MasterReport = false;
            this.PageSettings.Margins.Bottom = 0.1F;
            this.PageSettings.Margins.Left = 0.1F;
            this.PageSettings.Margins.Right = 0.1F;
            this.PageSettings.Margins.Top = 0.1F;
            this.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 7.989832F;
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
            this.ReportEnd += new System.EventHandler(this.DefaultCertificate_ReportEnd);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelVerbiage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBuildingAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDefCertFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private GrapeCity.ActiveReports.SectionReportModel.ReportHeader reportHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label2;
        private GrapeCity.ActiveReports.SectionReportModel.Label labelVerbiage;
        private GrapeCity.ActiveReports.SectionReportModel.ReportFooter reportFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label4;
        private GrapeCity.ActiveReports.SectionReportModel.Label labelBuildingAddress;
        private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
        private GrapeCity.ActiveReports.SectionReportModel.Picture imgLogo;
        private GrapeCity.ActiveReports.SectionReportModel.Label label3;
        private GrapeCity.ActiveReports.SectionReportModel.Label label5;
        private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label6;
        private GrapeCity.ActiveReports.SectionReportModel.Label label7;
        private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter1;
        private GrapeCity.ActiveReports.SectionReportModel.Label label8;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox2;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox3;
        private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox4;
        private GrapeCity.ActiveReports.SectionReportModel.Label label9;
        private GrapeCity.ActiveReports.SectionReportModel.Label label10;
        private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo3;
        private GrapeCity.ActiveReports.SectionReportModel.Label labelDefCertFor;
    }
}
