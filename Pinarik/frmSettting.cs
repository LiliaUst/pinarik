using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pinarik
{
    public partial class frmSettting : Form
    {
        private PinarikData pinarikData;

        public frmSettting() 
            : this(new PinarikData())
        {
        }

        public frmSettting(PinarikData data)
        {
            InitializeComponent();

            this.pinarikData = data;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            cbAllYear.Checked = this.pinarikData.AllYear;
            for (int y = DateTime.Now.Year; y <= DateTime.Now.Year + 10; y++)
            {
                cbYear.Items.Add(y);
            }

            for (int i = 1; i <= 12; i++)
            {
                string month = Global.getNameMonth(i);
                cbMonthFrom.Items.Add(month);
                cbMonthTo.Items.Add(month);
            }

            cbMonthFrom.SelectedItem = new DateTime(this.pinarikData.Year, this.pinarikData.MonthFrom, 1).ToString("MMMM");
            cbMonthTo.SelectedItem = new DateTime(this.pinarikData.Year, this.pinarikData.MonthTo, 1).ToString("MMMM");
            cbYear.SelectedItem = this.pinarikData.Year;

            tbName.Text = this.pinarikData.Name;
        }

        private void cbAllYear_CheckedChanged(object sender, EventArgs e)
        {
            cbMonthFrom.Enabled = cbMonthTo.Enabled = !cbAllYear.Checked;
        }

        private void fillOptions()
        {
            this.pinarikData.Name = tbName.Text;
            this.pinarikData.AllYear = cbAllYear.Checked;
            this.pinarikData.Year = Convert.ToInt32(cbYear.Text);
            this.pinarikData.MonthFrom = cbMonthFrom.SelectedIndex + 1;
            this.pinarikData.MonthTo = cbMonthTo.SelectedIndex + 1;
        }

        private void tsRun_Click(object sender, EventArgs e)
        {
            this.fillOptions();
            frmPreview frm = new frmPreview(this.pinarikData);
            frm.ShowDialog();
        }

        public PinarikData GetOptions()
        {
            this.fillOptions();
            return this.pinarikData;
        }
    }
}
