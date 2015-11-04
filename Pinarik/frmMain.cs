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
    public partial class frmMain : Form
    {
        private Options optionsPinarik;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            cbAllYear.Checked = true;
            for (int y = DateTime.Now.Year; y <= DateTime.Now.Year + 10; y++)
            {
                cbYear.Items.Add(y);
            }

            for (int i = 1; i <= 12; i++)
            {
                DateTime dt = new DateTime(DateTime.Now.Year, i, 1);
                cbMonthFrom.Items.Add(dt.ToString("MMMM"));
                cbMonthTo.Items.Add(dt.ToString("MMMM"));
            }

            cbMonthFrom.SelectedItem = cbMonthTo.SelectedItem = DateTime.Now.ToString("MMMM");
            cbYear.SelectedItem = DateTime.Now.Year;

            this.optionsPinarik = new Options(); 
        }

        private void cbAllYear_CheckedChanged(object sender, EventArgs e)
        {
            cbMonthFrom.Enabled = cbMonthTo.Enabled = !cbAllYear.Checked;
        }

        private void fillOptions()
        {
            this.optionsPinarik.Name = tbName.Text;
            this.optionsPinarik.AllYear = cbAllYear.Checked;
            this.optionsPinarik.Year = Convert.ToInt32(cbYear.Text);
        }

        private void tsRun_Click(object sender, EventArgs e)
        {
            this.fillOptions();
            frmPreview frm = new frmPreview(this.optionsPinarik);
            frm.ShowDialog();
        }
    }
}
