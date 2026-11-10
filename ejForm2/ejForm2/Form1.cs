using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            this.CancelButton = button1;
            this.AcceptButton= button2;

            textBox1.Tag="rgb";
            textBox2.Tag="rgb";
            textBox3.Tag = "rgb";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextChanged += textBox2_TextChanged;
            textBox3.TextChanged += textBox2_TextChanged;
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Desea salir del formulario", "Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            
            int  r= int.Parse(textBox1.Text);
            int g = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            if (r > 0 && g > 0 && b > 0 && r<255 && g<255 && b<255)
            {
                this.BackColor = Color.FromArgb(r, g, b);
            }
            else
            {
                MessageBox.Show("numeros fuera de rango");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String rt = textBox4.Text;

            if(!(rt.Trim()==" "))
            {
                pictureBox1.Image = Image.FromFile(rt);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls){


                if (c.GetType() == typeof(TextBox))
                {

                    TextBox t = (TextBox)c;
                   
                    if( c.Tag != null && c.Tag.ToString() == "rgb" )
                    {
                        t.Text = ""+0;
                    }
                    else
                    {
                        t.Text = "";
                    }
                }
                if(c.GetType() == typeof(PictureBox))
                {
                    PictureBox p = (PictureBox)c;

                    p.Image = null;
                }



            }
        }
        private Color og;
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                og = bt.BackColor;
                bt.BackColor = Color.Red;
            }
        }
        
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
           if (sender is Button bt)
            {
               
                bt.BackColor = og;
            }
        }
    }
}
