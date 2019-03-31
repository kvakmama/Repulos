using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repulos
{
    partial class Form1 : Form
    {
        public Renderer renderer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            if (renderer!= null)
            {
                renderer.paint(formGraphics);
            }
            formGraphics.Dispose();
        }
    }
}
