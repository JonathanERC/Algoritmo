using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            if (label2.ForeColor == Color.Black)
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string audio = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(audio+@"\sfx-blipmale.wav");
            player.Play();

            if (String.IsNullOrEmpty(txt1.Text))
            {
                label2.Text = "";
                txt = "LA CAJA ESTA VACÍA";
                len = txt.Length;

                counter++;

                if (counter > len)
                {
                    counter = 0;
                    label2.Text = "";
                }
                else
                {
                    label2.Text = txt.Substring(0, counter);
                }

                if (counter == txt.Length)
                {
                    timer1.Stop();
                }
                else
                {
                    //counter++;
                }
            }
            else
            {
                label2.Text = "";
                txt = "EN LA CAJA HAY " + Convert.ToString(txt1.Text).ToUpper();
                len = txt.Length;

                counter++;

                if (counter > len)
                {
                    counter = 0;
                    label2.Text = "";
                }
                else
                {
                    label2.Text = txt.Substring(0, counter);
                }

                if (counter == txt.Length)
                {
                    timer1.Stop();
                }
                else
                {
                    //counter++;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label2.ForeColor == Color.Black)
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
