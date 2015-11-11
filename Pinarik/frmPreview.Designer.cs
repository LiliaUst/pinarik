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
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.WebBrowser();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.monthControl1 = new Pinarik.monthControl();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoEllipsis = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(485, 458);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(5);
            this.name.Size = new System.Drawing.Size(272, 39);
            this.name.TabIndex = 2;
            this.name.Text = "Title";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.name.Visible = false;
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(0, 437);
            this.container.MinimumSize = new System.Drawing.Size(20, 20);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(248, 158);
            this.container.TabIndex = 4;
            this.container.Visible = false;
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.NavigationInfo = Awesomium.Core.NavigationInfo.None;
            this.webControl1.Size = new System.Drawing.Size(1284, 595);
            this.webControl1.TabIndex = 5;
            // 
            // monthControl1
            // 
            this.monthControl1.BackColor = System.Drawing.Color.Transparent;
            this.monthControl1.Location = new System.Drawing.Point(512, 517);
            this.monthControl1.Name = "monthControl1";
            this.monthControl1.Size = new System.Drawing.Size(245, 245);
            this.monthControl1.TabIndex = 3;
            this.monthControl1.Visible = false;
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 595);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.container);
            this.Controls.Add(this.monthControl1);
            this.Controls.Add(this.name);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(250, 100);
            this.Name = "frmPreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пинарик - Предпросмотр";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPreview_FormClosed);
            this.Load += new System.EventHandler(this.frmPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private monthControl monthControl1;
        private System.Windows.Forms.WebBrowser container;
        private Awesomium.Windows.Forms.WebControl webControl1;




    }
}