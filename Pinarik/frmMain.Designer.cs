namespace Pinarik
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbMonthTo = new System.Windows.Forms.ComboBox();
            this.cbMonthFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAllYear = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsOpen = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsRun = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.Controls.Add(this.cbMonthTo, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbMonthFrom, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbYear, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbAllYear, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 272);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cbMonthTo
            // 
            this.cbMonthTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonthTo.FormattingEnabled = true;
            this.cbMonthTo.Location = new System.Drawing.Point(319, 92);
            this.cbMonthTo.Name = "cbMonthTo";
            this.cbMonthTo.Size = new System.Drawing.Size(164, 21);
            this.cbMonthTo.TabIndex = 7;
            // 
            // cbMonthFrom
            // 
            this.cbMonthFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonthFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonthFrom.FormattingEnabled = true;
            this.cbMonthFrom.Location = new System.Drawing.Point(76, 92);
            this.cbMonthFrom.Name = "cbMonthFrom";
            this.cbMonthFrom.Size = new System.Drawing.Size(164, 21);
            this.cbMonthFrom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Год";
            // 
            // cbYear
            // 
            this.cbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(76, 5);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(97, 21);
            this.cbYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Месяц с";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Месяц по";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Весь год";
            // 
            // cbAllYear
            // 
            this.cbAllYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAllYear.AutoSize = true;
            this.cbAllYear.Location = new System.Drawing.Point(76, 70);
            this.cbAllYear.Name = "cbAllYear";
            this.cbAllYear.Size = new System.Drawing.Size(15, 14);
            this.cbAllYear.TabIndex = 5;
            this.cbAllYear.UseVisualStyleBackColor = true;
            this.cbAllYear.CheckedChanged += new System.EventHandler(this.cbAllYear_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.tbName, 3);
            this.tbName.Location = new System.Drawing.Point(76, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(407, 20);
            this.tbName.TabIndex = 9;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.tsOpen,
            this.tsSave,
            this.toolStripSeparator1,
            this.tsRun});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(544, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNew.Image = global::Pinarik.Properties.Resources._new;
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(23, 22);
            this.tsNew.Text = "Новый";
            this.tsNew.ToolTipText = "Создать новый файл настроек";
            // 
            // tsOpen
            // 
            this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpen.Image = global::Pinarik.Properties.Resources.open;
            this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(23, 22);
            this.tsOpen.Text = "Открыть";
            this.tsOpen.ToolTipText = "Открыть существующий файл";
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = global::Pinarik.Properties.Resources.save;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(23, 22);
            this.tsSave.Text = "Сохранить";
            this.tsSave.ToolTipText = "Сохранить файл настроек";
            // 
            // tsRun
            // 
            this.tsRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRun.Image = global::Pinarik.Properties.Resources.run;
            this.tsRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRun.Name = "tsRun";
            this.tsRun.Size = new System.Drawing.Size(23, 22);
            this.tsRun.Text = "Предпросмотр";
            this.tsRun.ToolTipText = "Сформировать пинарик";
            this.tsRun.Click += new System.EventHandler(this.tsRun_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 297);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пинарик";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMonthTo;
        private System.Windows.Forms.ComboBox cbMonthFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAllYear;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsOpen;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRun;
    }
}

