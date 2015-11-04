namespace Pinarik
{
    partial class monthControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameMonth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameMonth
            // 
            this.nameMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameMonth.Location = new System.Drawing.Point(0, 0);
            this.nameMonth.Name = "nameMonth";
            this.nameMonth.Size = new System.Drawing.Size(247, 27);
            this.nameMonth.TabIndex = 0;
            this.nameMonth.Text = "Month";
            this.nameMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shapeContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 225);
            this.panel1.TabIndex = 1;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Transparent;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.lineShape1.Visible = false;
            this.lineShape1.X1 = 131;
            this.lineShape1.X2 = 167;
            this.lineShape1.Y1 = 125;
            this.lineShape1.Y2 = 125;
            // 
            // shapeContainer
            // 
            this.shapeContainer.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer.Name = "shapeContainer";
            this.shapeContainer.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer.Size = new System.Drawing.Size(247, 225);
            this.shapeContainer.TabIndex = 2;
            this.shapeContainer.TabStop = false;
            // 
            // monthControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameMonth);
            this.Name = "monthControl";
            this.Size = new System.Drawing.Size(247, 252);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameMonth;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer;
    }
}
