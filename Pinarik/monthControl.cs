using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Pinarik
{
    public partial class monthControl : UserControl
    {
        private int month;
        private int year;
        private IList<Shape> listShape = new List<Shape>();

        private const int widthShape = 25;

        public monthControl()
        {
            InitializeComponent();
        }

        public void redraw()
        {
            this.nameMonth.Text = Global.getNameMonth(this.month);
            int x = 8, y = 8;
            DateTime dt = new DateTime(DateTime.Now.Year, month, 2);

            for (int l = 1; l <= 7; l++)
            {
            }

            int day = Global.getDayOfWeek(this.month, this.year);
            int i = 1;
            for (; i < day; i++)
            {
                listShape.Add(this.createShape(i, x, y, Color.Gray));
                x += widthShape + 8;
            }

            for (; i < DateTime.DaysInMonth(year, month) + day; i++)
            {
                listShape.Add(this.createShape(i, x, y, Color.Black));
                x += widthShape + 8;
                if (i % 7 == 0)
                {
                    x = 8;
                    y += widthShape + 8;
                }
            }

            int cnt = i % 7 == 0 ? 1 : (7 - i % 7 + 1);
            if (cnt < 7)
            {
                for (int j = 1; j <= cnt; j++, i++)
                {
                    listShape.Add(this.createShape(i, x, y, Color.Gray));
                    x += widthShape + 8;
                }
            }
            this.shapeContainer.Shapes.AddRange(listShape.ToArray<Shape>());
        }

        private Shape createShape(int i, int x, int y, Color color) 
        {
            OvalShape shape = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            shape.BorderColor = color;
            shape.BorderWidth = 2;
            shape.Location = new System.Drawing.Point(x, y);
            shape.Name = "ovalShape" + i;
            shape.Size = new System.Drawing.Size(widthShape, widthShape);
            return shape;
        }

        public void setOptions(int month, int year)
        {
            this.month = month;
            this.year = year;
        }
    }
}
