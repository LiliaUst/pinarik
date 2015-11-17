namespace Pinarik
{
    partial class frmPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreview));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsOpenHtml = new System.Windows.Forms.ToolStripButton();
            this.tsExportHtml = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSettings = new System.Windows.Forms.ToolStripButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPrint,
            this.tsOpenHtml,
            this.tsExportHtml,
            this.toolStripSeparator1,
            this.tsSettings});
            this.toolStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1284, 38);
            this.toolStripMain.TabIndex = 6;
            this.toolStripMain.Text = "Основная";
            // 
            // tsPrint
            // 
            this.tsPrint.Image = global::Pinarik.Properties.Resources.print;
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(50, 35);
            this.tsPrint.Text = "Печать";
            this.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPrint.ToolTipText = "Печать пинарика";
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // tsOpenHtml
            // 
            this.tsOpenHtml.Image = global::Pinarik.Properties.Resources.open;
            this.tsOpenHtml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenHtml.Name = "tsOpenHtml";
            this.tsOpenHtml.Size = new System.Drawing.Size(38, 35);
            this.tsOpenHtml.Text = "Html";
            this.tsOpenHtml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsOpenHtml.ToolTipText = "Открыть Html файл";
            this.tsOpenHtml.Click += new System.EventHandler(this.tsOpenHtml_Click);
            // 
            // tsExportHtml
            // 
            this.tsExportHtml.Image = global::Pinarik.Properties.Resources.save;
            this.tsExportHtml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExportHtml.Name = "tsExportHtml";
            this.tsExportHtml.Size = new System.Drawing.Size(56, 35);
            this.tsExportHtml.Text = "Экспорт";
            this.tsExportHtml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsExportHtml.ToolTipText = "Сохранить пинарик в Html-файл";
            this.tsExportHtml.Click += new System.EventHandler(this.tsExportHtml_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsSettings
            // 
            this.tsSettings.Image = global::Pinarik.Properties.Resources.settings;
            this.tsSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSettings.Name = "tsSettings";
            this.tsSettings.Size = new System.Drawing.Size(71, 35);
            this.tsSettings.Text = "Настройки";
            this.tsSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSettings.ToolTipText = "Настройка пинарика";
            this.tsSettings.Click += new System.EventHandler(this.tsSettings_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Pinarik";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1284, 557);
            this.webBrowser1.TabIndex = 7;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 595);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStripMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 100);
            this.Name = "frmPreview";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пинарик";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPreview_FormClosed);
            this.Load += new System.EventHandler(this.frmPreview_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsSettings;
        private System.Windows.Forms.ToolStripButton tsOpenHtml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton tsExportHtml;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;




    }
}