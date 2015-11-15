using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pinarik
{
    public partial class frmPreview : Form
    {
        private PinarikData pinarikData = null;
        private PinarikView pinarikView = null;

        public frmPreview(PinarikData data)
        {
            InitializeComponent();

            this.SetOptions(data);
            this.Redraw();
            //this.userControl11.setOptions(options);
            //this.userControl11.redraw();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void SetOptions(PinarikData data)
        {
            this.pinarikData = data;
            this.pinarikView = new PinarikView(this.pinarikData);
        }

        private void Redraw()
        {
            webControl1.Source = new Uri(this.pinarikView.CreateViewFile());
        }

        private void frmPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            webControl1.Dispose();
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока не реализовано");
        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            frmSettting frm = new frmSettting(this.pinarikData);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.SetOptions(frm.GetOptions());
                this.Redraw();
            }
        }


    }
}
