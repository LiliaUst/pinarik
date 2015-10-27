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
        public frmPreview(Options options)
        {
            InitializeComponent();

            this.userControl11.setOptions(options);
            this.userControl11.redraw();
        }
    }
}
