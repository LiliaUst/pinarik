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
        private Options options = null;
        private PinarikPreview pinarik = null;

        public frmPreview(Options options)
        {
            InitializeComponent();

            this.SetOptions(options);
            this.Redraw();
            //this.userControl11.setOptions(options);
            //this.userControl11.redraw();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void SetOptions(Options options)
        {
            this.options = options;
            this.pinarik = new PinarikPreview(this.options);
        }

        private void Redraw()
        {
            string pathTmpPreview = Path.GetFullPath("index.html");
            StreamWriter wr = new StreamWriter(pathTmpPreview);
            wr.Write(this.pinarik.GetContent());
            wr.Close();

            webControl1.Source = new Uri(pathTmpPreview);

            //webControl1.LoadHTML(this.pinarik.GetContent());

            //container.Navigate("about:blank");
            //container.Document.Write(this.pinarik.GetContent());

            //byte[] byteArray = Encoding.UTF8.GetBytes(this.pinarik.GetContent());
            //MemoryStream stream = new MemoryStream(byteArray);
            //container.DocumentStream = stream;


            //container.DocumentText = this.pinarik.GetContent();
            //this.name.Text = this.options.Year + (!String.IsNullOrEmpty(this.options.Name) ? " - " + this.options.Name : "");

            //monthControl1.setOptions(this.options.MonthFrom, this.options.Year);
            //monthControl1.redraw();

            
        }

        private void frmPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            webControl1.Dispose();
        }


    }
}
