using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej3Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Selector de imagens";
            f.Filter = "Imagenes: |*.jpg;*.png | todos los archivos | *.* ";
            if(f.ShowDialog()== DialogResult.OK)
            {
                string rt;
                rt = f.FileName;

                Form2 vs = new Form2(rt);
                if (checkBox1.Checked)
                {
                    vs.ShowDialog();
                }
                else
                {
                     vs.Show();
                }

               

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Color cm;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                cm = checkBox1.ForeColor;
                checkBox1.ForeColor = Color.Red;
            }
            else
            {
                checkBox1.ForeColor = cm;
            }
        }
        private int s=0;
        private int m = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                m++;
                s = 0;
            }

            this.Text = $"Visor de imagenes{m:D2}:{s:D2}";
            
           
        }
    }
}
