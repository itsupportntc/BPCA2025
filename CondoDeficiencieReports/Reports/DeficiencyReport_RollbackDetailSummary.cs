using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_RollbackDetailSummary.
    /// </summary>
    public partial class DeficiencyReport_RollbackDetailSummary : GrapeCity.ActiveReports.SectionReport
    {
        decimal baserent_amt = 0m;
        decimal civic_amt = 0m;
        decimal suppl_amt = 0m;
        decimal pilot_amt = 0m;

        decimal baserentsub_amt = 0m;
        decimal civicsub_amt = 0m;
        decimal supplsub_amt = 0m;
        decimal pilotsub_amt = 0m;
        
        public DeficiencyReport_RollbackDetailSummary(DataTable dt)
        {
            InitializeComponent();
            DataSource = dt;
        }

        private void detail_Format(object sender, System.EventArgs e)
        {
            if (textBox8.Text == "Original Amount")
            {
                civic_amt += decimal.Parse(textBox4.Text, System.Globalization.NumberStyles.Any);
                suppl_amt += decimal.Parse(textBox5.Text, System.Globalization.NumberStyles.Any);
                baserent_amt += decimal.Parse(textBox6.Text, System.Globalization.NumberStyles.Any);
                pilot_amt += decimal.Parse(textBox7.Text, System.Globalization.NumberStyles.Any);

                civicsub_amt += decimal.Parse(textBox4.Text, System.Globalization.NumberStyles.Any);
                supplsub_amt += decimal.Parse(textBox5.Text, System.Globalization.NumberStyles.Any);
                baserentsub_amt += decimal.Parse(textBox6.Text, System.Globalization.NumberStyles.Any);
                pilotsub_amt += decimal.Parse(textBox7.Text, System.Globalization.NumberStyles.Any);
            }
            else
            {
                civic_amt -= decimal.Parse(textBox4.Text, System.Globalization.NumberStyles.Any);
                suppl_amt -= decimal.Parse(textBox5.Text, System.Globalization.NumberStyles.Any);
                baserent_amt -= decimal.Parse(textBox6.Text, System.Globalization.NumberStyles.Any);
                pilot_amt -= decimal.Parse(textBox7.Text, System.Globalization.NumberStyles.Any);

                civicsub_amt -= decimal.Parse(textBox4.Text, System.Globalization.NumberStyles.Any);
                supplsub_amt -= decimal.Parse(textBox5.Text, System.Globalization.NumberStyles.Any);
                baserentsub_amt -= decimal.Parse(textBox6.Text, System.Globalization.NumberStyles.Any);
                pilotsub_amt -= decimal.Parse(textBox7.Text, System.Globalization.NumberStyles.Any);
            }
        }

        private void groupFooter1_Format(object sender, System.EventArgs e)
        {
            textBox14.Value = baserent_amt;
            textBox15.Value = civic_amt;
            textBox16.Value = suppl_amt;
            textBox17.Value = pilot_amt;
        }

        private void groupHeader2_Format(object sender, System.EventArgs e)
        {
            civicsub_amt = 0m;
            supplsub_amt = 0m;
            baserentsub_amt = 0m;
            pilotsub_amt = 0m;
        }

        private void groupFooter2_Format(object sender, System.EventArgs e)
        {
            textBox9.Value = baserentsub_amt;
            textBox10.Value = civicsub_amt;
            textBox11.Value = supplsub_amt;
            textBox12.Value = pilotsub_amt;
        }
    }
}
