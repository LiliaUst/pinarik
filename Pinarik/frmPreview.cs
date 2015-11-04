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
    public partial class frmPreview : Form
    {
        private Options options = null;

        public frmPreview(Options options)
        {
            InitializeComponent();

            this.setOptions(options);
            this.redraw();
            //this.userControl11.setOptions(options);
            //this.userControl11.redraw();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void setOptions(Options options)
        {
            this.options = options;
        }

        private void redraw()
        {
            this.name.Text = this.options.Year + (!String.IsNullOrEmpty(this.options.Name) ? " - " + this.options.Name : "");

            monthControl1.setOptions(this.options.MonthFrom, this.options.Year);
            monthControl1.redraw();
        }
    }
}
