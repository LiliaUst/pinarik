using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pinarik
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private Options options;

        public UserControl1()
        {
            InitializeComponent();
        }

        public void setOptions(Options options)
        {
            this.options = options;
        }

        public void redraw()
        {
            tbName.Text = this.options.Year + (!String.IsNullOrEmpty(this.options.Name) ? " - " + this.options.Name : "");
        }
    }
}
