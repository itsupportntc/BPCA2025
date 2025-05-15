using System;
using System.Data;
using System.Globalization;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_PilotAdjDetails.
    /// </summary>
    public partial class DeficiencyReport_PilotAdjDetails : GrapeCity.ActiveReports.SectionReport
    {
        decimal baserent_amt = 0m;
        decimal civic_amt = 0m;
        decimal suppl_amt = 0m;
        decimal pilot_amt = 0m;

        decimal baserentsub_amt = 0m;
        decimal civicsub_amt = 0m;
        decimal supplsub_amt = 0m;
        decimal pilotsub_amt = 0m;

        public DeficiencyReport_PilotAdjDetails(DataTable dt)
        {
            InitializeComponent();
            DataSource = dt;
        }

        private void groupHeader1_Format(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(textTrxDate.Text))
            {
                labelPaybackFor.Text = string.Format("Unit paybacks for {0}", DateTime.Parse(textTrxDate.Text).ToString("MMM -yyyy"));
            }
        }

        private void groupHeader1_BeforePrint(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(textTrxDate.Text))
            //{
            //    labelPaybackFor.Text = string.Format(labelPaybackFor.Text, DateTime.Parse(textTrxDate.Text).ToString("MMM-yyyy"));
            //}
        }

        private void detail_Format(object sender, EventArgs e)
        {
            if (textBox8.Text == "Original")
            {
                baserent_amt += decimal.Parse(textBox4.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                civic_amt += decimal.Parse(textBox5.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                suppl_amt += decimal.Parse(textBox6.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                pilot_amt += decimal.Parse(textBox7.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));

                baserentsub_amt += decimal.Parse(textBox4.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                civicsub_amt += decimal.Parse(textBox5.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                supplsub_amt += decimal.Parse(textBox6.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                pilotsub_amt += decimal.Parse(textBox7.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            }
            else
            {
                baserent_amt -= decimal.Parse(textBox4.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                civic_amt -= decimal.Parse(textBox5.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                suppl_amt -= decimal.Parse(textBox6.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                pilot_amt -= decimal.Parse(textBox7.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));

                baserentsub_amt -= decimal.Parse(textBox4.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                civicsub_amt -= decimal.Parse(textBox5.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                supplsub_amt -= decimal.Parse(textBox6.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                pilotsub_amt -= decimal.Parse(textBox7.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            }
        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            textBox14.Value = baserent_amt;
            textBox15.Value = civic_amt;
            textBox16.Value = suppl_amt;
            textBox17.Value = pilot_amt;
        }

        private void groupFooter2_Format(object sender, EventArgs e)
        {
            textBox9.Value = baserentsub_amt;
            textBox10.Value = civicsub_amt;
            textBox11.Value = supplsub_amt;
            textBox12.Value = pilotsub_amt;
        }

        private void groupHeader2_Format(object sender, EventArgs e)
        {
            civicsub_amt = 0m;
            supplsub_amt = 0m;
            baserentsub_amt = 0m;
            pilotsub_amt = 0m;
        }
    }
}
