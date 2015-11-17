using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Awesomium.Windows.Forms;
using Awesomium.Core;
using System.Diagnostics;
using Microsoft.Win32;

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
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            try { ProcessEx.SetIE9KeyforWebBrowserControl(Process.GetCurrentProcess().ProcessName + ".exe"); }
            catch { }
        }

        private void SetOptions(PinarikData data)
        {
            this.pinarikData = data;
            this.pinarikView = new PinarikView(this.pinarikData);
        }
        
        private void Redraw()
        {
            this.pinarikView.CreateViewFile();
            webBrowser1.Navigate(new Uri(this.pinarikView.UriView));
        }

        private void frmPreview_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            
            webBrowser1.ShowPrintPreviewDialog();

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

        private void tsOpenHtml_Click(object sender, EventArgs e)
        {
            Process.Start(this.pinarikView.UriView);
        }

        private void tsExportHtml_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }


    }
}
