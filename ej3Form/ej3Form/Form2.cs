using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej3Form
{
    public partial class Form2 : Form
    {
        public Form2(String rt)
        {
            InitializeComponent();
            this.Text = Path.GetFileName(rt);

            pictureBox1.Image = Image.FromFile(rt);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void deformarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
