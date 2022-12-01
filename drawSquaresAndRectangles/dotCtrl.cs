using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawSquaresAndRectangles
{
    public partial class dotCtrl : UserControl
    {
        public dotCtrl()
        {
            InitializeComponent();
        }

        Form1 f;
        public int ismd = 0;

        private void dotCtrl_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void dotCtrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
                f.drawLines();
            }
        }

        private void dotCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void dotCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch{}
        }
    }
}
