using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class UserInterface : Form
    {
        private MandelDrawer mandelDrawer;
        private Bitmap mandelnumberList;

        public UserInterface()
        {
            InitializeComponent();
            mandelDrawer = new MandelDrawer(-2, 2, 2, -2);
            mandelnumberList = new Bitmap(splitContainer1.Panel1.Height, splitContainer1.Panel1.Width);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(mandelnumberList, Point.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mandelnumberList = mandelDrawer.list();
        }
    }
}
