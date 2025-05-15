using System;
using System.Data;

namespace CondoDeficiencyReports
{
    /// <summary>
    /// Summary description for DeficiencyReport_RollbackDetailSummary.
    /// </summary>
    public partial class DeficiencyReport_RollbackDetailDefaults : GrapeCity.ActiveReports.SectionReport
    {
        decimal InvoiceTotal_amt = 0m;
        decimal RollbackDiff_amt = 0m;

        decimal InvAmt = 0m;
        decimal Rollbackamt = 0m;
        decimal sum = 0m;

        DateTime rollbackdate = DateTime.Now;

        public DeficiencyReport_RollbackDetailDefaults(DataTable dt)
        {
            InitializeComponent();
            DataSource = dt;
        }

        private void detail_Format(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "Original Default")
            {
                InvoiceTotal_amt += decimal.Parse(textBox8.Text, System.Globalization.NumberStyles.Any);
                RollbackDiff_amt += decimal.Parse(textBox14.Text, System.Globalization.NumberStyles.Any);
               

            }
            else
            {
                InvoiceTotal_amt -= decimal.Parse(textBox8.Text, System.Globalization.NumberStyles.Any);
                RollbackDiff_amt -= decimal.Parse(textBox14.Text, System.Globalization.NumberStyles.Any);
                
            }
        }

        private void groupFooter1_Format(object sender, System.EventArgs e)
        {
            textBox10.Value = (InvoiceTotal_amt + RollbackDiff_amt);
            label12.Visible = true;
            textBox11.Visible = true;
            label13.Visible = true;
            textBox10.Visible = true;
            line2.Visible = true;
            line4.Visible = true;
        }

        private void groupHeader2_Format(object sender, System.EventArgs e)
        {
            //if (rollbackdate != Convert.ToDateTime(textBox19.Text).Date)
            //{
                InvoiceTotal_amt = 0m;
                RollbackDiff_amt = 0m;
                rollbackdate = Convert.ToDateTime(textBox19.Text);
                rollbackdate = rollbackdate.Date;
            //}
            //else
            //{
            //    InvAmt = 0m;
            //    Rollbackamt = 0m;
            //}
        }

        private void groupFooter2_Format(object sender, System.EventArgs e)
        {
            textBox12.Value = InvoiceTotal_amt;
            textBox9.Value = RollbackDiff_amt;
            textBox17.Value = (InvoiceTotal_amt + RollbackDiff_amt);
            if (rollbackdate != Convert.ToDateTime(textBox19.Text).Date)
            {
                label2.Visible = true;
                textBox18.Visible = true;
                label10.Visible = true;
                textBox17.Visible = true;
                line1.Visible = true;
                line3.Visible = true;

            }
            else
            {
                label2.Visible = false;
                textBox18.Visible = false;
                label10.Visible = false;
                textBox17.Visible = false;
                line1.Visible = false;
                line3.Visible = false;
            }

        }
    }
}
